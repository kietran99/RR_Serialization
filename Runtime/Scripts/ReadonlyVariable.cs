namespace RR.Serialization
{
    [System.Serializable]
    public class ReadonlyVariable<T>
    {
        [UnityEngine.SerializeField]
        private T _value;

        public T Value => _value;
    }
}
