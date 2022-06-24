import { useEffect, useState } from 'react';
import './App.css';

function App() {
    // image state
    const [image, setImage] = useState([]);

    useEffect(() => {
        // Get random image
        const getRandomImage = async () => {
            const response = await fetch('http://localhost:5180/todo');
            const image = await response.json();

            setImage(image);
        }
        getRandomImage();
    }, []);
    return (
        <>
            {
                image.length > 0 &&
                image.map((image: any, index) => {
                    return (
                        <div key={index}>
                            <h1>{image.title}</h1>
                        </div>
                    )
                })
            }
        </>
    );
}

export default App;
