import './footer.css'
import useStore from '../store'
import CostumButton from './Costumbutton.tsx'


export default function Footer() {
    const { submitShifts, saveEditedShifts, weekName, isManager,sideBarState,weekStatus,isClosed } = useStore();
    return (
        <>
            <div className="footer-container">
                <div className="footer-wrapper">
                    {!isManager && weekStatus === "next" && !isClosed && <CostumButton initialContent={'שלח'} action={submitShifts} text={'submit'} />}
                    {sideBarState === 'edited' && <CostumButton initialContent={'שמור'} action={saveEditedShifts} text={'save'} />}
                    {//sideBarState === 'edited' && <CostumButton initialContent={'סגור סידור'} action={submitFinalEditedShifts} text={'save'} /> // TODO: submit final shifts
                    }
                    <h1><a className="effect-shine">השבוע {weekName}</a></h1>
                </div>
            </div>

        </>
    );
}



