import { createBrowserRouter } from "react-router-dom"
import PrivateRoutes from "./PrivateRoutes"

const Router = () => {
    return createBrowserRouter([
        PrivateRoutes()])
}

export default Router