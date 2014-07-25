using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_9_minus_4_minus_1 : given_a_string_calculator_context
    {
        

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("9-4-1");

        };

        It should_return_the_number_4 = () =>
        {
            _result.ShouldEqual(4);
        };
        static int _result;
    }
}