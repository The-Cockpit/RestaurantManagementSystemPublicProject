import useStore from '../store';
import './Configuration.css';
import CostumButton from './Costumbutton';
import { DropDownListComponent } from '@syncfusion/ej2-react-dropdowns';
import { MultiSelectComponent } from '@syncfusion/ej2-react-dropdowns';
import { useState } from 'react';

function generateTimeIntervals(start: string, end: string, interval: number) {
    const times = [];
    let currentTime = new Date(`1970-01-01T${start}:00`);
    const endTime = new Date(`1970-01-01T${end}:00`);

    while (currentTime <= endTime) {
        const hours = currentTime.getHours();
        const minutes = currentTime.getMinutes();
        times.push({ hours: hours, minutes: minutes });
        currentTime.setMinutes(currentTime.getMinutes() + interval);
    }

    return times;
}

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

export default function Configuration() {
    const {changeEmployeeTypes, submitShifts, shiftTamplates, listOfemployees, employeeTypes,deleteShiftSelectionTemlpate,addSelctionTemplateShift } = useStore();
    const timeIntervals = generateTimeIntervals('07:00', '24:00', 15);
    const employeeTypesList = Object.keys(employeeTypes).map(key => ({ text: key, value: employeeTypes[key] }));
    const [employee, setEmployee] = useState<{ EmployeeId: string, FirstName: string, LastName: string, EmployeeType: number } | null>(null);
    const [employeeListOfTypes, setEmployeeListOfTypes] = useState([]);
    const [shiftTamplateName, setshiftTamplateName] = useState<string | null>(null);
    const [shiftIdToDelete, setShiftIdToDelete] = useState<number|null>(null);
    const [time, setTime] = useState<{ sTime: { hours: number, minutes: number } | null, eTime: { hours: number, minutes: number } | null }>({ sTime: null, eTime: null });

    const employeeChangedHandle = (e: any) => {
        const selectedEmployee = listOfemployees.find(emp => emp.EmployeeId === e.value);
        selectedEmployee && setEmployee(selectedEmployee);
    }

    const typesChangedHandle = (e: any) => {
        setEmployeeListOfTypes(e.value);
    }
    const handleSiftToDeleteChanged = (e: any)=>{
        e.value && setShiftIdToDelete(e.value)
    }

    const changeStartTimeHandle = (e: any) => {
        const splitArray = e.value.split(":");
        setTime(prevTime => ({ ...prevTime, sTime: { hours: splitArray[0], minutes: splitArray[1] } }));
    }
    const changeInputShiftTemplateHandle = (e: any) => {
        const str: string = e.target.value
        str.length > 3 && setshiftTamplateName(str)
    }
    const changeEndTimeHandle = (e: any) => {
        const splitArray = e.value.split(":");
        setTime(prevTime => ({ ...prevTime, eTime: { hours: splitArray[0], minutes: splitArray[1] } }));
    }
    return (
        <div className='configuration'>
            <div className='row'>
                <CostumButton initialContent={'מחק'} action={()=> shiftIdToDelete && deleteShiftSelectionTemlpate(shiftIdToDelete)} text={'submit'} />
                <DropDownListComponent
                    fields={{ text: 'text', value: 'value' }}
                    dataSource={shiftTamplates.length > 0 ? shiftTamplates.map(st => ({text:st.Name, value:st.Id})) : []}
                    text={shiftIdToDelete ? shiftTamplates.find(st=>(st.Id === shiftIdToDelete)):""}
                    value={shiftIdToDelete}
                    change={handleSiftToDeleteChanged}
                    placeholder='בחר משמרת'
                    width={'15vw'} />
                <h3>מחק משמרת קיימת</h3>
            </div>
            <div className='line'/>
            <div className='row'>
                <CostumButton initialContent={'הוסף'} action={()=>(shiftTamplateName && addSelctionTemplateShift(shiftTamplateName,time))} text={'submit'} />
                <input type='text' placeholder='שם משמרת' onChange={changeInputShiftTemplateHandle} />
                <DropDownListComponent
                    id='end'
                    fields={{ text: 'text', value: 'value' }}
                    dataSource={timeIntervals.map(time => ({ text: `${time.hours.toString().padStart(2, '0')}:${time.minutes.toString().padStart(2, '0')}`, value: `${time.hours}:${time.minutes}` }))}
                    placeholder='סיום'
                    change={changeEndTimeHandle}
                    text={time.eTime ? `${time.eTime.hours.toString().padStart(2, '0')}:${time.eTime.minutes.toString().padStart(2, '0')}` : ''}
                    value={time.eTime ? time.eTime.toString() : null}
                    width={'10vw'} />
                <DropDownListComponent
                    id='start'
                    fields={{ text: 'text', value: 'value' }}
                    dataSource={timeIntervals.map(time => ({ text: `${time.hours.toString().padStart(2, '0')}:${time.minutes.toString().padStart(2, '0')}`, value: `${time.hours}:${time.minutes}` }))}
                    placeholder='התחלה'
                    change={changeStartTimeHandle}
                    text={time.sTime ? `${time.sTime.hours.toString().padStart(2, '0')}:${time.sTime.minutes.toString().padStart(2, '0')}` : ''}
                    value={time.eTime ? time.eTime.toString() : null}
                    width={'10vw'} />
                <h3>הוסף משמרת חדשה</h3>
            </div>
            <div className='line' />
            <div className='row'>
                <CostumButton initialContent={'שנה'} action={()=>employee && changeEmployeeTypes(employee?.EmployeeId,employeeListOfTypes.reduce((partialSum, a) => partialSum + a, 0))} text={'submit'} />
                <MultiSelectComponent
                    dataSource={employeeTypesList}
                    placeholder='תפקיד'
                    fields={{ text: 'text', value: 'value' }}
                    value={employee ? getListOfTypes(employee.EmployeeType, Object.keys(employeeTypes).length) : null}
                    change={typesChangedHandle}
                    width={'12vw'} />
                <DropDownListComponent
                    fields={{ text: 'text', value: 'value' }}
                    dataSource={listOfemployees.map(emp => ({ text: `${emp.FirstName} ${emp.LastName}`, value: emp.EmployeeId }))}
                    placeholder='עובד'
                    change={employeeChangedHandle}
                    value={employee?.EmployeeId}
                    text={employee ? `${employee.FirstName} ${employee.LastName}` : ''}
                    width={'12vw'} />
                <h3>שנה סטטוס עובד</h3>
            </div>
            <div className='line' />
        </div>
    );
}