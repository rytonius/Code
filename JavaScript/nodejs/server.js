const express = require('express');
const app = express();

// top to bottom, this will be called before the app.get
app.use(express.static("public"));
app.use(express.urlencoded({ extended: true }))
app.use(express.json()); // works like urlencoded, just for parsing json 

app.set('view engine', 'ejs')

// define middleware top to bottom to trigger
//app.use(logger)
app.get('/', (req, res) => {
    console.log('here');
    //res.download("server.js", "server.js")
    //res.sendStatus('400')
    //res.json({message: "nice"})
    res.render('index', {text: "world"});
})



const userRouter = require('./routes/users')


app.use('/users', userRouter)



app.listen(3000);

