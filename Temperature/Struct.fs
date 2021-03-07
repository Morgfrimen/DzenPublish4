namespace TemperatyreStruct

module public Struct =
    type public ITemperatyre =
        abstract member Value : System.Single with get

    //Кельвины
    type public K =          
           struct
               val mutable value : System.Single
               interface ITemperatyre with
                   member this.Value
                       with get (): System.Single = 
                           this.value

               new(v: System.Single) = {value = v}
           end    
    //Фарингейты
    type public F =          
       struct
           val mutable value : System.Single
           interface ITemperatyre with
               member this.Value
                   with get (): System.Single = 
                       this.value

           new(v: System.Single) = {value = v}
       end
    //Цельсии
    type public C =          
       struct
           val mutable value : System.Single
           interface ITemperatyre with
               member this.Value
                   with get (): System.Single = 
                       this.value

           new(v: System.Single) = {value = v}
       end

   

   
