import AuthPage from "./components/Pages/authPage";
import Dashboard from "./components/UI/Elements/Dashboard/Dashboard";

const AppRoutes = [
  {
    path: '/dashboard',
    element: <Dashboard />
  },
  {
    index: true,
    path: '/login',
    element: <AuthPage />
  }
];

export default AppRoutes;
