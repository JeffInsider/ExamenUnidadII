import { Navigate } from "react-router-dom";
import { Layout } from "../components";
import { TodoListPages, LoginPages } from "../pages";

const PrivateRoutes = () => {
    return {
        element: <Layout/>,
        children: [
            {
                path: "/",
                element: <TodoListPages/>
            },
            {
                path: "/login",
                element: <LoginPages/>
            },
            {
                //cualquier cosa que meta en la url es el *
                path: "*",
                element: <Navigate to={'/'} replace/>
            }
        ] 
    };
}