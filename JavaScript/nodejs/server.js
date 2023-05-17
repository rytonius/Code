const express = require('express');
const app = express();

app.set('view engine', 'ejs')

app.get('/', (req, res) => {
    console.log('here');
    //res.download("server.js", "server.js")
    //res.json({message: "nice"})
    res.render('index');
})

app.listen(3000);

