import { FC } from "react"
import { Button, Card, CardContent, Grid, Typography } from "@mui/material";

interface IQuestionProps {
    title: string,
    desc: string
}

const Question: FC<IQuestionProps> = (props) => {
    return (
        <>
        <Card style={{background:"blue"}}>
            <CardContent>
                {props.title}
            </CardContent>
            <CardContent>
            <Typography variant="body2" color="text.secondary">{props.desc}</Typography>
            </CardContent>
        </Card>
        </>
    )
}

function App() {
  return (
    <>
    <Grid container spacing={4} style={{background:"gray"}}>
        <Grid item xs={12}>
            <Question title={"arst"} desc={"this is arst"} />
        </Grid>
        <Grid item xs={12}>
            <Button>arst</Button>
        </Grid>
    </Grid>
    </>
  )
}

export default App
