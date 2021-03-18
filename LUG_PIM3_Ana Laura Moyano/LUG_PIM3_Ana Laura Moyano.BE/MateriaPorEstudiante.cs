namespace LUG_PIM3_Ana_Laura_Moyano.BE
{
    public class MateriaPorEstudiante
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public int? Calificacion { get; set; }
    }
}
