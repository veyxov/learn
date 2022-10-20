import { useState } from 'react'
import './App.css'

const Buttons = () => {
    const [selectedCount, setSelectedCount] = useState(null);
    const ChangeBag = (value) => {
        if (selectedCount === null && value >= 0)
            setSelectedCount(1);

        setSelectedCount(selectedCount + value);

        if (selectedCount == 1 && value < 0)
            setSelectedCount(null);
    }

    return (<div>
        {
            selectedCount !== null ?
                <>
                    <button className="btn1" onClick={() => ChangeBag(1)}>+</button>
                    <span>{ selectedCount }</span>
                    <button className="btn2" onClick={() => ChangeBag(-1)}>-</button>
                </>
                :
                <>
                    <button className="btn" onClick={() => ChangeBag(1)}>Add to cart</button>
                </>
        }
    </div>)
}

function App() {

    return (
        <div className="App" style={{display:"flex"}}>
            <div className="box">
                <p className="text">
                    Tree 🌲
                </p>
                <Buttons />
            </div>
            <div className="box">
                <p className="text">
                    Handala 🍈
                </p>
                <Buttons />
            </div>
        </div>
    )
}

export default App
