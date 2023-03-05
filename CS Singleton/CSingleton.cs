﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Singleton
{
    


    ///////////////////////////////////////////////////PAP//////////////////////////////////////////////////
    
    //SE DEFINE UNA CLASE PUBLICA SELLADA (SEALED) LLAMADA CSingleton.
    //SE MARCA A LA CLASE COMO SELLADA PARA EVITAR QUE SE HEREDE DE ELLA. GARANTIZANDO SOLO UNA INSTANCIA DE LA CLASE.
    public sealed class CSingleton
    {
    //SE DECLARA UN ATRIBUTO PRIVADO LLAMADO instancia DONDE SE ALMACENARA LA UNICA INSTANCIA DE LA CLASE.
    //AL SER ESTATICO EL ATRIBUTO PERTENECE A LA CLASE EN SI EN LUGAR DE PERTENECER A UNA INSTANCIA PARTICULAR DE LA CLASE.
    //OBLIGATORIAMENTE,ESTO SE LOGRA ANTEPONIENDO EL NOMBRE DE LA CLASE ANTES DEL NOMBRE DE LA VARIABLE, EN ESTE CASO CSingleton.
    
    //RECORDAR QUE UN ATRIBUTO ESTATICO ES UN TIPO ESPECIAL DE ATRIBUTO QUE PERTENECE A LA CLASE EN LUGAR DE A UNA INSTANCIA INDIVIDUAL DE LA CLASE.
    //ESTO SIGNIFICA QUE EN LUGAR DE TENER UN VALOR SEPARADO PARA CADA OBJETO DE LA CLASE EL ATRIBUTO ESTATICO ES COMPARTIDO POR TODOS LOS OBJETOS DE LA CLASE Y SE ALMACENA EN UN SOLO LUGAR EN LA MEMORIA.
    //POR LO TANTO, SI SE CAMBIA DE VALOR EL ATRIBUTO ESTATICO EN UNA INSTANCIA, EL CAMBIO SE REFLEJARA EN TODAS LAS DEMAS INSTANCIAS DE LA MISMA CLASE.
        private static CSingleton _instancia = null;

    //PARA ESTE EJEMPLO UTILIZAREMOS LOS SIGUIENTES DATOS QUE FORMARAN PARTE DEL OBJETO INSTANCIADO.
        private string nombre;
        private int edad;

    //SE DECLARA UN CONSTRUCTOR DEL TIPO PRIVADO DE MODOTAL QUE SOLO PUEDA SER ACCEDIDO POR LA PROPIA CLASE.
    //ASIGNAMOS VALORES QUE TENDRAN ESTOS ATRIBUTOS AL MOMENTO DE SER INSTANCIADOS.
        private CSingleton()
        {
            nombre = "Sin asignar";
            edad = 99;    

        }

    //CREAMOS UN METODO ESTATICO PUBLICO PARA QUE PUEDA SER ACCEDIDO DE FORMA GLOBAL.
    //ESTE METODO AL SER ESTATICO PODRA SER INVOCADO SIN NECESIDAD DE INSTANCIAR.
    //RECORDAR QUE LOS METODOS ESTATICOS PERTENECEN A UNA CLASE EN LUGAR DE UNA INSTANCIA DE LA CLASE.
    //A DIFERENCIA DE LOS METODOS DE INSTANCIA, QUE REQUIEREN QUE SE CREE UN OBJETO DE LA CLASE PARA LLAMAR AL METODO.
    //lOS METODOS ESTATICOS SE PUEDEN LLAMAR DIRECTAMENTE DESDE LA CLASE SIN NECESIDAD DE CREAR UN OBJETO.

        public static CSingleton ObtenerInstancia(int pedad, string pnombre)
        {

    //PREGUNTAMOS SI EL ATRUBUTO INSTANCIA ESTA VACIO - (SI NO CONTIENE NINGUNA INSTANCIA).
    //UNA VEZ INSTANCIADO, LA 2A VEZ QUE SE QUIERA INSTANCIAR SALTA EL IF Y DEVUELVE LA INSTANCIA CREADA ANTERIORMENTE.
            if (_instancia==null)
            {

    //INSTANCIAMOS HACIENDO USO DEL COSNTRUCTOR QUE SE ENCUENTRA DE FORMA PRIVADA.
    //ESTO ES POSIBLE YA QUE EL CONSTRUCTOR PRIVADO PERMITE SER ACCEDIDO DESDE DENTRO DE LA PROPIA CLASE.

                _instancia = new CSingleton();
                _instancia.edad = pedad;
                _instancia.nombre = pnombre;
                Console.WriteLine("Se crea instancia ...");
                

            }

    //RETORNAMOS LA INSTANCIA 
            return _instancia;

        }

    ////////////////////////AGREGO ALGUNOS METODOS PARA HACER PRUEBAS EN CONSOLA//////////////////////////7

    //METODO PARA IMPRIMIR RESULTADOS
    //EL METODO ToString ES UN METODO VIRTUAL QUE SE UTILIZA PARA DEVOLVER UNA REPRESENTACION EN FORMATO TEXTO DE UN OBJETO
    //EL MISMO PUEDE SER UTILIZADO PARA FINES DE DEPURACION Y REGISTRO.
    //ESTE METODO SE ESTA ANULANDO  override PARA PROPORCIONAR UNA IMPLEMENTACION PERSONALIZADA EN LA CLASE QUE LO CONTIENE.
    //SE UTILIZA PARA FORMATEAR UNA CADENA CON ARGUMENTOS.
        public override string ToString()
        {
            return string.Format("Este es el metodo ToString: {0}, tiene la edad de {1}", nombre, edad);
        }

    }
}

//NOTA: ESTA FORMA DE SINGLETON NO ES APLICABLE EN PROGRAMACION CONCURRENTE O HILOS, O EN PARALELO.