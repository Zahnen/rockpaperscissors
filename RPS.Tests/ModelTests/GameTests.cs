using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Test
{
  [TestClass]
  public class RoundTests
  {
    [TestMethod]
    public void RoundConstructor_CreatesInstanceOfRound_Round()
    {
      Round newRound = new Round("rock", "scissors");
      Assert.AreEqual(typeof(Round), newRound.GetType());
    }
    [TestMethod]
    public void GetHand_ReturnsHand1_String()
    {
      string hand1 = "rock";
      string hand2 = "scissors";
      Round newRound = new Round(hand1, hand2);
      string result = newRound.Hand1;
      Assert.AreEqual(hand1, result);
    }
    [TestMethod]
    public void GetHand_ReturnsHand2_String()
    {
      string hand1 = "rock";
      string hand2 = "scissors";
      Round newRound = new Round(hand1, hand2);
      string result2 = newRound.Hand2;
      Assert.AreEqual(hand2, result2);
    }
    [TestMethod]
    public void GetHand_ReturnsBothHands_String()
    {
      string hand1 = "rock";
      string hand2 = "rock";
      Round newRound = new Round(hand1, hand2);
      string result1 = newRound.Hand1;
      string result2 = newRound.Hand2;
      Assert.AreEqual(hand2, result1);
    }
    [TestMethod]
    public void GetWinner_ReturnsWinner_String()
    {
      string hand1 = "scissors";
      string hand2 = "paper";
      Round newRound = new Round(hand1, hand2);
      Assert.AreEqual(true, newRound.GetWinner(hand1, hand2));
    }
  }
}