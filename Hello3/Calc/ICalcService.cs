namespace Hello3.Calc {
    public interface ICalcService {
        T Addition<T>(params T[] numbers) where T : IConvertible;
        T Subtraction<T>(params T[] numbers) where T : IConvertible;
        T Multiplication<T>(params T[] numbers) where T : IConvertible;
        T Division<T>(params T[] numbers) where T : IConvertible;
    }
}