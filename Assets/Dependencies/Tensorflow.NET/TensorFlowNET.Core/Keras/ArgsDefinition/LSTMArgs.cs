namespace Tensorflow.Keras.ArgsDefinition
{
    public class LSTMArgs : RNNArgs
    {
        public int Units { get; set; }
        public Activation Activation { get; set; }
        public Activation RecurrentActivation { get; set; }
        public IInitializer KernelInitializer { get; set; }
        public IInitializer RecurrentInitializer { get; set; }
        public IInitializer BiasInitializer { get; set; }
        public bool UnitForgetBias { get; set; }
        public float Dropout { get; set; }
        public float RecurrentDropout { get; set; }
        public int Implementation { get; set; }
        public new bool ReturnSequences { get; set; }
        public new bool ReturnState { get; set; }
        public new bool GoBackwards { get; set; }
        public new bool Stateful { get; set; }
        public new bool TimeMajor { get; set; }
        public new bool Unroll { get; set; }
    }
}
