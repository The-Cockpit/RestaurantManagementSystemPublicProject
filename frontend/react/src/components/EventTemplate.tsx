import React from 'react';
import './EventTemplate.css'
import useStore from '../store';
import '@fortawesome/fontawesome-free/css/all.min.css'; // Ensure FontAwesome is imported
import CheckIcon from '../assets/check.svg';


interface EventTemplateProps {
    Description: string;
    StartTime: Date;
    EndTime: Date;
    IsTicked: boolean;
    [key: string]: any;
}


const formatTime = (date: Date): string => {
    const hours = date.getHours();
    const minutes = date.getMinutes()
    return `${hours < 10 && hours > 0  ? '0' : ''}${hours}${minutes < 10 && minutes > 0  ? '0' : ''}${minutes === 0 ? '' : ':'+minutes}`;
};



const EventTemplate: React.FC<EventTemplateProps> = (props) => {
    const {isManager, weekStatus, isClosed, selectedShiftsAdd, selectedShiftsRemove, selectedShiftsInclude} = useStore();

    const color1: string = '#5C8374'
    const color2: string = '#9EC8B9'
    const startTime: Date = new Date(props.StartTime);
    const endTime: Date = new Date(props.EndTime);
    const termToColor2: boolean = selectedShiftsInclude(props.Id) && weekStatus === 'next' && !isManager
    const color: string = termToColor2 ? color1 : color2;
    
    const handleClick = (event: React.MouseEvent<HTMLDivElement, MouseEvent>, props: EventTemplateProps): void => {
        if (weekStatus === 'next' && !isClosed && !isManager) {
            const shiftId = props.Id;
            if (selectedShiftsInclude(shiftId)) {
                selectedShiftsRemove(shiftId);
            } else {
                selectedShiftsAdd(shiftId);
            }
            event.currentTarget.style.background = selectedShiftsInclude(shiftId) ? color1 : color2;
            event.currentTarget.style.border = selectedShiftsInclude(shiftId) ? `5px solid ${color2}` : `5px solid ${color1}`;  
        }

    };
    const handlePopup = () => {

    }

    return (
        <div className='template-wrap' onClick={(event) => handleClick(event, props)} style={{ background: color, border: termToColor2 ? `5px solid ${color2}` : `5px solid ${color1}`}}>
            <div className='name'>{props.Subject}</div>
            <div className='time'>
                {formatTime(startTime)} - {formatTime(endTime)}
            </div>
           { termToColor2 && <img className='CheckIcon' src={CheckIcon} alt="" /> } 
          <div className='comment' onClick={handlePopup} >{props.Description}</div>
          {/* <div className='comment' onClick={handlePopup} >{props.Id}</div> */}
        </div>
    );
};

export default EventTemplate;

