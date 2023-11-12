using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace RokeBackend.Model
{
    public class Form
    {
        [Key]
        public Guid id { get; set; }
        public Guid idplanning { get; set; }
        public Guid idForm {  get; set; }
        public Guid idTecnico { get; set; } 
        public Guid inventarioId { get; set; }
        public DateTime  startTime { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime checkOut { get; set; }
        public string frecuencia { get; set; }
        public string Unidad_AC_antes_preventivo {  get; set; }
        public string temperatura_antes_preventivo { get; set; }
        public string aviso_precaucion { get; set; }
        public bool equipo_limpio { get; set; }
        public string temperatura_despues_preventivo { get; set; }
        public bool limpieza_serpentir_condesador { get; set; }
        public bool limpieza_serpentir_evaporador { get; set; }
        public bool limpieza_filtro { get; set; }
        public bool cambio_filtro { get; set; }
        public bool limpieza_bandeja_desague { get; set; }
        public bool sopleteo_drenaje { get; set; }
        public bool limpieza_rejillas_suministro_retorno { get; set; }
        public bool lubricacion_motores { get; set; }
        public bool manchas_aceite { get; set; }
        public string medida_amperajeL1_L2_L3 { get; set; }
        public string voltajeL1_L2_L3 { get; set; }
        public string revision_Contactatores { get; set; }
        public string revision_relevadores { get; set; }
        public string revision_capacitadores { get; set; }
        public string revision_sensores_temperatura { get; set; }
        public string revision_sensores_humedad { get; set; }
        public string presion_succion { get; set; }
        public string presion_descarga { get; set; }
        public string niveles_aceite { get; set; }
        public bool fuga_refigerante { get; set; }
        public string carga_aceite { get; set; }
        public string cantidad_refigerante { get; set; }
        public string resistencia_calentamiento { get; set; }
        public string valvulos_servicio { get; set; }
        public bool switch_baja { get; set; }
        public string switch_alta { get; set; }
        public bool DGT { get; set; }
        public string switch_aceite  { get; set; }
        public string chequeo_ducteria { get; private set; }
        public string chequeo_estado_aislamiento { get; private set; }
        public string ubicacion { get; private set; }
        public string capacidad_BTU { get; private set; }
        public string tipologia { get; private set; }
        public string actividad_ejecutada { get; private set; }
        public string observaciones { get; private set; }
       


    }
}
