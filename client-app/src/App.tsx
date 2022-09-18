import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import axios from 'axios';


function App() {
  const [relationTypes,setRelationTypes]= useState([]);

  useEffect(()=>{
    axios.get('http://localhost:5110/api/RelationType').then(response=>{
      console.log(response.data);
      setRelationTypes(response.data);
    });
  } , []);
  return (
    <div className="App">
      <header className="App-header">
        <ul>
          {relationTypes.map((rel:any)=>(<li>{rel.code}</li>))}
        </ul>
      </header>
    </div>
  );
}

export default App;
