using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_3_minus_1 :given_a_string_calculator_context
    {
        

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("3-1");

        };

        It should_return_the_number_2 = () =>
        {
            _result.ShouldEqual(2);
        };
        static int _result;
    }
}