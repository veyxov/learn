import { FC, useEffect, useState } from 'react';
import { Link } from "react-router-dom";
import './App.css';
import axios from 'axios';

interface ITodos {
    getTodos: any
}

const TodoInput: FC<ITodos> = ({ getTodos }) => {
    const [title, setTitle] = useState('');

    const handleSubmit = (e: any) => {
        e.preventDefault();
        axios.post(`http://localhost:5180/todo/${title}`);
        getTodos();
    }
    const handleChange = (e: any) => {
        setTitle(e.target.value);
    }

    return (
        <form className="flex flex-col" onSubmit={handleSubmit}>
            <input onChange={handleChange} type="text" className="shadow appearance-none border border-red-500 rounded w-full py-2 px-3 text-gray-700 mb-3 leading-tight focus:outline-none focus:shadow-outline" placeholder="Add todo" />
            <button className="bg-blue-500 hover:bg-blue-700 text-white font-bold px-4 rounded" type="submit" > Bruh </button>
        </form>
    );
}

interface ITodosContainer {
    todos: any[];
    getTodos: any;
}

const TodosContainer: FC<ITodosContainer> = ({ todos, getTodos }) => {
    const RemoveTodo = async (id: number) => {
        await axios.delete(`http://localhost:5180/todo/${id}`);
        getTodos();
    }

    return (
        <div className="ml-2 ease-linear transition-all duration-150">
            {
                todos.length > 0 ?
                    todos.map((todo: any, index) => {
                        return (
                            <div key={index} className="grid grid-cols-2 gap-3">
                                <h1>{todo.title}</h1>
                                <button
                                    className="my-1 bg-red-500 hover:bg-blue-700 text-white font-bold px-2 rounded"
                                    onClick={() => RemoveTodo(todo.id)}
                                >Delete</button>
                                iii</div>
                        )
                    })
                    :
                    <h1>No todos rn.</h1>
            }
        </div>
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
            <div className="min-h-screen w-full flex item-center justify-center bg-gradient-to-r from-cyan-500 to-pink-500 ">
                <div className="mt-3 grid grid-cols-2 divide-x">
                    <div className="mx-2">
                        <TodoInput getTodos={getTodos} />
                    </div>
                    <div>
                        <TodosContainer todos={todos} getTodos={getTodos} />
                    </div>
                </div>
            </div>

            <Link to="/test">Test</Link>
        </>
    );
}

export default App;
