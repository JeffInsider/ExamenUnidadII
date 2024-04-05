
export const FormPaciente = ({ addPaciente, paciente, setPaciente }) => {
    const handleSubmit = (e) => {
        e.preventDefault();
        addPaciente();
    };

    return (
        <form onSubmit={handleSubmit} className="container mx-auto max-w-md">
            <h2 className="text-center mb-4">Calculadora de IMC</h2>
            <div className="flex flex-col space-y-4">
                <div>
                    <label htmlFor="nombre" className="block">Nombre:</label>
                    <input
                        type="text"
                        id="nombre"
                        name="nombre"
                        value={paciente.nombre}
                        onChange={(e) => setPaciente({ ...paciente, nombre: e.target.value })}
                        required
                        className="w-full px-4 py-2 border border-gray-300 rounded-md"
                    />
                </div>
                <div>
                    <label htmlFor="peso" className="block">Peso (kg):</label>
                    <input
                        type="number"
                        id="peso"
                        name="peso"
                        value={paciente.peso}
                        onChange={(e) => setPaciente({ ...paciente, peso: e.target.value })}
                        required
                        className="w-full px-4 py-2 border border-gray-300 rounded-md"
                    />
                </div>
                <div>
                    <label htmlFor="altura" className="block">Altura (m):</label>
                    <input
                        type="number"
                        id="altura"
                        name="altura"
                        value={paciente.altura}
                        onChange={(e) => setPaciente({ ...paciente, altura: e.target.value })}
                        required
                        className="w-full px-4 py-2 border border-gray-300 rounded-md"
                    />
                </div>
                <button type="submit" className="bg-blue-500 text-white px-4 py-2 rounded-md hover:bg-blue-700 transition-colors">Calcular IMC</button>
            </div>
        </form>
    );
};

export default FormPaciente;


