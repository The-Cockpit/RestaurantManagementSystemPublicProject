import Schedule from './scheduler.tsx'
import './AplicationStartup.css'
import NavBar from './navbar.tsx'
import Footer from './footer.tsx'
import useStore from '../store.ts'
import SideBar from './SideBar.tsx'
import {useEffect, useState } from 'react'
import Configuration from './Configuration.tsx'

function AplicationStartup() {
  const { isManager,sideBarState } = useStore();
  const [isSidebarExpend, setisSidebarExpend] = useState(false)
useEffect(()=>{setisSidebarExpend(isSidebarExpend)},[sideBarState])
  return (
    <>
      <div className='AplicationStartup'>
        <div className='dummy-navbar'></div>
        <div className='content-conteiner'>
          <div className={`content ${isManager ? 'shrink' : ''} `}>
          {sideBarState === 'configuration'? <Configuration/>:<Schedule/>}
          </div>
          <div className={`sidebar ${isManager ? 'open' : ''} ${isSidebarExpend ? 'expanded' : ''}`}
            onMouseEnter={() => setisSidebarExpend(true)}
            onMouseLeave={() => setisSidebarExpend(false)}
            ><SideBar />
          </div>
        </div>
        <NavBar/>
        <Footer />
      </div>
    </>
  )
}

export default AplicationStartup
