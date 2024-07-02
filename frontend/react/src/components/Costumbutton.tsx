import React, { useState, useCallback, useEffect } from "react";
import './CostumButton.css';
import '@fortawesome/fontawesome-free/css/all.min.css'; // Ensure FontAwesome is imported
interface CostumButtonProps{
    text:string;
    action:()=>void;
    initialContent:string;
}
const CostumButton:React.FC<CostumButtonProps> = ({action, initialContent }) =>{
    const [effect1, setEffect1] = useState(false);
    const [effect2, setEffect2] = useState(false);
    const [actionTriggered, setActionTriggered] = useState(false);

    const clear = useCallback(() => {
        setTimeout(() => {
            setEffect2(false);
        }, 1000);
    }, []);

    useEffect(() => {
        if (actionTriggered) {
            setEffect1(true);
            const effect1Timeout = setTimeout(() => {
                setEffect1(false);
                setEffect2(true);
                clear();
            }, 2000);

            const effect2Timeout = setTimeout(() => {
                setActionTriggered(false);
            }, 3000); // Ensures that the actionTriggered is reset after effect2 finishes

            return () => {
                clearTimeout(effect1Timeout);
                clearTimeout(effect2Timeout);
            };
        }
    }, [actionTriggered, clear]);

    const handleClick = () => {
        setActionTriggered(true);
        action();
    };

    return (
        <button
            className={`btn ${effect1 ? 'effect1' : ''} ${effect2 ? 'effect2' : ''}`}
            onClick={handleClick}
        >
            {!effect2 ? initialContent : null}
        </button>
    );
}
export default CostumButton
