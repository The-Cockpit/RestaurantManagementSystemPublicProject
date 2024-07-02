import './navbar.css'
import logo from '../assets/logo.png'
import manger from '../assets/manager.svg'
import useStore from '../store'
import { useState } from 'react';

function getListOfTypes(type: number, numberOfTypes: number) {
    const types = [];
    for (let index = numberOfTypes; index >= 0; index--) {
        const pow = Math.pow(2, index);
        if (type >= pow) {
            types.push(pow);
            type -= pow;
        }
    }
    return types;
}

export default function NavBar() {
    const[logout,setLogout]= useState(false)
    const {setStateLogOut,isManager, moveToManagerState, moveToEmployeeState,setEmployeeTypeState,user,employeeTypeState } = useStore();
    const managgerclicked = () => {
        if (isManager)
            moveToEmployeeState();
        else moveToManagerState();
    }
    let listOfTypes = isManager ? getListOfTypes(user.EmployeeType,5): getListOfTypes(user.EmployeeType,5)//TODO: change employeetype to employeetypeon
    return (<>
        <div className="navbar-container">
            <div className="navbar-wrapper">
                <a className='img-conteiner effect-shine' href="#"><img src={logo} alt=""/></a>
                <div className='relative'>
                <a onClick={()=>setLogout(!logout)} className="effect-shine nav-link hello">Hello {user.FirstName} <span className={`caret ${logout?'open':''}`}></span></a>
                {logout && <div onClick={setStateLogOut} className='logout'>התנתק</div>}
                </div>
                {listOfTypes.includes(8) && <a onClick={()=>setEmployeeTypeState(8)} href="#" className={`${employeeTypeState === 8 ? 'selected-nav':''} nav-link nav-link-fade-up`}>אירוח</a>}
                {listOfTypes.includes(16) && <a onClick={()=>setEmployeeTypeState(16)} href="#" className={`${employeeTypeState === 16 ? 'selected-nav':''} nav-link nav-link-fade-up`}>אחמ"ש</a>}
                {listOfTypes.includes(2) && <a onClick={()=>setEmployeeTypeState(2)} href="#" className={`${employeeTypeState === 2 ? 'selected-nav':''} nav-link nav-link-fade-up`}>מלצרות</a>}
                {listOfTypes.includes(1) && <a onClick={()=>setEmployeeTypeState(1)} href="#" className={`${employeeTypeState === 1 ? 'selected-nav':''} nav-link nav-link-fade-up`}>מטבח</a>}
                {listOfTypes.includes(4) && <a onClick={()=>setEmployeeTypeState(4)} href="#" className={`${employeeTypeState === 4 ? 'selected-nav':''} nav-link nav-link-fade-up`}>בר</a>}
                {/* <h1><a className="effect-shine">{state}</a></h1> */}
                <a onClick={managgerclicked} className="effect-shine" href="#"><img src={manger} alt="" /></a>
            </div>
        </div>
    </>)
}