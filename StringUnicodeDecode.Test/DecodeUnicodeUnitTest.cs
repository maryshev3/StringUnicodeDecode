namespace StringUnicodeDecode.Test;

public class DecodeUnicodeUnitTest
{
    [Fact]
    public void Test1()
    {
        // Arrange.
        string input = @"\u043E\u0431\u043D\u0430\u0440\u0443\u0436\u0435\u043D\u0430 \u0432\u0437\u0430\u0438\u043C\u043E\u0431\u043B\u043E\u043A\u0438\u0440\u043E\u0432\u043A\u0430";
        string trustResult = "обнаружена взаимоблокировка";

        // Act.
        string factResult = input.DecodeUnicodes();

        // Assert.
        Assert.Equal(trustResult, factResult);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange.
        string input = @"В текст также добавлен нормальный текст on different languages\u043E\u0431\u043D\u0430\u0440\u0443and hear too\u0436\u0435\u043D\u0430 \u0432\u0437\u0430\u0438\u043C\u043E\u0431\u043B\u043E\u043A\u0438\u0440\u043E\u0432\u043A\u0430. И тут";
        string trustResult = "В текст также добавлен нормальный текст on different languagesобнаруand hear tooжена взаимоблокировка. И тут";

        // Act.
        string factResult = input.DecodeUnicodes();

        // Assert.
        Assert.Equal(trustResult, factResult);
    }
}