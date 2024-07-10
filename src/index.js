import React from 'react';
import * as ReactDOM from 'react-dom';
import { createBrowserRouter, RouterProvider } from "react-router-dom";

import './index.css';

import Food from './Pages/Food';
import Layout from './Layout';
import NewFood from './Pages/NewFood';
import ModifyFood from './Pages/ModifyFood';

const router = createBrowserRouter([
  {
    element: <Layout />,
    children: [

      {
        path: "/food",
        element: <Food/>,
      },
      {
        path: "/food/new",
        element: <NewFood/>,
      },
      {
        path: "/food/:id",
        element: <ModifyFood/>,
      },
      {
        path: "*",
        element: <Food/>,
      },
    ]
  }
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
        <RouterProvider router={router} />
  </React.StrictMode>
);
