import React, { useState } from 'react';
import FormPaciente from './components/FormPaciente';
import ListImc from './components/ListImc';

const App = () => {
    const [paciente, setPaciente] = useState({ nombre: '', peso: 0, altura: 0 });
    const [pacientes, setPacientes] = useState([]);

    const addPaciente = () => {
        setPacientes([...pacientes, paciente]);
        setPaciente({ nombre: '', peso: 0, altura: 0 });
    };

    return (
        <div className="App">
            <FormPaciente addPaciente={addPaciente} paciente={paciente} setPaciente={setPaciente} />
            <ListImc pacientes={pacientes} />
        </div>
    );
};

export default App;

