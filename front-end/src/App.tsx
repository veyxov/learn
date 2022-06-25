import { FC, useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';

function TodoInput({ setTodos }) {
    const [title, setTitle] = useState('');

    const handleSubmit = (e: any) => {
        e.preventDefault();
        axios.post(`http://localhost:5180/todo/${title}`);
        setTodos((prev) => [...prev, title]);
    }
    const handleChange = (e: any) => {
        setTitle(e.target.value);
    }

    return (
        <form onSubmit={handleSubmit}>
            <input onChange={handleChange} type="text" placeholder="Add todo" />
            <input type="submit" value="Add" />
        </form>
    );
}

interface ITodosContainer {
    todos: any[]
}

const TodosContainer: FC<ITodosContainer> = ({ todos }) => {
    return (
        <>
            {
                todos.length > 0 ?
                    todos.map((todo: any, index) => {
                        return (
                            <div key={index}>
                                <h1>{todo.title}</h1>
                                <h4>{todo.CreationDate}</h4>
                            </div>
                        )
                    })
                    :
                    <h1>No todos rn.</h1>
            }
        </>
    );
}

function App() {
    // image state
    const [todos, setTodos] = useState([]);

    // Get random image
    const getTodos = async () => {
        const response = await fetch('http://localhost:5180/todo');
        const todos = await response.json();

        setTodos(todos);
    }

    useEffect(() => {
        getTodos();
    }, []);

    return (
        <>
            <TodoInput setTodos={setTodos} />
            <TodosContainer todos={todos} />
        </>
    );
}

export default App;
