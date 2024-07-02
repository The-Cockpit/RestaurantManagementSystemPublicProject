import useStore from '../store'
import './SideBar.css'
import { useEffect, useState } from 'react';

export default function SideBar() {
    const { setSideBarState,sideBarState } = useStore();
    const [selectedItem, setSelectedItem] = useState('submitted');

    const handleClick = (event: React.MouseEvent, str: string) => {
        setSideBarState(str);
    };
    useEffect(()=>{
       setSelectedItem(sideBarState);

    },[sideBarState])

    return (
        <div className="sidebar-inside-container">
            <div 
                onClick={(event) => handleClick(event, 'submitted')} 
                className={`sidebar-item ${selectedItem === 'submitted' ? 'selected' : ''}`}
            >
                <h2>הגשות השבוע</h2>
            </div>
            <div 
                onClick={(event) => handleClick(event, 'edited')} 
                className={`sidebar-item ${selectedItem === 'edited' ? 'selected' : ''}`}
            >
                <h2>סידור לשבוע</h2>
            </div>
            <div 
                onClick={(event) => handleClick(event, 'configuration')} 
                className={`sidebar-item ${selectedItem === 'configuration' ? 'selected' : ''}`}
            >
                <h2>ניהול</h2>
            </div>
       
        </div>
    );
}
