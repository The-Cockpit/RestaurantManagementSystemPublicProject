import { useEffect, useRef, useState } from 'react';
import { DragAndDrop, Resize, Inject, PopupOpenEventArgs, ViewDirective, ViewsDirective, ScheduleComponent, Week, NavigatingEventArgs } from "@syncfusion/ej2-react-schedule";
import useStore from '../store';
import './scheduler.css';
import EventTemplate from './EventTemplate';
import EditorEventTemplate from './EditorEventTemplate';
import {L10n} from '@syncfusion/ej2-base'

L10n.load({
  'en-US':{
    'schedule':{
      'saveButton':'שמור',
      'cancelButton':'סגור',
      'deleteButton':'מחק',
      'deleteEventButton':'מחק',
      'newEvent':'הוסף משמרת',
      'editEvent':'ערוך משמרת',
      'deleteEvent':'מחק משמרת',
      'day': 'יום',
      'week': 'שבוע',
      'workWeek': 'שבוע עבודה',
      'month': 'חודש',
      'agenda': 'אג׳נדה',
      'today': 'היום',
      'noEvents': 'אין אירועים',
      'emptyContainer': 'אין אירועים ביום זה.',
      'allDay': 'כל היום',
      'start': 'התחלה',
      'end': 'סיום',
      'more': 'עוד',
      'close': 'סגור',
      'cancel': 'ביטול',
      'noTitle': '(ללא כותרת)',
      'delete': 'מחק',
      'deleteMultipleEvent': 'מחק מספר אירועים',
      'selectedItems': 'פריטים נבחרים',
      'deleteSeries': 'מחק את הסדרה',
      'edit': 'ערוך',
      'editSeries': 'ערוך את הסדרה',
      'createEvent': 'צור',
      'subject': 'נושא',
      'addTitle':'בחר עובד',
      'moreDetails': 'פרטים נוספים',
      'save': 'שמור',
      'editContent': 'ערוך את תוכן האירוע',
      'deleteContent': ' האם אתה בטוח שברצונך למחוק משמרת זו',
      'deleteMultipleContent': 'האם אתה בטוח שברצונך למחוק את האירועים הנבחרים?',
      'title': 'כותרת',
      'location': 'מיקום',
      'description': 'תיאור',
      'timezone': 'אזור זמן',
      'startTimezone': 'אזור זמן התחלה',
      'endTimezone': 'אזור זמן סיום',
      'repeat': 'חזור',
      'recurrence': 'חזרה',
      'wrongPattern': 'תבנית החזרה לא תקינה',
      'seriesChangeAlert': 'השינויים שבוצעו במופעים הספציפיים של סדרת חזרות זו יבוטלו והשינויים הללו יחולו שוב על כל הסדרה.',
      'createError': 'משך האירוע חייב להיות קצר יותר מתדירות החזרה. קיצור משך האירוע או שינוי תבנית החזרה באשף האירועים החוזרים.',
      'recurrenceDateValidation': 'בחירת תאריך מסוימת אינה תקפה לאירועים חוזרים. הדילוג על תאריך זה.',
      'sameDayAlert': 'שני מופעים או יותר של אותו אירוע התרחשו באותו יום.',
      'editRecurrence': 'ערוך חזרה',
      'repeats': 'חוזר',
      'alert': 'התראה',
      'startEndError': 'תאריך הסיום שנבחר מתרחש לפני תאריך ההתחלה.',
      'invalidDateError': 'הערך התאריך שהוזן אינו תקף.',
      'blockAlert': 'אירועים אינם מורשים להוסיף לטווח הזמן החסום.',
      'ok': 'אישור',
      'occurrence': 'התרחשות',
      'series': 'סדרה',
      'previous': 'קודם',
      'next': 'הבא',
    }
  }
})

const Schedule = () => {
  const {schedulerRefernce, setSchedulerRefernce, isManager, isClosed, shifts,sideBarState, fetchEmployeeShifts, setWeekStatus, weekStatus} = useStore();
  const scheduleRef = useRef<ScheduleComponent>(null);
  const [isFinish, setIsFinish] = useState(false);

  const checkWeekStatus = (date: Date): string => {
    const dayIndex = date.getDay();
    const startDate = new Date(date);
    startDate.setDate(startDate.getDate() - dayIndex);
    const endDate = new Date(startDate);
    endDate.setDate(startDate.getDate() + 6);

    const today = new Date();
    today.setHours(0, 0, 0, 0);

    const currentWeekStart = new Date(today);
    currentWeekStart.setDate(today.getDate() - today.getDay());
    const currentWeekEnd = new Date(currentWeekStart);
    currentWeekEnd.setDate(currentWeekStart.getDate() + 6);

    const previousWeekStart = new Date(currentWeekStart);
    previousWeekStart.setDate(currentWeekStart.getDate() - 7);
    const previousWeekEnd = new Date(currentWeekEnd);
    previousWeekEnd.setDate(currentWeekEnd.getDate() - 7);

    const nextWeekStart = new Date(currentWeekStart);
    nextWeekStart.setDate(currentWeekStart.getDate() + 7);
    const nextWeekEnd = new Date(currentWeekEnd);
    nextWeekEnd.setDate(currentWeekEnd.getDate() + 7);

    startDate.setHours(0, 0, 0, 0);
    endDate.setHours(0, 0, 0, 0);

    if (startDate >= currentWeekStart && endDate <= currentWeekEnd) {
      return 'current';
    } else if (startDate >= nextWeekStart && endDate <= nextWeekEnd) {
      return 'next';
    } else if (startDate >= previousWeekStart && endDate <= previousWeekEnd) {
      return 'previous';
    } else {
      return 'future';
    }
  };

  const onEventRendered = (args: any) => {
    const element = args.element;
    element.style.background = "none";
    element.style.border = "none";
  };

  const onNavigating = (args: NavigatingEventArgs) => {
      const weekStatus = args.currentDate ? checkWeekStatus(args.currentDate) : '';
      setWeekStatus(weekStatus);
  };
  
  useEffect(() => {
    !isManager && fetchEmployeeShifts();
    setIsFinish(true);
  }, []);
  
  useEffect(() => {
    if (scheduleRef.current) {
      if (isManager && isClosed && weekStatus === 'next' && sideBarState === 'edited') {
        scheduleRef.current.readonly = false;
        scheduleRef.current.refresh();
      }
      else{
        scheduleRef.current.readonly = true;
        scheduleRef.current.refresh();
      }
    }
  }, [weekStatus,sideBarState,schedulerRefernce,isManager]);
  
  const onPopupOpen = (args: PopupOpenEventArgs) => {
    console.log(args.type)
    args.cancel = !(isManager && weekStatus === 'next' && isClosed && sideBarState === 'edited');//true
    if(args.type === 'QuickInfo' || args.type === 'ViewEventInfo') args.cancel = true
  };

  useEffect(() => {
    if (isFinish && scheduleRef.current) {
      setSchedulerRefernce(scheduleRef.current);
      scheduleRef.current.navigating = onNavigating;
    }
  }, [isFinish]);

  function nextweek() {
    var today = new Date();
    var nextweek = new Date(today.getFullYear(), today.getMonth(), today.getDate() + 7);
    return nextweek;
  }

  return (
    <>
      {isFinish ? (
        <ScheduleComponent
          width={'100%'}
          height={'78vh'}
          ref={scheduleRef}
         // readonly={!isManager}
          popupOpen={onPopupOpen}
          startHour='07:00'
          eventRendered={onEventRendered}
          selectedDate={nextweek()}
          editorTemplate={EditorEventTemplate}
          eventSettings={{ dataSource: shifts, template: EventTemplate
      }}>
            
          <ViewsDirective>
            <ViewDirective option="Week" />
          </ViewsDirective>
          <Inject services={[Week, DragAndDrop, Resize]} />
        </ScheduleComponent>
      ) : (
        <div className='loading'>
          Loading
        </div>
      )}
    </>
  );
};

export default Schedule;
