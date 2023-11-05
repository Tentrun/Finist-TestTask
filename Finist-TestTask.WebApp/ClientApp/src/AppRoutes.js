import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import HomePage from "./components/Pages/homePage";
import Dashboard from "./components/UI/Dashboard/Dashboard";
import AuthPage from "./components/Pages/authPage";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/dashboard',
    element: <Dashboard />
  },
  {
    path: '/login',
    element: <AuthPage />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  }
];

export default AppRoutes;
