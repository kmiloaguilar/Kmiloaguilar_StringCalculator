using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class given_a_string_calculator_context
    {
        Establish context = () =>
        {
            StringCalcutorObject = new StringCalculatorClass();
        };

        public static StringCalculatorClass StringCalcutorObject;
    }
}