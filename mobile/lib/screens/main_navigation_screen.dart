import 'package:flutter/material.dart';
import 'home_screen.dart';
import 'search_screen.dart';
import 'create_meal/create_screen.dart';
import 'account_screen.dart';

class MainNavigationScreen extends StatefulWidget {
  const MainNavigationScreen({super.key});

  static final GlobalKey<_MainNavigationScreenState> mainNavKey =
      GlobalKey<_MainNavigationScreenState>();

  static void switchToTab(int index) {
    mainNavKey.currentState?._onItemTapped(index);
  }

  @override
  State<MainNavigationScreen> createState() => _MainNavigationScreenState();
}

class _MainNavigationScreenState extends State<MainNavigationScreen> {
  int _selectedIndex = 0;

  // Navigator keys for each tab
  final List<GlobalKey<NavigatorState>> _navigatorKeys = [
    GlobalKey<NavigatorState>(), // Home
    GlobalKey<NavigatorState>(), // Search
    GlobalKey<NavigatorState>(), // Create
    GlobalKey<NavigatorState>(), // Account
  ];

  void _onItemTapped(int index) {
    if (index == _selectedIndex) {
      // If tapping the active tab, pop to first route
      _navigatorKeys[index].currentState?.popUntil((route) => route.isFirst);
    } else {
      setState(() {
        _selectedIndex = index;
      });
    }
  }

  // Determine if the current navigator can pop
  bool get _canPop {
    return _navigatorKeys[_selectedIndex].currentState?.canPop() ?? false;
  }

  @override
  Widget build(BuildContext context) {
    return PopScope(
      canPop: _canPop,
      onPopInvokedWithResult: (bool didPop, dynamic result) {
        if (!didPop) {
          if (_selectedIndex != 0) {
            // If not on Home tab, switch to Home tab
            _onItemTapped(0);
          }
          // If on Home tab and cannot pop, allow the system to handle the pop (e.g., exit the app)
        }
        // If didPop is true, the pop was handled by the current navigator
      },
      child: Scaffold(
        body: IndexedStack(
          index: _selectedIndex,
          children: [
            _buildNavigator(0, const HomeScreen()),
            _buildNavigator(1, const SearchScreen()),
            _buildNavigator(2, const CreateScreen()),
            _buildNavigator(3, const AccountScreen()),
          ],
        ),
        bottomNavigationBar: BottomNavigationBar(
          type: BottomNavigationBarType.fixed,
          currentIndex: _selectedIndex,
          onTap: _onItemTapped,
          selectedItemColor: Theme.of(context).primaryColor,
          unselectedItemColor: Colors.grey,
          items: const [
            BottomNavigationBarItem(
              icon: Icon(Icons.home_outlined),
              activeIcon: Icon(Icons.home),
              label: 'Home',
            ),
            BottomNavigationBarItem(
              icon: Icon(Icons.search_outlined),
              activeIcon: Icon(Icons.search),
              label: 'Search',
            ),
            BottomNavigationBarItem(
              icon: Icon(Icons.add_circle_outline),
              activeIcon: Icon(Icons.add_circle),
              label: 'Create',
            ),
            BottomNavigationBarItem(
              icon: Icon(Icons.person_outline),
              activeIcon: Icon(Icons.person),
              label: 'Account',
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildNavigator(int index, Widget child) {
    return Navigator(
      key: _navigatorKeys[index],
      onGenerateRoute: (settings) {
        return MaterialPageRoute(
          builder: (context) => child,
        );
      },
    );
  }
}
