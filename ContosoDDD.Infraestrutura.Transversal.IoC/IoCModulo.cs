using Autofac;


namespace ContosoDDD.Infraestrutura.Transversal.IoC
{
    public class IoCModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IoCConfig.Load(builder);
        }
    }
}
