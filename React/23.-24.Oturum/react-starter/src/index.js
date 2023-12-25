import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

//Burada index.js, NodeJS tarafından çalıştırıldığında ilgili html okunuyor ve idsi 'root' olan div'in içine 'App' isimli Component'imi render ediyorum.
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);

