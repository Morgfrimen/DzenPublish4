namespace Temperature

module public Temperature =
    open TemperatyreStruct.Struct
    
    type public IConvertable<'T> =
        abstract member ToCelsia : unit -> C
        abstract member ToKelvin : unit -> K
        abstract member ToFaringete : unit -> F

    type public Temperatyre=
        val value : ITemperatyre
        
        interface IConvertable<C> with
            member this.ToCelsia(): C = this.value :?> C
            member this.ToFaringete(): F = 
                let newValue =
                    new F(this.value.Value * 1.8f + 32f)
                newValue
            member this.ToKelvin(): K = 
                let newValue =
                    new K(this.value.Value + 273f)
                newValue

        interface IConvertable<F> with
            member this.ToCelsia(): C = 
                let newValue =
                    new C((this.value.Value - 32f)/1.8f)
                newValue
            member this.ToFaringete(): F = 
                this.value :?> F
            member this.ToKelvin(): K = 
                let newValue =
                    new K((this.value.Value + 459f)/1.8f)
                newValue

        interface IConvertable<K> with
            member this.ToCelsia(): C = 
                let newValue =
                    new C(this.value.Value - 273f)
                newValue
            member this.ToFaringete(): F = 
                let newValue =
                    new F(this.value.Value * 1.8f - 459f)
                newValue
            member this.ToKelvin(): K = 
                 this.value :?> K

        new(temp:ITemperatyre) = {value = temp}
