import React from 'react';

const ListImc = ({ pacientes }) => {
    const calcularIMC = (peso, altura) => {
        return (peso / (altura * altura));
    };

    const categoria = (imc) => {
        if (imc < 18.5) return 'Bajo peso';
        else if (imc >= 18.5 && imc <= 24.9) return 'Peso normal';
        else if (imc >= 25.0 && imc <= 29.9) return 'Sobrepeso';
        else if (imc >= 30.0 && imc <= 34.9) return 'Obesidad grado I';
        else if (imc >= 35.0 && imc <= 39.9) return 'Obesidad grado II';
        else return 'Obesidad grado III';
    };

    return (
        <div className="container mx-auto max-w-md mt-5">
            <h2 className="text-center mb-4">Lista de Pacientes</h2>
            <ul>
                {pacientes.map((paciente, index) => (
                    <li key={index}>
                        <p>Nombre: {paciente.nombre}</p>
                        <p>Peso: {paciente.peso}</p>
                        <p>Altura: {paciente.altura}</p>
                        <p>IMC: {calcularIMC(paciente.peso, paciente.altura)}</p>
                        <p>Categoría: {categoria(calcularIMC(paciente.peso, paciente.altura))}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default ListImc;

