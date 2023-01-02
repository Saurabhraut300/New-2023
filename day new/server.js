const express=require('express');
const path=require('path');
const app=express();
app.get('/',(req,res)=>{
    res.sendFile(path.join(__dirname,'/new.html'));
});
app.get('/aboutus',(req,res)=>
{
    var person={firstName:'akshay',LastName:'Hambarde',id:10};
    res.send(person);

});
app.listen(3001);