import React, { useState, useEffect } from 'react';
import { DropDownListComponent } from "@syncfusion/ej2-react-dropdowns";
import { DateTimePickerComponent } from "@syncfusion/ej2-react-calendars";
import useStore from "../store";
import './EditorEventTemplate.css';

interface EditorEventTemplateProps {
    Description: string;
    StartTime: Date;
    EndTime: Date;
    IsTicked: boolean;
    [key: string]: any;
}

interface Employee {
    EmployeeId: string;
    FirstName: string;
    LastName: string;
    EmployeeType: number;
}

const EditorEventTemplate: React.FC<EditorEventTemplateProps> = (props) => {
    const { listOfemployees, shiftTamplates } = useStore();
    const [selectedShift, setSelectedShift] = useState<string>("");
    const [employee, setEmployee] = useState<Employee | null>(null);
    const [TStartTime, setTStartTime] = useState<Date>(new Date(props.StartTime));
    const [TEndTime, setTEndTime] = useState<Date>(new Date(props.EndTime));

    useEffect(() => {
        if (selectedShift) {
            const selectedShiftInfo = shiftTamplates.find(shift => shift.Name === selectedShift);
            if (selectedShiftInfo) {
                const startTime = new Date(props.StartTime);
                startTime.setHours(selectedShiftInfo.StartHour, selectedShiftInfo.StartMin);
                const endTime = new Date(props.EndTime);
                endTime.setHours(selectedShiftInfo.EndHour, selectedShiftInfo.EndMin);
                setTStartTime(startTime);
                setTEndTime(endTime);
            }
        }
    }, [selectedShift, props.StartTime, props.EndTime, shiftTamplates]);
 
    const handleShiftChange = (e: any) => {
        e.itemData && setSelectedShift(e.itemData.value);
    };

    const handleEmployeeChange = (e: any) => {
        const selectedEmployeeFullName = e.itemData.value;
        const emp = listOfemployees.find(employee => selectedEmployeeFullName.startsWith(employee.FirstName) && selectedEmployeeFullName.endsWith(employee.LastName));
        setEmployee(emp || null);
    };
    return (
        <div>
            <DropDownListComponent
                id="EmployeeName"
                data-name="Subject"
                className="e-field"
                dataSource={listOfemployees?.map(emp => (`${emp.FirstName} ${emp.LastName}`))}
                placeholder="בחר עובד"
                change={handleEmployeeChange}
                value={props.Subject?props.Subject:""}
                text={props.Subject?props.Subject:""}
            />
            <input
                type="hidden"
                id="EmployeeId"
                data-name="EmployeeId"
                className="e-field"
                value={employee?.EmployeeId || ""}
            />
            <input
                type="hidden"
                id="Type"
                data-name="Type"
                className="e-field"
                value={employee?.EmployeeType || ""}
            />
            <DropDownListComponent
                id="Shift"
                className="e-field"
                dataSource={shiftTamplates.map(shift => shift.Name)}
                placeholder="בחר משמרת"
                value={selectedShift || ""}
                change={handleShiftChange}
            />
            <DateTimePickerComponent
                id="StartTime"
                data-name="StartTime"
                value={TStartTime}
                format="dd/MM hh:mm a"
                className="e-field"
            />
            <DateTimePickerComponent
                id="EndTime"
                data-name="EndTime"
                value={TEndTime}
                format="dd/MM hh:mm a"
                className="e-field"
            />
            <textarea
                id="Description"
                className="e-field e-input"
                name="Description"
                rows={3}
                cols={50}
                defaultValue={props.Description}
            />
        </div>
    );
};

export default EditorEventTemplate;
