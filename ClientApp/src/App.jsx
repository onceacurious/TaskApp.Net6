import {useEffect} from "react";
import TaskList from "./components/TaskList";

const App = () => {
    const getAllTasks = async () => {
        try {
            const response = await fetch('http://localhost:5057/api/tasks', {method: 'GET'});
            if (!response.ok) throw new Error(`HTTP error: ${response.status}`);
            const data = await response.json();
            console.log("Tasks:", data);
        } catch (err) {
            console.error("Error fetching tasks:", err);
        }
    };


    useEffect(() => {

        getAllTasks();
    }, []);


    return (
        <>
            <h4>Hello to Task App</h4>
            <TaskList/>
        </>
    )
}

export default App;