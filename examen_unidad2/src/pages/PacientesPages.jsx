import React, { useEffect, useState } from 'react';
import { FormPaciente, ListImc } from '../components';

export  const PacientesPages = () => {
    const [pacientes, setPacientes] = useState([]);
    const [paciente, setPaciente] = useState({ nombre: '' });
    const [fetched, setFetched] = useState(true);

    useEffect(() => {
        if (fetched) {
            fetch('https://localhost:7132/api/Paciente')
                .then((response) => response.json())
                .then((dataResponse) => {
                    setPacientes(dataResponse.data);
                });
            setFetched(false);
        }
    }, [fetched]);

    const addPaciente = async () => {
        try {
            const response = await fetch('https://localhost:7132/api/Paciente', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(paciente),
            });

            if (!response.ok) {
                throw new Error('Error al crear el paciente');
            }

            setFetched(true);
            setPaciente({ nombre: '' });
        } catch (error) {
            console.error(error);
        }
    };

    return (

        <div className="mx-10 bg-white shadow-lg overflow-hidden">
            <div className="px-4 py-2 ">
                <h1 className="text-gray-800 font-bold text-2xl uppercase">Lista de Pacientes</h1>

                <FormPaciente
                    addPaciente={addPaciente}
                    paciente={paciente}
                    setPaciente={setPaciente}
                />

                <ListImc pacientes={pacientes} />
            </div>
        </div>


    );
};

export default PacientesPages;
