import { create, StateCreator } from 'zustand';
/* import { persist, PersistOptions } from 'zustand/middleware';
import { createJSONStorage } from 'zustand/middleware';
 */

interface Employee {
  EmployeeId: string,
  FirstName: string,
  LastName: string,
  EmployeeType: number

}
interface User {
  EmployeeId: string,
  FirstName: string,
  LastName: string,
  EmployeeType: number //type in enum
  EmployeeManagerOn: boolean //TODO: chang to enum //number //type in enum
}


interface StoreState {
  user: User
  employeeTypeState: number;
  employeeTypes: object;
  isManager: boolean;
  shifts: Array<any>;
  weekStatus: string;
  selectedShifts: Array<number>;
  isClosed: boolean;
  sideBarState: string;
  baseUrl: string;
  schedulerRefernce: any;
  weekName: string;
  listOfemployees: Array<Employee>
  shiftTamplates: Array<any>
}

interface Event {
  Id: number;
  Subject: string;
  Description: string | null;
  StartTime: string;
  EndTime: string;
  Type: number | string;
  EmployeeId: string | null;
}


interface StoreActions {
  fetchEmployees: () => void;
  moveToManagerState: () => void;
  moveToEmployeeState: () => void;
  fetchEmployeeShifts: () => void;
  fetchEditedShifts: () => void;
  fetchEmployeesSubmittedShifts: () => void;
  setWeekStatus: (newValue: string) => void;
  selectedShiftsAdd: (id: number) => void;
  selectedShiftsRemove: (id: number) => void;
  selectedShiftsInclude: (id: number) => boolean;
  submitShifts: () => void;
  setSideBarState: (newValue: string) => void;
  setSchedulerRefernce: (ref: any) => void;
  saveEditedShifts: () => void;
  fetchShiftSelectionTemplate: () => void;
  deleteShiftSelectionTemlpate: (id: number) => void;
  addSelctionTemplateShift: (name: string, time: any) => void;
  sendTokenToApi: (tokenId: string) => void;
  changeEmployeeTypes: (id: string, newType: number) => void;
  setEmployeeTypeState: (type: number) => void;
  setStateLogOut: () => void;
}

/*
type PersistedState = StoreState & StoreActions;
 type MyPersist = (
  config: StateCreator<PersistedState>,
  options: PersistOptions<PersistedState>
) => StateCreator<PersistedState>; */

const useStore = create<StoreState & StoreActions>(
  /* (persist as MyPersist)( */
  (set, get) => ({

    //props
    user: {
      EmployeeId: "0",
      FirstName: "",
      LastName: "",
      EmployeeType: 2, //type of the employee  in enum
      EmployeeManagerOn: false //TODO: chang to enum //type of what types the employee manage on in enum(simple employee = 0)
    },
    employeeTypeState: 2,
    weekName: 'הבא',
    listOfemployees: [],
    shifts: [],
    selectedShifts: [],
    employeeTypes: {
      'Cook': 1,
      'Waiter': 2,
      'Bartender': 4,
      'Hostess': 8,
      'ShiftManager': 16
    },
    shiftTamplates: [],
    weekStatus: 'next',
    employeeType: "2",
    employeeId: "2",
    sideBarState: "",
    schedulerRefernce: null,
    baseUrl: "https://localhost:7075/api",
    isManager: false,
    isClosed: true,

    //selected shift action
    selectedShiftsAdd: (shiftid: number) => set(state => ({ selectedShifts: [...state.selectedShifts, shiftid] })),
    selectedShiftsRemove: (id: number) => set(state => ({ selectedShifts: state.selectedShifts.filter(num => id !== num) })),
    selectedShiftsInclude: (id: number) => get().selectedShifts.includes(id),

    //set
    setWeekStatus: (newValue: string) => {
      let week: string = '';
      switch (newValue) {
        case 'current':
          week = 'הנוכחי'
          break;
        case 'next':
          week = 'הבא'
          break;
        case 'previous':
          week = 'הקודם'
          break;
        default:
          break;
      }
      set(state => ({ ...state, weekStatus: newValue, weekName: week }))
    },
    setSideBarState: (newValue) => {
      set((state) => {
        switch (newValue) {
          case 'submitted':
            get().fetchEmployeesSubmittedShifts()
            break;
          case 'edited':
            get().fetchEditedShifts()
            break
          case 'configuration':
            return { ...state, shifts: [], sideBarState: newValue };
          default:
            break
        }
        return { ...state, sideBarState: newValue };
      })
    },
    setSchedulerRefernce: (ref: any) => set(state => ({ ...state, schedulerRefernce: ref })),
    setEmployeeTypeState: (type: number) => set(state => ({ user: get().user, employeeTypeState: type })),
    setStateLogOut: () => (set({user: { EmployeeId: "0", EmployeeManagerOn: false, FirstName: "", LastName: "", EmployeeType: 2 }})
  ),

    //actions
    moveToManagerState: () => {
      if (get().user.EmployeeManagerOn) {
        set((state) => ({ ...state, isManager: true }));
        get().setSideBarState('submitted');
        get().fetchEmployees()
        get().fetchShiftSelectionTemplate()
        console.table(get().shiftTamplates)
      }
    },
    moveToEmployeeState: () => {
      set((state) => ({ ...state, isManager: false }));
      get().fetchEmployeeShifts();
    },

    //put
    saveEditedShifts: () => {
      const schedulerReference = get().schedulerRefernce;
      const eventsData = schedulerReference ? schedulerReference.eventsData : [];

      const toLocalISOString = (date: Date) => {
        // Adjust the date to the local time zone
        const localDate = new Date(date.getTime() - date.getTimezoneOffset() * 60000);
        // Format the date as an ISO string without the time zone
        const isoString = localDate.toISOString().slice(0, 19);
        return isoString;
      };

      // Convert dates to ISO strings and ensure correct structure
      const formattedEventsData = eventsData.map((event: Event) => ({
        Id: event.Id,
        Subject: event.Subject,
        Description: event.Description,
        StartTime: toLocalISOString(new Date(event.StartTime)),
        EndTime: toLocalISOString(new Date(event.EndTime)),
        Type: typeof event.Type === "string" ? parseInt(event.Type) : event.Type,
        EmployeeId: event.EmployeeId
      }));

      // Construct the request body with the expected structure
      const requestBody = {
        Shifts: formattedEventsData
      };
      fetch(`${get().baseUrl}/Shifts/Edited/2`, {
        method: 'PUT',
        headers: {
          'Accept': '*/*',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestBody)
      })
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to update data');
          }
          return response.status;
        })
        .then(data => {
          console.log('Response:', data);
        })
        .then(() => get().fetchEditedShifts())
        .catch(error => {
          console.error('Error:', error);
        });
    },
    submitShifts: async () => {
      const requestBody = {
        EmployeeID: get().user.EmployeeId,
        ShiftIds: [...get().selectedShifts]
      };
      console.log("on put: " + get().selectedShifts)
      fetch(`${get().baseUrl}/Shifts`, {
        method: 'PUT',
        headers: {
          'Accept': '*/*',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestBody)
      })
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to update data');
          }
          return response.status;
        })
        .then(data => {
          console.log('Response:', data)
        })
        .then(data => (get().fetchEmployeeShifts()))
        .catch(error => {
          console.error('Error:', error);
        });
    },
    changeEmployeeTypes: async (id: string, newType: number) => {
      const requestBody = newType;
      console.log("on put: " + get().selectedShifts)
      fetch(`${get().baseUrl}/Managers/UpdateEmployeeType/${id}`, {
        method: 'PUT',
        headers: {
          'Accept': '*/*',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestBody)
      })
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to change type');
          }
          return response.status;
        })
        .then(data => {
          console.log('Response:', data)
        })
        .then(data => (get().fetchEmployees()))
        .catch(error => {
          console.error('Error:', error);
        });
    },
    sendTokenToApi: async (tokenId: string) => {
      try {
        const response = await fetch(`${get().baseUrl}/Account/user/${tokenId}`, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify({ tokenId })
        });
        const data = await response.json();
        console.log("data", data);

        set({
          user: data
        });
        console.log("user: ", get().user);

        if (!response.ok) {
          throw new Error('Failed to send token');
        }
      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },

    addSelctionTemplateShift: async (name: string, time: { sTime: { hours: number, minutes: number }, eTime: { hours: number, minutes: number } }) => {
      const requestBody = {
        "Id": 0,
        "Name": name,
        "StartHour": time.sTime.hours,
        "StartMin": time.sTime.minutes,
        "EndHour": time.eTime.hours,
        "EndMin": time.eTime.minutes
      };
      fetch(`${get().baseUrl}/Managers/ShiftSelectionTemplate`, {
        method: 'POST',
        headers: {
          'Accept': '*/*',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestBody)
      })
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to update data');
          }
          return response.status;
        })
        .then(data => {
          console.log('Response:', data)
        })
        .then(data => (get().fetchShiftSelectionTemplate()))
        .catch(error => {
          console.error('Error:', error);
        });
    },


    //get
    fetchEmployeesSubmittedShifts: async () => {
      try {
        const response = await fetch(`${get().baseUrl}/Shifts/Submitted/${get().employeeTypeState}`);
        if (!response.ok) {
          throw new Error('Failed to fetch shifts');
        }
        const data = await response.json();
        set((state) => ({
          ...state,
          shifts: [...data],
        }));

      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },
    fetchShiftSelectionTemplate: async () => {
      try {
        const response = await fetch(`${get().baseUrl}/Managers/ShiftSelectionTemplate`);
        if (!response.ok) {
          throw new Error('Failed to fetch template shifts');
        }
        const data = await response.json();
        set((state) => ({
          ...state,
          shiftTamplates: [...data],
        }));

      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },
    fetchEditedShifts: async () => {
      try {
        const response = await fetch(`${get().baseUrl}/Shifts/Edited/${get().user.EmployeeId}/${get().employeeTypeState}`);
        if (!response.ok) {
          throw new Error('Failed to fetch shifts');
        }
        const data = await response.json();
        console.log("weekstate", data.WeekState)
        set((state) => ({
          ...state,
          shifts: [...data.Shifts],
          isClosed: data.WeekState === 1,
        }));
        get().schedulerRefernce.refresh()

      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },
    fetchEmployees: async () => {
      try {
        const response = await fetch(`${get().baseUrl}/Managers/GetEmployees`);
        if (!response.ok) {
          throw new Error('Failed to fetch shifts');
        }
        const data = await response.json();
        set((state) => ({
          ...state,
          listOfemployees: [...data]
        }));

      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },
    fetchEmployeeShifts: async () => {
      try {
        //set((state) => ({ ...state,shifts:[], selectedShifts: [] }))
        //get().schedulerRefernce.refresh()
        const response = await fetch(`${get().baseUrl}/Shifts/Employee/${get().user.EmployeeId}/${get().employeeTypeState}`, {
          method: 'GET',
          headers: {
            'Content-Type': 'application/json',
          },
        })
        if (!response.ok) {
          throw new Error('Failed to fetch shifts');
        }
        const data = await response.json();
        data.Shifts.map((shift: any) => (shift.IsTicked ? get().selectedShiftsAdd(shift.Id) : null));
        console.log(data.Shifts)
        console.log("isclo  ", data.IsFinalized)
        set((state) => ({
          ...state,
          shifts: data.Shifts,
          isClosed: data.IsFinalized
        }));
        get().schedulerRefernce.refresh()

      } catch (error) {
        console.error('Error fetching Shifts:', error);
      }
    },

    //delete
    deleteShiftSelectionTemlpate: async (IdToDelete: number) => {
      fetch(`${get().baseUrl}/Managers/ShiftSelectionTemplate?templateId=${IdToDelete}`, {
        method: 'DELETE',
        headers: {
          'Accept': '*/*',
        },
      })
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to update data');
          }
          return response.status;
        })
        .then(data => {
          console.log('Response:', data)
        })
        .then(data => (get().fetchShiftSelectionTemplate()))
        .catch(error => {
          console.error('Error:', error);
        });
    },

  }),
  /* {
    name: 'store', // name of the item in the storage (must be unique)
    storage: createJSONStorage(() => localStorage),
    partialize: (state) => Object.fromEntries(
      Object.entries(state).filter(([key]) => !['schedulerRefernce'].includes(key))
    ),
  } 
)
*/

);


export default useStore