using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_3_plus_2_plus_1 : given_a_string_calculator_context
    {

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("3+2+1");
        };

        It should_return_the_number_6 = () =>
        {
            _result.ShouldEqual(6);
        };
        static int _result;
    }
}