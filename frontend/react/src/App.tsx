// src/App.js
import { useEffect, useState } from 'react';
import GoogleLoginButton from './components/GoogleLoginButton';
import AplicationStartup from './components/AplicationStartup';
import useStore from './store';
import './App.css'
import logo from './assets/logo.png'


const App = () => {
  const { sendTokenToApi, user} = useStore()
  const [ready, setReady] = useState(false)

  useEffect(() => {
    user.EmployeeId !== "0" ? setReady(true): setReady(false)
  }, [user])

  const handleLoginSuccess = (idToken: any) => {
    localStorage.setItem('googleIdToken', idToken);
    sendTokenToApi(idToken)
  };

  return (
    <div className='app'>
      {!ready ?
        (<div className='google-login'>
          <img src={logo} alt="" />
          <h1>כנס עם גוגל</h1>
          <GoogleLoginButton onLoginSuccess={handleLoginSuccess} />
        </div>)
        : (<AplicationStartup />)}
    </div>
  );
};

export default App;