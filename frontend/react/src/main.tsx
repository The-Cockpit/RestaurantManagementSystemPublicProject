import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import './index.css'
import { registerLicense } from '@syncfusion/ej2-base';
import { GoogleOAuthProvider } from '@react-oauth/google';
import js from '../sicret.json'

registerLicense(js.syncfusionkey);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <GoogleOAuthProvider clientId={js.clientId}>
    <React.StrictMode>
      <App />
    </React.StrictMode>
  </GoogleOAuthProvider>
)
