import { GoogleLogin } from '@react-oauth/google';

const GoogleLoginButton = ({ onLoginSuccess }:any) => {
  const handleLoginSuccess = (response:any) => {
    const idToken = response.credential;
    onLoginSuccess(idToken);
  };
  
  const handleLoginFailure = (error:any) => {
    console.error('Login failed:', error);
  };
 
  //ijin
  return (
    <GoogleLogin
      onSuccess={handleLoginSuccess}
      onError={handleLoginFailure}
    />
  );
};

export default GoogleLoginButton;
