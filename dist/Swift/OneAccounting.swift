// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

import Foundation

class CharacterArray{
    var ca : [Character]!
}

func characterArray(_ x : String) -> CharacterArray{
    let ca = CharacterArray()
    ca.ca = Array(x)
    return ca
}
func charToDouble(_ c : Character) -> Double{
    return Double(c.unicodeScalars.map{$0.value}.reduce(0, +))
}
/* Downloaded from https://repo.progsbase.com - Code Developed Using progsbase. */

public class Account{
	public var name : [Character]!
	public var endingBalance : FixedPoint15d!
	public var startingBalance : FixedPoint15d!
	public var from : Date!
	public var to : Date!
	public var sumDebit : FixedPoint15d!
	public var sumCredit : FixedPoint15d!
}
public class AccountReferenceClass{
	public var ref : Account!
}
func AccountCreateFunction() -> AccountReferenceClass{
	var returnReference = AccountReferenceClass()
	returnReference.ref = Account()
	return returnReference
}
public class AccountDefinition{
	public var accountName : [Character]!
	public var number : [Character]!
	public var role : [Character]!
	public var debitBalance : Bool!
}
public class AccountDefinitionReferenceClass{
	public var ref : AccountDefinition!
}
func AccountDefinitionCreateFunction() -> AccountDefinitionReferenceClass{
	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = AccountDefinition()
	return returnReference
}
public class AccountPlan{
	public var accountDefinitions : [AccountDefinition]!
}
public class AccountPlanReferenceClass{
	public var ref : AccountPlan!
}
func AccountPlanCreateFunction() -> AccountPlanReferenceClass{
	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = AccountPlan()
	return returnReference
}
public class Ledger{
	public var decimals : Double!
	public var transactions : [Transaction]!
	public var accountPlan : AccountPlan!
}
public class LedgerReferenceClass{
	public var ref : Ledger!
}
func LedgerCreateFunction() -> LedgerReferenceClass{
	var returnReference = LedgerReferenceClass()
	returnReference.ref = Ledger()
	return returnReference
}
public class Line{
	public var account : [Character]!
	public var debit : FixedPoint15d!
	public var credit : FixedPoint15d!
	public var description : [Character]!
	public var date : Date!
}
public class LineReferenceClass{
	public var ref : Line!
}
func LineCreateFunction() -> LineReferenceClass{
	var returnReference = LineReferenceClass()
	returnReference.ref = Line()
	return returnReference
}
public class Transaction{
	public var lines : [Line]!
}
public class TransactionReferenceClass{
	public var ref : Transaction!
}
func TransactionCreateFunction() -> TransactionReferenceClass{
	var returnReference = TransactionReferenceClass()
	returnReference.ref = Transaction()
	return returnReference
}
public class Sections{
	public var codes : [Character]!
	public var counts : [Double]!
}
public class SectionsReferenceClass{
	public var ref : Sections!
}
func SectionsCreateFunction() -> SectionsReferenceClass{
	var returnReference = SectionsReferenceClass()
	returnReference.ref = Sections()
	return returnReference
}
public class RGBABitmapImageReference{
	public var image : RGBABitmapImage!
}
public class RGBABitmapImageReferenceReferenceClass{
	public var ref : RGBABitmapImageReference!
}
func RGBABitmapImageReferenceCreateFunction() -> RGBABitmapImageReferenceReferenceClass{
	var returnReference = RGBABitmapImageReferenceReferenceClass()
	returnReference.ref = RGBABitmapImageReference()
	return returnReference
}
public class Success{
	public var feilmelding : [Character]!
	public var success : Bool!
}
public class SuccessReferenceClass{
	public var ref : Success!
}
func SuccessCreateFunction() -> SuccessReferenceClass{
	var returnReference = SuccessReferenceClass()
	returnReference.ref = Success()
	return returnReference
}
public class RGBABitmapImageReference{
	public var image : RGBABitmapImage!
}
public class RGBABitmapImageReferenceReferenceClass{
	public var ref : RGBABitmapImageReference!
}
func RGBABitmapImageReferenceCreateFunction() -> RGBABitmapImageReferenceReferenceClass{
	var returnReference = RGBABitmapImageReferenceReferenceClass()
	returnReference.ref = RGBABitmapImageReference()
	return returnReference
}
public class Rectangle{
	public var x1 : Double!
	public var x2 : Double!
	public var y1 : Double!
	public var y2 : Double!
}
public class RectangleReferenceClass{
	public var ref : Rectangle!
}
func RectangleCreateFunction() -> RectangleReferenceClass{
	var returnReference = RectangleReferenceClass()
	returnReference.ref = Rectangle()
	return returnReference
}
public class ScatterPlotSeries{
	public var linearInterpolation : Bool!
	public var pointType : [Character]!
	public var lineType : [Character]!
	public var lineThickness : Double!
	public var xs : [Double]!
	public var ys : [Double]!
	public var color : RGBA!
}
public class ScatterPlotSeriesReferenceClass{
	public var ref : ScatterPlotSeries!
}
func ScatterPlotSeriesCreateFunction() -> ScatterPlotSeriesReferenceClass{
	var returnReference = ScatterPlotSeriesReferenceClass()
	returnReference.ref = ScatterPlotSeries()
	return returnReference
}
public class ScatterPlotSettings{
	public var scatterPlotSeries : [ScatterPlotSeries]!
	public var autoBoundaries : Bool!
	public var xMax : Double!
	public var xMin : Double!
	public var yMax : Double!
	public var yMin : Double!
	public var autoPadding : Bool!
	public var xPadding : Double!
	public var yPadding : Double!
	public var xLabel : [Character]!
	public var yLabel : [Character]!
	public var title : [Character]!
	public var showGrid : Bool!
	public var gridColor : RGBA!
	public var xAxisAuto : Bool!
	public var xAxisTop : Bool!
	public var xAxisBottom : Bool!
	public var yAxisAuto : Bool!
	public var yAxisLeft : Bool!
	public var yAxisRight : Bool!
	public var width : Double!
	public var height : Double!
}
public class ScatterPlotSettingsReferenceClass{
	public var ref : ScatterPlotSettings!
}
func ScatterPlotSettingsCreateFunction() -> ScatterPlotSettingsReferenceClass{
	var returnReference = ScatterPlotSettingsReferenceClass()
	returnReference.ref = ScatterPlotSettings()
	return returnReference
}
public class BarPlotSeries{
	public var ys : [Double]!
	public var color : RGBA!
}
public class BarPlotSeriesReferenceClass{
	public var ref : BarPlotSeries!
}
func BarPlotSeriesCreateFunction() -> BarPlotSeriesReferenceClass{
	var returnReference = BarPlotSeriesReferenceClass()
	returnReference.ref = BarPlotSeries()
	return returnReference
}
public class BarPlotSettings{
	public var width : Double!
	public var height : Double!
	public var autoBoundaries : Bool!
	public var yMax : Double!
	public var yMin : Double!
	public var autoPadding : Bool!
	public var xPadding : Double!
	public var yPadding : Double!
	public var title : [Character]!
	public var showGrid : Bool!
	public var gridColor : RGBA!
	public var barPlotSeries : [BarPlotSeries]!
	public var yLabel : [Character]!
	public var autoColor : Bool!
	public var grayscaleAutoColor : Bool!
	public var autoSpacing : Bool!
	public var groupSeparation : Double!
	public var barSeparation : Double!
	public var autoLabels : Bool!
	public var xLabels : [StringReference]!
	public var barBorder : Bool!
}
public class BarPlotSettingsReferenceClass{
	public var ref : BarPlotSettings!
}
func BarPlotSettingsCreateFunction() -> BarPlotSettingsReferenceClass{
	var returnReference = BarPlotSettingsReferenceClass()
	returnReference.ref = BarPlotSettings()
	return returnReference
}
public class ArbitraryPrecisionInteger{
	public var sign : Bool!
	public var number : UnsignedInteger!
}
public class ArbitraryPrecisionIntegerReferenceClass{
	public var ref : ArbitraryPrecisionInteger!
}
func ArbitraryPrecisionIntegerCreateFunction() -> ArbitraryPrecisionIntegerReferenceClass{
	var returnReference = ArbitraryPrecisionIntegerReferenceClass()
	returnReference.ref = ArbitraryPrecisionInteger()
	return returnReference
}
public class ArbitraryPrecisionFixedPointNumber{
	public var baseNumber : ArbitraryPrecisionInteger!
	public var pointPosition : Double!
}
public class ArbitraryPrecisionFixedPointNumberReferenceClass{
	public var ref : ArbitraryPrecisionFixedPointNumber!
}
func ArbitraryPrecisionFixedPointNumberCreateFunction() -> ArbitraryPrecisionFixedPointNumberReferenceClass{
	var returnReference = ArbitraryPrecisionFixedPointNumberReferenceClass()
	returnReference.ref = ArbitraryPrecisionFixedPointNumber()
	return returnReference
}
public class UnsignedInteger{
	public var digits : [Double]!
}
public class UnsignedIntegerReferenceClass{
	public var ref : UnsignedInteger!
}
func UnsignedIntegerCreateFunction() -> UnsignedIntegerReferenceClass{
	var returnReference = UnsignedIntegerReferenceClass()
	returnReference.ref = UnsignedInteger()
	return returnReference
}
public class BooleanArrayReference{
	public var booleanArray : [Bool]!
}
public class BooleanArrayReferenceReferenceClass{
	public var ref : BooleanArrayReference!
}
func BooleanArrayReferenceCreateFunction() -> BooleanArrayReferenceReferenceClass{
	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = BooleanArrayReference()
	return returnReference
}
public class BooleanReference{
	public var booleanValue : Bool!
}
public class BooleanReferenceReferenceClass{
	public var ref : BooleanReference!
}
func BooleanReferenceCreateFunction() -> BooleanReferenceReferenceClass{
	var returnReference = BooleanReferenceReferenceClass()
	returnReference.ref = BooleanReference()
	return returnReference
}
public class CharacterReference{
	public var characterValue : Character!
}
public class CharacterReferenceReferenceClass{
	public var ref : CharacterReference!
}
func CharacterReferenceCreateFunction() -> CharacterReferenceReferenceClass{
	var returnReference = CharacterReferenceReferenceClass()
	returnReference.ref = CharacterReference()
	return returnReference
}
public class NumberArrayReference{
	public var numberArray : [Double]!
}
public class NumberArrayReferenceReferenceClass{
	public var ref : NumberArrayReference!
}
func NumberArrayReferenceCreateFunction() -> NumberArrayReferenceReferenceClass{
	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = NumberArrayReference()
	return returnReference
}
public class NumberReference{
	public var numberValue : Double!
}
public class NumberReferenceReferenceClass{
	public var ref : NumberReference!
}
func NumberReferenceCreateFunction() -> NumberReferenceReferenceClass{
	var returnReference = NumberReferenceReferenceClass()
	returnReference.ref = NumberReference()
	return returnReference
}
public class StringArrayReference{
	public var stringArray : [StringReference]!
}
public class StringArrayReferenceReferenceClass{
	public var ref : StringArrayReference!
}
func StringArrayReferenceCreateFunction() -> StringArrayReferenceReferenceClass{
	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = StringArrayReference()
	return returnReference
}
public class StringReference{
	public var stringx : [Character]!
}
public class StringReferenceReferenceClass{
	public var ref : StringReference!
}
func StringReferenceCreateFunction() -> StringReferenceReferenceClass{
	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = StringReference()
	return returnReference
}
public class Date{
	public var year : Double!
	public var month : Double!
	public var day : Double!
}
public class DateReferenceClass{
	public var ref : Date!
}
func DateCreateFunction() -> DateReferenceClass{
	var returnReference = DateReferenceClass()
	returnReference.ref = Date()
	return returnReference
}
public class DateReference{
	public var date : Date!
}
public class DateReferenceReferenceClass{
	public var ref : DateReference!
}
func DateReferenceCreateFunction() -> DateReferenceReferenceClass{
	var returnReference = DateReferenceReferenceClass()
	returnReference.ref = DateReference()
	return returnReference
}
public class Interval{
	public var first : Date!
	public var last : Date!
}
public class IntervalReferenceClass{
	public var ref : Interval!
}
func IntervalCreateFunction() -> IntervalReferenceClass{
	var returnReference = IntervalReferenceClass()
	returnReference.ref = Interval()
	return returnReference
}
public class DateTimeTimezone{
	public var dateTime : DateTime!
	public var timezoneOffsetSeconds : Double!
}
public class DateTimeTimezoneReferenceClass{
	public var ref : DateTimeTimezone!
}
func DateTimeTimezoneCreateFunction() -> DateTimeTimezoneReferenceClass{
	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = DateTimeTimezone()
	return returnReference
}
public class DateTimeTimezoneReference{
	public var dateTimeTimezone : DateTimeTimezone!
}
public class DateTimeTimezoneReferenceReferenceClass{
	public var ref : DateTimeTimezoneReference!
}
func DateTimeTimezoneReferenceCreateFunction() -> DateTimeTimezoneReferenceReferenceClass{
	var returnReference = DateTimeTimezoneReferenceReferenceClass()
	returnReference.ref = DateTimeTimezoneReference()
	return returnReference
}
public class DateTime{
	public var date : Date!
	public var hours : Double!
	public var minutes : Double!
	public var seconds : Double!
}
public class DateTimeReferenceClass{
	public var ref : DateTime!
}
func DateTimeCreateFunction() -> DateTimeReferenceClass{
	var returnReference = DateTimeReferenceClass()
	returnReference.ref = DateTime()
	return returnReference
}
public class DateTimeReference{
	public var dateTime : DateTime!
}
public class DateTimeReferenceReferenceClass{
	public var ref : DateTimeReference!
}
func DateTimeReferenceCreateFunction() -> DateTimeReferenceReferenceClass{
	var returnReference = DateTimeReferenceReferenceClass()
	returnReference.ref = DateTimeReference()
	return returnReference
}
public class FixedPoint30d{
	public var part1 : Double!
	public var part2 : Double!
	public var digitsBeforeDecimalPoint : Double!
	public var digitsAfterDecimalPoint : Double!
}
public class FixedPoint30dReferenceClass{
	public var ref : FixedPoint30d!
}
func FixedPoint30dCreateFunction() -> FixedPoint30dReferenceClass{
	var returnReference = FixedPoint30dReferenceClass()
	returnReference.ref = FixedPoint30d()
	return returnReference
}
public class FixedPoint15d{
	public var number : Double!
	public var digitsBeforeDecimalPoint : Double!
	public var digitsAfterDecimalPoint : Double!
}
public class FixedPoint15dReferenceClass{
	public var ref : FixedPoint15d!
}
func FixedPoint15dCreateFunction() -> FixedPoint15dReferenceClass{
	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = FixedPoint15d()
	return returnReference
}
public class DynamicArrayCharacters{
	public var array : [Character]!
	public var length : Double!
}
public class DynamicArrayCharactersReferenceClass{
	public var ref : DynamicArrayCharacters!
}
func DynamicArrayCharactersCreateFunction() -> DynamicArrayCharactersReferenceClass{
	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = DynamicArrayCharacters()
	return returnReference
}
public class LinkedListNodeStrings{
	public var end : Bool!
	public var value : [Character]!
	public var next : LinkedListNodeStrings!
}
public class LinkedListNodeStringsReferenceClass{
	public var ref : LinkedListNodeStrings!
}
func LinkedListNodeStringsCreateFunction() -> LinkedListNodeStringsReferenceClass{
	var returnReference = LinkedListNodeStringsReferenceClass()
	returnReference.ref = LinkedListNodeStrings()
	return returnReference
}
public class LinkedListStrings{
	public var first : LinkedListNodeStrings!
	public var last : LinkedListNodeStrings!
}
public class LinkedListStringsReferenceClass{
	public var ref : LinkedListStrings!
}
func LinkedListStringsCreateFunction() -> LinkedListStringsReferenceClass{
	var returnReference = LinkedListStringsReferenceClass()
	returnReference.ref = LinkedListStrings()
	return returnReference
}
public class LinkedListNodeNumbers{
	public var next : LinkedListNodeNumbers!
	public var end : Bool!
	public var value : Double!
}
public class LinkedListNodeNumbersReferenceClass{
	public var ref : LinkedListNodeNumbers!
}
func LinkedListNodeNumbersCreateFunction() -> LinkedListNodeNumbersReferenceClass{
	var returnReference = LinkedListNodeNumbersReferenceClass()
	returnReference.ref = LinkedListNodeNumbers()
	return returnReference
}
public class LinkedListNumbers{
	public var first : LinkedListNodeNumbers!
	public var last : LinkedListNodeNumbers!
}
public class LinkedListNumbersReferenceClass{
	public var ref : LinkedListNumbers!
}
func LinkedListNumbersCreateFunction() -> LinkedListNumbersReferenceClass{
	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = LinkedListNumbers()
	return returnReference
}
public class LinkedListCharacters{
	public var first : LinkedListNodeCharacters!
	public var last : LinkedListNodeCharacters!
}
public class LinkedListCharactersReferenceClass{
	public var ref : LinkedListCharacters!
}
func LinkedListCharactersCreateFunction() -> LinkedListCharactersReferenceClass{
	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = LinkedListCharacters()
	return returnReference
}
public class LinkedListNodeCharacters{
	public var end : Bool!
	public var value : Character!
	public var next : LinkedListNodeCharacters!
}
public class LinkedListNodeCharactersReferenceClass{
	public var ref : LinkedListNodeCharacters!
}
func LinkedListNodeCharactersCreateFunction() -> LinkedListNodeCharactersReferenceClass{
	var returnReference = LinkedListNodeCharactersReferenceClass()
	returnReference.ref = LinkedListNodeCharacters()
	return returnReference
}
public class DynamicArrayNumbers{
	public var array : [Double]!
	public var length : Double!
}
public class DynamicArrayNumbersReferenceClass{
	public var ref : DynamicArrayNumbers!
}
func DynamicArrayNumbersCreateFunction() -> DynamicArrayNumbersReferenceClass{
	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = DynamicArrayNumbers()
	return returnReference
}
public class Arrayx{
	public var array : [Data]!
	public var length : Double!
}
public class ArrayxReferenceClass{
	public var ref : Arrayx!
}
func ArrayxCreateFunction() -> ArrayxReferenceClass{
	var returnReference = ArrayxReferenceClass()
	returnReference.ref = Arrayx()
	return returnReference
}
public class Data{
	public var isStruture : Bool!
	public var isArray : Bool!
	public var isNumber : Bool!
	public var isString : Bool!
	public var isBoolean : Bool!
	public var structure : Structure!
	public var array : Arrayx!
	public var number : Double!
	public var booleanx : Bool!
	public var stringx : [Character]!
}
public class DataReferenceClass{
	public var ref : Data!
}
func DataCreateFunction() -> DataReferenceClass{
	var returnReference = DataReferenceClass()
	returnReference.ref = Data()
	return returnReference
}
public class DataReference{
	public var data : Data!
}
public class DataReferenceReferenceClass{
	public var ref : DataReference!
}
func DataReferenceCreateFunction() -> DataReferenceReferenceClass{
	var returnReference = DataReferenceReferenceClass()
	returnReference.ref = DataReference()
	return returnReference
}
public class Structure{
	public var keys : Arrayx!
	public var values : Arrayx!
}
public class StructureReferenceClass{
	public var ref : Structure!
}
func StructureCreateFunction() -> StructureReferenceClass{
	var returnReference = StructureReferenceClass()
	returnReference.ref = Structure()
	return returnReference
}
public class RGBA{
	public var r : Double!
	public var g : Double!
	public var b : Double!
	public var a : Double!
}
public class RGBAReferenceClass{
	public var ref : RGBA!
}
func RGBACreateFunction() -> RGBAReferenceClass{
	var returnReference = RGBAReferenceClass()
	returnReference.ref = RGBA()
	return returnReference
}
public class RGBABitmap{
	public var y : [RGBA]!
}
public class RGBABitmapReferenceClass{
	public var ref : RGBABitmap!
}
func RGBABitmapCreateFunction() -> RGBABitmapReferenceClass{
	var returnReference = RGBABitmapReferenceClass()
	returnReference.ref = RGBABitmap()
	return returnReference
}
public class RGBABitmapImage{
	public var x : [RGBABitmap]!
}
public class RGBABitmapImageReferenceClass{
	public var ref : RGBABitmapImage!
}
func RGBABitmapImageCreateFunction() -> RGBABitmapImageReferenceClass{
	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = RGBABitmapImage()
	return returnReference
}
public class Matrix{
	public var r : [MatrixRow]!
}
public class MatrixReferenceClass{
	public var ref : Matrix!
}
func MatrixCreateFunction() -> MatrixReferenceClass{
	var returnReference = MatrixReferenceClass()
	returnReference.ref = Matrix()
	return returnReference
}
public class MatrixArrayReference{
	public var matrices : [Matrix]!
}
public class MatrixArrayReferenceReferenceClass{
	public var ref : MatrixArrayReference!
}
func MatrixArrayReferenceCreateFunction() -> MatrixArrayReferenceReferenceClass{
	var returnReference = MatrixArrayReferenceReferenceClass()
	returnReference.ref = MatrixArrayReference()
	return returnReference
}
public class MatrixReference{
	public var matrix : Matrix!
}
public class MatrixReferenceReferenceClass{
	public var ref : MatrixReference!
}
func MatrixReferenceCreateFunction() -> MatrixReferenceReferenceClass{
	var returnReference = MatrixReferenceReferenceClass()
	returnReference.ref = MatrixReference()
	return returnReference
}
public class MatrixRow{
	public var c : [Double]!
}
public class MatrixRowReferenceClass{
	public var ref : MatrixRow!
}
func MatrixRowCreateFunction() -> MatrixRowReferenceClass{
	var returnReference = MatrixRowReferenceClass()
	returnReference.ref = MatrixRow()
	return returnReference
}
public class ComplexMatrix{
	public var r : [ComplexMatrixRow]!
}
public class ComplexMatrixReferenceClass{
	public var ref : ComplexMatrix!
}
func ComplexMatrixCreateFunction() -> ComplexMatrixReferenceClass{
	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = ComplexMatrix()
	return returnReference
}
public class ComplexMatrixArrayReference{
	public var matrices : [ComplexMatrix]!
}
public class ComplexMatrixArrayReferenceReferenceClass{
	public var ref : ComplexMatrixArrayReference!
}
func ComplexMatrixArrayReferenceCreateFunction() -> ComplexMatrixArrayReferenceReferenceClass{
	var returnReference = ComplexMatrixArrayReferenceReferenceClass()
	returnReference.ref = ComplexMatrixArrayReference()
	return returnReference
}
public class ComplexMatrixReference{
	public var matrix : ComplexMatrix!
}
public class ComplexMatrixReferenceReferenceClass{
	public var ref : ComplexMatrixReference!
}
func ComplexMatrixReferenceCreateFunction() -> ComplexMatrixReferenceReferenceClass{
	var returnReference = ComplexMatrixReferenceReferenceClass()
	returnReference.ref = ComplexMatrixReference()
	return returnReference
}
public class ComplexMatrixRow{
	public var c : [cComplexNumber]!
}
public class ComplexMatrixRowReferenceClass{
	public var ref : ComplexMatrixRow!
}
func ComplexMatrixRowCreateFunction() -> ComplexMatrixRowReferenceClass{
	var returnReference = ComplexMatrixRowReferenceClass()
	returnReference.ref = ComplexMatrixRow()
	return returnReference
}
public class LinearCongruentialGenerator{
	public var x : Double!
	public var a : Double!
	public var c : Double!
	public var m : Double!
}
public class LinearCongruentialGeneratorReferenceClass{
	public var ref : LinearCongruentialGenerator!
}
func LinearCongruentialGeneratorCreateFunction() -> LinearCongruentialGeneratorReferenceClass{
	var returnReference = LinearCongruentialGeneratorReferenceClass()
	returnReference.ref = LinearCongruentialGenerator()
	return returnReference
}
public class PseudorandomGenerator{
	public var lcg : LinearCongruentialGenerator!
}
public class PseudorandomGeneratorReferenceClass{
	public var ref : PseudorandomGenerator!
}
func PseudorandomGeneratorCreateFunction() -> PseudorandomGeneratorReferenceClass{
	var returnReference = PseudorandomGeneratorReferenceClass()
	returnReference.ref = PseudorandomGenerator()
	return returnReference
}
public class cComplexNumber{
	public var re : Double!
	public var im : Double!
}
public class cComplexNumberReferenceClass{
	public var ref : cComplexNumber!
}
func cComplexNumberCreateFunction() -> cComplexNumberReferenceClass{
	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = cComplexNumber()
	return returnReference
}
public class cComplexNumberArrayReference{
	public var complexNumbers : [cComplexNumber]!
}
public class cComplexNumberArrayReferenceReferenceClass{
	public var ref : cComplexNumberArrayReference!
}
func cComplexNumberArrayReferenceCreateFunction() -> cComplexNumberArrayReferenceReferenceClass{
	var returnReference = cComplexNumberArrayReferenceReferenceClass()
	returnReference.ref = cComplexNumberArrayReference()
	return returnReference
}
public class cComplexNumberReference{
	public var complexNumbers : cComplexNumber!
}
public class cComplexNumberReferenceReferenceClass{
	public var ref : cComplexNumberReference!
}
func cComplexNumberReferenceCreateFunction() -> cComplexNumberReferenceReferenceClass{
	var returnReference = cComplexNumberReferenceReferenceClass()
	returnReference.ref = cComplexNumberReference()
	return returnReference
}
public class cPolarComplexNumber{
	public var r : Double!
	public var phi : Double!
}
public class cPolarComplexNumberReferenceClass{
	public var ref : cPolarComplexNumber!
}
func cPolarComplexNumberCreateFunction() -> cPolarComplexNumberReferenceClass{
	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = cPolarComplexNumber()
	return returnReference
}
public class pComplexPolynomial{
	public var cs : [cComplexNumber]!
}
public class pComplexPolynomialReferenceClass{
	public var ref : pComplexPolynomial!
}
func pComplexPolynomialCreateFunction() -> pComplexPolynomialReferenceClass{
	var returnReference = pComplexPolynomialReferenceClass()
	returnReference.ref = pComplexPolynomial()
	return returnReference
}
func CreateLedger(_ decimals : Double) -> StructureReferenceClass{
	var decimals = decimals;
	var ledger : Structure
	var transactions : Arrayx

	ledger = CreateStructure().ref
	transactions = CreateArray().ref
	AddNumberToStruct(&ledger, &characterArray("decimals").ca, decimals)
	AddArrayToStruct(&ledger, &characterArray("transactions").ca, &transactions)

	var returnReference = StructureReferenceClass()
	returnReference.ref = ledger
	return returnReference
}


func CreateFixedPointForDynamicLedger(_ ledger : inout Structure) -> FixedPoint15dReferenceClass{
	var n : FixedPoint15d
	var d : Double

	d = GetNumberFromStruct(&ledger, &characterArray("decimals").ca)
	n = CreateFixedPoint15d(15.0 - d, d).ref

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = n
	return returnReference
}


func CreateFixedPointForStaticLedger(_ ledger : inout Ledger) -> FixedPoint15dReferenceClass{
	var n : FixedPoint15d
	var d : Double

	d = ledger.decimals
	n = CreateFixedPoint15d(15.0 - d, d).ref

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = n
	return returnReference
}


func CreateLine(_ account : inout [Character], _ debit : inout FixedPoint15d, _ credit : inout FixedPoint15d, _ description : inout [Character], _ date : inout Date) -> LineReferenceClass{
	var t : Line

	t = Line()

	t.account = arraysCopyString(&account)
	t.debit = Copy15d(&debit).ref
	t.credit = Copy15d(&credit).ref
	t.description = arraysCopyString(&description)
	t.date = CopyDate(&date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = t
	return returnReference
}


func AddTransactionToLedger(_ ledger : inout Arrayx, _ src : inout Line) -> Void{
	var dst : Structure

	dst = LineToStructure(&src).ref

	AddStructToArray(&ledger, &dst)
}


func AddTransactionsToLedger(_ ledger : inout Arrayx, _ ts : inout [Line]) -> Void{
	var dst : Structure
	var i : Double

	i = 0.0
	while(i < Double(ts.count)){
		dst = LineToStructure(&ts[Int(i)]).ref
		AddStructToArray(&ledger, &dst)
		i = i + 1.0
	}
}


func ValidateAndAddTransactionToLedger(_ ledger : inout Structure, _ ls : inout [Line]) -> Bool{
	var dst : Structure
	var i : Double
	var valid : Bool
	var transactions : Arrayx
	var lines : Arrayx

	transactions = GetArrayFromStruct(&ledger, &characterArray("transactions").ca).ref

	valid = ValidateTransaction(&ls, &ledger)

	if(valid){
		lines = CreateArray().ref

		i = 0.0
		while(i < Double(ls.count)){
			dst = LineToStructure(&ls[Int(i)]).ref
			AddStructToArray(&lines, &dst)
			i = i + 1.0
		}

		AddArrayToArray(&transactions, &lines)
	}

	return valid
}


func GetTransactionFromLedger(_ ledger : inout Structure, _ index : Double) -> LineReferenceClass{
	var index = index;
	var dst : Structure
	var t : Line
	var transactions : Arrayx
	var decimals : Double

	transactions = GetArrayFromStruct(&ledger, &characterArray("transactions").ca).ref
	decimals = GetNumberFromStruct(&ledger, &characterArray("decimals").ca)

	dst = ArrayIndexStruct(&transactions, index).ref

	t = LineFromStructure(&dst, &ledger).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = t
	return returnReference
}


func LineToStructure(_ src : inout Line) -> StructureReferenceClass{
	var dst : Structure
	var debitStr, creditStr, dateStr : [Character]

	dst = CreateStructure().ref

	debitStr = ToString15d(&src.debit)
	creditStr = ToString15d(&src.credit)
	dateStr = DateToStringISO8601(&src.date)

	AddStringToStruct(&dst, &characterArray("account").ca, &src.account)
	AddStringToStruct(&dst, &characterArray("debit").ca, &debitStr)
	AddStringToStruct(&dst, &characterArray("credit").ca, &creditStr)
	AddStringToStruct(&dst, &characterArray("date").ca, &dateStr)
	AddStringToStruct(&dst, &characterArray("description").ca, &src.description)

	var returnReference = StructureReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func LineFromStructure(_ src : inout Structure, _ ledger : inout Structure) -> LineReferenceClass{
	var dst : Line
	var account, debitStr, creditStr, dateStr, description : [Character]
	var debit, credit : FixedPoint15d
	var date : Date
	var debitNumber, creditNumber : Double

	account = GetStringFromStruct(&src, &characterArray("account").ca)
	debitStr = GetStringFromStruct(&src, &characterArray("debit").ca)
	creditStr = GetStringFromStruct(&src, &characterArray("credit").ca)
	dateStr = GetStringFromStruct(&src, &characterArray("date").ca)
	description = GetStringFromStruct(&src, &characterArray("description").ca)

	debitNumber = CreateNumberFromDecimalString(&debitStr)
	creditNumber = CreateNumberFromDecimalString(&creditStr)

	debit = CreateFixedPointForDynamicLedger(&ledger).ref
	credit = CreateFixedPointForDynamicLedger(&ledger).ref
	Assign15d(&debit, debitNumber)
	Assign15d(&credit, creditNumber)

	date = DateFromStringISO8601(&dateStr).ref

	dst = CreateLine(&account, &debit, &credit, &description, &date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func LedgerDynamicToStatic(_ src : inout Structure) -> LedgerReferenceClass{
	var dst : Ledger
	var ts, ls, i, j, decimals : Double
	var line : Structure
	var transactions, lines : Arrayx
	var sline : Line
	var t : Transaction

	dst = Ledger()

	transactions = GetArrayFromStruct(&src, &characterArray("transactions").ca).ref
	decimals = GetNumberFromStruct(&src, &characterArray("decimals").ca)
	ts = ArrayLength(&transactions)

	dst.decimals = decimals
	dst.transactions = Array(repeating:Transaction(), count: Int(ts))

	i = 0.0
	while(i < ts){
		lines = ArrayIndexArray(&transactions, i).ref
		ls = ArrayLength(&lines)

		t = Transaction()
		t.lines = Array(repeating:Line(), count: Int(ls))

		j = 0.0
		while(j < ls){
			line = ArrayIndexStruct(&lines, j).ref
			sline = LineFromStructure(&line, &src).ref
			t.lines[Int(j)] = sline
			j = j + 1.0
		}

		dst.transactions[Int(i)] = t
		i = i + 1.0
	}

	var returnReference = LedgerReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func ValidateTransaction(_ ts : inout [Line], _ ledger : inout Structure) -> Bool{
	var valid : Bool
	var creditSum, debitSum : FixedPoint15d
	var i, d, c : Double
	var t : Line
	var creditStr, debitStr : [Character]
	var date : Date

	valid = true

	if(Double(ts.count) > 0.0){
		date = ts[Int(0)].date

		creditSum = CreateFixedPointForDynamicLedger(&ledger).ref
		debitSum = CreateFixedPointForDynamicLedger(&ledger).ref

		i = 0.0
		while(i < Double(ts.count) && valid){
			t = ts[Int(i)]

			d = ToNumber15d(&t.debit)
			c = ToNumber15d(&t.credit)

			Add15d(&creditSum, &creditSum, &t.credit)
			Add15d(&debitSum, &debitSum, &t.debit)

			if(DateEquals(&date, &t.date) && (d == 0.0 || c == 0.0)){
			}else{
				valid = false
			}
			i = i + 1.0
		}

		if(valid){
			creditStr = ToString15d(&creditSum)
			debitStr = ToString15d(&creditSum)

			valid = arraysStringsEqual(&creditStr, &debitStr)
		}
	}

	return valid
}


func ValidateTransactions(_ ts : inout [Line], _ invalidIds : inout NumberArrayReference) -> Bool{
	var valid : Bool

	/* TODO*/
	valid = true

	return valid
}


func ComputeAccountBalance(_ ledger : inout Ledger, _ accountName : inout [Character], _ fromDate : inout Date, _ toDate : inout Date) -> AccountReferenceClass{
	var a : Account
	var i, j : Double
	var t : Transaction
	var ts : [Transaction]
	var l : Line

	ts = ledger.transactions

	a = Account()

	a.name = arraysCopyString(&accountName)
	a.endingBalance = CreateFixedPointForStaticLedger(&ledger).ref
	a.startingBalance = CreateFixedPointForStaticLedger(&ledger).ref
	a.from = CopyDate(&fromDate).ref
	a.to = CopyDate(&toDate).ref
	a.sumDebit = CreateFixedPointForStaticLedger(&ledger).ref
	a.sumCredit = CreateFixedPointForStaticLedger(&ledger).ref

	i = 0.0
	while(i < Double(ts.count)){
		t = ts[Int(i)]

		j = 0.0
		while(j < Double(t.lines.count)){
			l = t.lines[Int(j)]

			if(arraysStringsEqual(&l.account, &accountName)){

				if(DateLessThan(&l.date, &fromDate)){
					Add15d(&a.startingBalance, &a.startingBalance, &l.debit)
					Subtract15d(&a.startingBalance, &a.startingBalance, &l.credit)
				}else if(DateLessThan(&l.date, &toDate)){
					Add15d(&a.endingBalance, &a.endingBalance, &l.debit)
					Subtract15d(&a.endingBalance, &a.endingBalance, &l.credit)

					Add15d(&a.sumDebit, &a.sumDebit, &l.debit)
					Add15d(&a.sumCredit, &a.sumCredit, &l.credit)
				}
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	Add15d(&a.endingBalance, &a.endingBalance, &a.startingBalance)

	var returnReference = AccountReferenceClass()
	returnReference.ref = a
	return returnReference
}


func AccountToString(_ account : inout Account) -> [Character]{
	var ll : LinkedListCharacters
	var diff : FixedPoint15d

	ll = CreateLinkedListCharacter().ref

	diff = Copy15d(&account.endingBalance).ref
	Subtract15d(&diff, &diff, &account.startingBalance)

	LinkedListCharactersAddString(&ll, &account.name)
	LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.startingBalance, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(" -> ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.endingBalance, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&diff, 2.0, &characterArray(",").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(" (+").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.sumDebit, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(", -").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.sumCredit, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(")").ca)

	return LinkedListCharactersToArray(&ll)
}


func AddMonthlyAccruals(_ ledger : inout Structure, _ from : inout Date, _ to : inout Date, _ amount : Double, _ fromAccount : inout [Character], _ toAccount : inout [Character]) -> Void{
	var amount = amount;
	var i : Double
	var accountName, desc : [Character]
	var amounts : [Double]
	var transaction : [Line]
	var valid, success : Bool
	var date : Date
	var c, d : FixedPoint15d
	var message : StringReference

	message = StringReference()

	amounts = GetAccrualsWithDates(amount, &from, &to)

	date = CopyDate(&from).ref
	date.day = 1.0

	c = CreateFixedPointForDynamicLedger(&ledger).ref
	d = CreateFixedPointForDynamicLedger(&ledger).ref

	i = 0.0
	while(i < Double(amounts.count)){
		transaction = Array(repeating:Line(), count: Int(2))

		accountName = fromAccount
		Assign15d(&d, amounts[Int(i)])
		Assign15d(&c, 0.0)
		desc = characterArray("x").ca
		transaction[Int(0)] = CreateLine(&accountName, &d, &c, &desc, &date).ref

		accountName = toAccount
		Assign15d(&d, 0.0)
		Assign15d(&c, amounts[Int(i)])
		desc = characterArray("x").ca
		transaction[Int(1)] = CreateLine(&accountName, &d, &c, &desc, &date).ref

		valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)

		success = AddMonthsToDate(&date, 1.0, &message)
		i = i + 1.0
	}
}


func ComputeAccountBalancePrefixAccount(_ ledger : inout Ledger, _ accountNr : inout [Character], _ toDate : inout Date, _ debitBalance : Bool) -> FixedPoint15dReferenceClass{
	var debitBalance = debitBalance;
	var i, j : Double
	var t : Transaction
	var ts : [Transaction]
	var l : Line
	var balance : FixedPoint15d
	var prefixL : LinkedListCharacters
	var prefixed : [Character]

	prefixL = CreateLinkedListCharacter().ref
	LinkedListCharactersAddString(&prefixL, &accountNr)
	LinkedListCharactersAddString(&prefixL, &characterArray(".").ca)

	prefixed = LinkedListCharactersToArray(&prefixL)

	ts = ledger.transactions

	balance = CreateFixedPointForStaticLedger(&ledger).ref

	i = 0.0
	while(i < Double(ts.count)){
		t = ts[Int(i)]

		j = 0.0
		while(j < Double(t.lines.count)){
			l = t.lines[Int(j)]

			if(strStartsWith(&l.account, &prefixed) || arraysStringsEqual(&l.account, &accountNr)){
				if(DateLessThan(&l.date, &toDate) || DateEquals(&l.date, &toDate)){
					if(debitBalance){
						Add15d(&balance, &balance, &l.debit)
						Subtract15d(&balance, &balance, &l.credit)
					}else{
						Add15d(&balance, &balance, &l.credit)
						Subtract15d(&balance, &balance, &l.debit)
					}
				}
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = balance
	return returnReference
}


func GetIFRSAccountPlan() -> AccountPlanReferenceClass{
	var accountPlanString : [Character]
	var validRef : BooleanReference
	var ll : LinkedListCharacters

	ll = CreateLinkedListCharacter().ref

	/* https://www.ifrs-gaap.com/ifrs-chart-accounts*/
	validRef = CreateBooleanReference(false).ref

	LinkedListCharactersAddString(&ll, &characterArray("1\tAssets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1\tProperty, plant and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.1\tLand and land improvements\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.2\tBuildings, structures and improvements\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.3\tMachinery and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.4\tFixtures and fittings\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.5\tRight of use assets (classified as PP&E)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.6\tAdditional property, plant and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.7\tConstruction in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2\tInvestment property\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2.1\tCompleted\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2.2\tUnder construction or development\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.3\tGoodwill\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4\tIntangible assets excluding goodwill\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.1\tIntellectual property\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.2\tComputer software\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.3\tTrade and distribution assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.4\tContracts and rights\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.5\tRight of use assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.6\tCrypto assets (classified as intangible)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.7\tAdditional intangible assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.8\tAcquisition in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5\tFinancial assets and investments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.1\tNon-derivative financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.2\tDerivative financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.3\tAdditional financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.4\tCrypto assets (classified as financial assets)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6\tInventories\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.1\tMerchandise\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.2\tRaw materials and production supplies\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.3\tWork in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.4\tFinished goods\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.5\tOther inventories\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7\tPrepayments and accrued income\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.1\tPrepayments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.2\tAccrued income\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.3\tService provider work in process (not classified as inventory)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.4\tAdditional assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8\tReceivables and contracts\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.1\tLoans and receivables\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.2\tContracts with customers\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.3\tNontrade and other receivables\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9\tTax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.1\tTax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.2\tDeferred tax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.3\tOther tax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1\tAgricultural biological assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.1\tBearer plants\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.2\tAnimals\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.3\tOther agricultural assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11\tCash and cash equivalents\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.1\tCash\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.2\tCash equivalents\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.3\tRestricted cash and financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2\tEquity\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1\tTotal equity attributable to owners of parent\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.1\tIssued capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.2\tAdditional item paid-in capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.3\tPartner\'s capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.4\tMember\'s equity\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.5\tOther equity interest\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2\tRetained earnings\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.3\tIn suspense\tZero\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3\tAccumulated other comprehensive income\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3.2\tMiscellaneous equity\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.4\tOwners equity (non-shareholder)\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.5\tNon-controlling interests\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3\tLiabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1\tTrade and other payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.1\tTrade payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.2\tDividend payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.3\tInterest payable\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.4\tOther payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2\tProvisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.1\tCustomer related provisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.2\tLitigation and regulatory\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.3\tAdditional provisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3\tOther financial liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.1\tNotes payable\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.2\tLoans received\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.3\tBonds (debentures)\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.4\tOther debts and borrowings\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.5\tLease obligations\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.6\tDerivative financial liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.1\tAccruals\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.2\tDeferred income and refund liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.3\tAccrued taxes other than payroll\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.4\tAdditional liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4\tRevenue\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1\tRecognized point of time\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1.1\tGoods\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1.2\tServices\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2\tRecognized over time\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2.1\tProducts and projects\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2.2\tServices\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3\tAdjustments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.1\tVariable consideration\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.2\tConsideration paid payable to customers\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.3\tOther adjustments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5\tExpenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1\tExpenses (classified by nature)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.1\tMaterial and merchandise\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.2\tEmployee benefits expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.3\tServices expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.4\tRent, depreciation, amortization and depletion\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.6\tOther work performed by entity and capitalized\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2\tExpenses (classified by function)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2.1\tCost of sales\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2.2\tSelling, general and administrative expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6\tOther non-operating income and expenses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1\tOther revenue and expenses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1.1\tOther revenue\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1.2\tOther expenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.2\tGains and losses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.3\tTaxes other than income and payroll and fees\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.4\tTax income (expense)\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7\tIntercompany and related party accounts\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1\tIntercompany and related party assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.1\tIntercompany balances eliminated in consolidation\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.2\tRelated party balances reported or disclosed\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.3\tIntercompany investments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2\tIntercompany and related party liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2.2\tRelated party balances reported or disclosed\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3\tIntercompany and related party income and expense\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.1\tIntercompany and related party income\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.2\tIntercompany and related party expenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n").ca)

	accountPlanString = LinkedListCharactersToArray(&ll)

	FreeLinkedListCharacter(&ll)

	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = ParseAccountPlanString(&accountPlanString, &validRef).ref
	return returnReference
}


func ParseAccountPlanString(_ accountPlanString : inout [Character], _ valid : inout BooleanReference) -> AccountPlanReferenceClass{
	var ap : AccountPlan
	var i : Double
	var line : [Character]
	var lines, parts : [StringReference]
	var ad : AccountDefinition

	ap = AccountPlan()

	accountPlanString = strTrim(&accountPlanString)
	lines = strSplitByCharacter(&accountPlanString, "\n")

	ap.accountDefinitions = Array(repeating:AccountDefinition(), count: Int(Double(lines.count)))

	i = 0.0
	while(i < Double(lines.count)){
		line = lines[Int(i)].stringx
		/*System.out.println(line);*/
		parts = strSplitByCharacter(&line, "\t")

		ad = AccountDefinition()

		ad.accountName = parts[Int(1)].stringx
		ad.number = parts[Int(0)].stringx
		if(arraysStringsEqual(&parts[Int(2)].stringx, &characterArray("(Cr)").ca)){
			ad.debitBalance = false
		}else{
			ad.debitBalance = true
		}
		ad.role = characterArray("").ca
		if(arraysStringsEqual(&ad.number, &characterArray("1").ca)){
			ad.role = characterArray("Assets").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("2").ca)){
			ad.role = characterArray("Equities").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("3").ca)){
			ad.role = characterArray("Liabilities").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("4").ca)){
			ad.role = characterArray("Revenue").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("5").ca)){
			ad.role = characterArray("Expenses").ca
		}

		ap.accountDefinitions[Int(i)] = ad
		i = i + 1.0
	}

	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = ap
	return returnReference
}


func ComputeAccountBalances(_ sledger : inout Ledger, _ depth : Double, _ date : inout Date, _ balanceSheet : inout DataReference) -> Bool{
	var depth = depth;
	var accountPlan : AccountPlan
	var assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance : FixedPoint15d
	var balanceStr : [Character]
	var assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef : AccountDefinition
	var success, isBalanced : Bool
	var i : Double
	var parts : [StringReference]
	var foundRef : BooleanReference
	var accounts : Arrayx
	var account : Structure
	var dateStr : [Character]

	balanceSheet.data = CreateNewStructData().ref
	success = true

	foundRef = CreateBooleanReference(false).ref

	accountPlan = sledger.accountPlan

	assetsDef = FindAccountWithRole(&accountPlan, &characterArray("Assets").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	liabilitiesDef = FindAccountWithRole(&accountPlan, &characterArray("Liabilities").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	equitiesDef = FindAccountWithRole(&accountPlan, &characterArray("Equities").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	revenueDef = FindAccountWithRole(&accountPlan, &characterArray("Revenue").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	expensesDef = FindAccountWithRole(&accountPlan, &characterArray("Expenses").ca, &foundRef).ref
	success = success && foundRef.booleanValue

	if(success){
		assetsBalance = ComputeAccountBalancePrefixAccount(&sledger, &assetsDef.number, &date, assetsDef.debitBalance).ref
		liabilitiesBalance = ComputeAccountBalancePrefixAccount(&sledger, &liabilitiesDef.number, &date, liabilitiesDef.debitBalance).ref

		/* TODO: This must be for a period*/
		revenueBalanace = ComputeAccountBalancePrefixAccount(&sledger, &revenueDef.number, &date, revenueDef.debitBalance).ref
		expensesBalance = ComputeAccountBalancePrefixAccount(&sledger, &expensesDef.number, &date, expensesDef.debitBalance).ref
		resultBalance = CreateFixedPointForStaticLedger(&sledger).ref
		Subtract15d(&resultBalance, &revenueBalanace, &expensesBalance)
		balanceStr = FormatToStringWithSymbols15d(&resultBalance, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("result").ca, &balanceStr)

		equitiesBalance = ComputeAccountBalancePrefixAccount(&sledger, &equitiesDef.number, &date, equitiesDef.debitBalance).ref
		Add15d(&equitiesBalance, &equitiesBalance, &resultBalance)

		/* Compute accounts*/
		accounts = CreateArray().ref

		i = 0.0
		while(i < Double(accountPlan.accountDefinitions.count)){
			accountDef = accountPlan.accountDefinitions[Int(i)]

			parts = strSplitByCharacter(&accountDef.number, ".")

			if(Double(parts.count) <= depth + 1.0){
				account = CreateStructure().ref

				balance = ComputeAccountBalancePrefixAccount(&sledger, &accountDef.number, &date, accountDef.debitBalance).ref

				balanceStr = FormatToStringWithSymbols15d(&balance, 2.0, &characterArray("").ca, &characterArray(".").ca)

				AddStringToStruct(&account, &characterArray("number").ca, &accountDef.number)
				AddStringToStruct(&account, &characterArray("name").ca, &accountDef.accountName)
				AddStringToStruct(&account, &characterArray("balance").ca, &balanceStr)
				AddNumberToStruct(&account, &characterArray("depth").ca, Double(parts.count) - 1.0)

				AddStructToArray(&accounts, &account)
			}
			i = i + 1.0
		}

		AddArrayToStruct(&balanceSheet.data.structure, &characterArray("accounts").ca, &accounts)

		/* End conclusion*/
		balanceStr = FormatToStringWithSymbols15d(&assetsBalance, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("assets").ca, &balanceStr)

		sum = CreateFixedPointForStaticLedger(&sledger).ref
		Add15d(&sum, &liabilitiesBalance, &equitiesBalance)
		balanceStr = FormatToStringWithSymbols15d(&sum, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("liabilitiesAndEquity").ca, &balanceStr)

		isBalanced = Equals15d(&sum, &assetsBalance)
		AddBooleanToStruct(&balanceSheet.data.structure, &characterArray("balanced").ca, isBalanced)

		dateStr = DateToStringISO8601(&date)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("date").ca, &dateStr)
	}

	return success
}


func AccountBalancesToString(_ balanceSheet : inout Structure) -> [Character]{
	var ll : LinkedListCharacters
	var balanceStr : [Character]
	var isBalanced : Bool
	var i, j, depth : Double
	var accounts : Arrayx
	var account : Structure
	var accountNumber, accountName : [Character]

	ll = CreateLinkedListCharacter().ref

	/* Print accounts*/
	accounts = GetArrayFromStruct(&balanceSheet, &characterArray("accounts").ca).ref

	i = 0.0
	while(i < ArrayLength(&accounts)){
		account = ArrayIndexStruct(&accounts, i).ref

		accountNumber = GetStringFromStruct(&account, &characterArray("number").ca)
		accountName = GetStringFromStruct(&account, &characterArray("name").ca)
		balanceStr = GetStringFromStruct(&account, &characterArray("balance").ca)
		depth = GetNumberFromStruct(&account, &characterArray("depth").ca)

		j = 0.0
		while(j < depth){
			LinkedListCharactersAddString(&ll, &characterArray("  ").ca)
			j = j + 1.0
		}

		LinkedListCharactersAddString(&ll, &accountNumber)
		LinkedListCharactersAddString(&ll, &characterArray(". ").ca)
		LinkedListCharactersAddString(&ll, &accountName)
		LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
		LinkedListCharactersAddString(&ll, &balanceStr)
		LinkedListCharactersAddString(&ll, &characterArray("\n").ca)
		i = i + 1.0
	}

	/* End conclusion*/
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Result: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("result").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Assets: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("assets").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Liabilities + Equities: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("liabilitiesAndEquity").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	isBalanced = GetBooleanFromStruct(&balanceSheet, &characterArray("balanced").ca)
	LinkedListCharactersAddString(&ll, &characterArray("Balance: ").ca)
	if(isBalanced){
		LinkedListCharactersAddString(&ll, &characterArray("true").ca)
	}else{
		LinkedListCharactersAddString(&ll, &characterArray("false").ca)
	}
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	return LinkedListCharactersToArray(&ll)
}


func FindAccountWithRole(_ accountPlan : inout AccountPlan, _ role : inout [Character], _ foundRef : inout BooleanReference) -> AccountDefinitionReferenceClass{
	var i : Double
	var ad : AccountDefinition
	var done : Bool

	ad = AccountDefinition()

	done = false
	i = 0.0
	while(i < Double(accountPlan.accountDefinitions.count) && !done){
		ad = accountPlan.accountDefinitions[Int(i)]
		if(arraysStringsEqual(&ad.role, &role)){
			done = true
		}
		i = i + 1.0
	}

	foundRef.booleanValue = done

	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = ad
	return returnReference
}


func CreateAccountDefinition(_ name : inout [Character], _ number : inout [Character], _ role : inout [Character], _ debitBalance : Bool) -> AccountDefinitionReferenceClass{
	var debitBalance = debitBalance;
	var def : AccountDefinition

	def = AccountDefinition()
	def.accountName = name
	def.number = number
	def.role = role
	def.debitBalance = debitBalance

	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = def
	return returnReference
}


func ComputeBalanceDiffs(_ sledger : inout Ledger, _ balances : inout Arrayx) -> Void{
	var i, j : Double
	var balance, first, balance1, balance2 : Structure
	var account1, account2 : Structure
	var b1, b2, diffStr : [Character]
	var f1, f2, diff : FixedPoint15d
	var accountsO, accounts1, accounts2 : Arrayx

	first = ArrayIndexStruct(&balances, 0.0).ref
	accountsO = GetArrayFromStruct(&first, &characterArray("accounts").ca).ref

	j = 0.0
	while(j < ArrayLength(&accountsO)){
		i = 1.0
		while(i < ArrayLength(&balances)){
			balance1 = ArrayIndexStruct(&balances, i - 1.0).ref
			balance2 = ArrayIndexStruct(&balances, i).ref
			accounts1 = GetArrayFromStruct(&balance1, &characterArray("accounts").ca).ref
			accounts2 = GetArrayFromStruct(&balance2, &characterArray("accounts").ca).ref

			account1 = ArrayIndexStruct(&accounts1, j).ref
			account2 = ArrayIndexStruct(&accounts2, j).ref

			b1 = GetStringFromStruct(&account1, &characterArray("balance").ca)
			b2 = GetStringFromStruct(&account2, &characterArray("balance").ca)

			f1 = CreateFixedPointForStaticLedger(&sledger).ref
			f2 = CreateFixedPointForStaticLedger(&sledger).ref
			diff = CreateFixedPointForStaticLedger(&sledger).ref

			Assign15d(&f1, CreateNumberFromDecimalString(&b1))
			Assign15d(&f2, CreateNumberFromDecimalString(&b2))

			Subtract15d(&diff, &f2, &f1)

			diffStr = FormatToStringWithSymbols15d(&diff, sledger.decimals, &characterArray("").ca, &characterArray(".").ca)

			/*System.out.println(diffStr);*/
			if(i == 1.0){
				AddStringToStruct(&account1, &characterArray("change").ca, &characterArray("0.00").ca)
			}
			AddStringToStruct(&account2, &characterArray("change").ca, &diffStr)
			i = i + 1.0
		}
		j = j + 1.0
	}

	i = 1.0
	while(i < ArrayLength(&balances)){
		balance1 = ArrayIndexStruct(&balances, i - 1.0).ref
		balance2 = ArrayIndexStruct(&balances, i).ref
		b1 = GetStringFromStruct(&balance1, &characterArray("result").ca)
		b2 = GetStringFromStruct(&balance2, &characterArray("result").ca)

		f1 = CreateFixedPointForStaticLedger(&sledger).ref
		f2 = CreateFixedPointForStaticLedger(&sledger).ref
		diff = CreateFixedPointForStaticLedger(&sledger).ref

		Assign15d(&f1, CreateNumberFromDecimalString(&b1))
		Assign15d(&f2, CreateNumberFromDecimalString(&b2))

		Subtract15d(&diff, &f2, &f1)

		diffStr = FormatToStringWithSymbols15d(&diff, sledger.decimals, &characterArray("").ca, &characterArray(".").ca)

		/*System.out.println(diffStr);*/
		if(i == 1.0){
			AddStringToStruct(&balance1, &characterArray("rchange").ca, &characterArray("0.00").ca)
		}
		AddStringToStruct(&balance2, &characterArray("rchange").ca, &diffStr)
		i = i + 1.0
	}
}


func BalancesArrayToHTML(_ balances : inout Arrayx, _ includeBalance : Bool, _ includeDiff : Bool) -> [Character]{
	var includeBalance = includeBalance;
	var includeDiff = includeDiff;
	var ll : LinkedListCharacters
	var i, j : Double
	var balance, first : Structure
	var dateStr, name, number, balanceStr, changeStr : [Character]
	var account : Structure
	var accounts : Arrayx

	ll = CreateLinkedListCharacter().ref

	LinkedListCharactersAddString(&ll, &characterArray("<html>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<body>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<table>").ca)

	/* Headers*/
	LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	i = 0.0
	while(i < ArrayLength(&balances)){
		balance = ArrayIndexStruct(&balances, i).ref
		dateStr = GetStringFromStruct(&balance, &characterArray("date").ca)
		dateStr = strSubstring(&dateStr, 0.0, 7.0)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &dateStr)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
		i = i + 1.0
	}

	LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)

	/* Each account*/
	first = ArrayIndexStruct(&balances, 0.0).ref
	accounts = GetArrayFromStruct(&first, &characterArray("accounts").ca).ref
	j = 0.0
	while(j < ArrayLength(&accounts)){
		LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

		account = ArrayIndexStruct(&accounts, j).ref
		name = GetStringFromStruct(&account, &characterArray("name").ca)
		number = GetStringFromStruct(&account, &characterArray("number").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &number)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &name)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

		i = 0.0
		while(i < ArrayLength(&balances)){
			balance = ArrayIndexStruct(&balances, i).ref
			accounts = GetArrayFromStruct(&balance, &characterArray("accounts").ca).ref
			account = ArrayIndexStruct(&accounts, j).ref
			balanceStr = GetStringFromStruct(&account, &characterArray("balance").ca)
			changeStr = GetStringFromStruct(&account, &characterArray("change").ca)

			LinkedListCharactersAddString(&ll, &characterArray("<td style=\"text-align: right;\">").ca)

			if(includeBalance && includeDiff){
				LinkedListCharactersAddString(&ll, &balanceStr)
				LinkedListCharactersAddString(&ll, &characterArray("<br><small style=\"color: grey\">").ca)
				LinkedListCharactersAddString(&ll, &changeStr)
				LinkedListCharactersAddString(&ll, &characterArray("</small>").ca)
			}else if(includeBalance){
				LinkedListCharactersAddString(&ll, &balanceStr)
			}else if(includeDiff){
				LinkedListCharactersAddString(&ll, &changeStr)
			}

			LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
			i = i + 1.0
		}

		LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)
		j = j + 1.0
	}

	/* Result*/
	LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("Result").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	i = 0.0
	while(i < ArrayLength(&balances)){
		balance = ArrayIndexStruct(&balances, i).ref
		balanceStr = GetStringFromStruct(&balance, &characterArray("result").ca)
		changeStr = GetStringFromStruct(&balance, &characterArray("rchange").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td style=\"text-align: right;\">").ca)

		if(includeBalance && includeDiff){
			LinkedListCharactersAddString(&ll, &balanceStr)
			LinkedListCharactersAddString(&ll, &characterArray("<br><small style=\"color: grey\">").ca)
			LinkedListCharactersAddString(&ll, &changeStr)
			LinkedListCharactersAddString(&ll, &characterArray("</small>").ca)
		}else if(includeBalance){
			LinkedListCharactersAddString(&ll, &balanceStr)
		}else if(includeDiff){
			LinkedListCharactersAddString(&ll, &changeStr)
		}

		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
		i = i + 1.0
	}

	LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)

	/* Footer*/
	LinkedListCharactersAddString(&ll, &characterArray("</table>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</body>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</html>").ca)

	return LinkedListCharactersToArray(&ll)
}


func CreateLineFromScript(_ ledger : inout Structure, _ script : inout [Character], _ date : inout Date) -> LineReferenceClass{
	var parts : [StringReference]
	var c, d : FixedPoint15d
	var line : Line
	var i, n : Double

	c = CreateFixedPointForDynamicLedger(&ledger).ref
	d = CreateFixedPointForDynamicLedger(&ledger).ref

	parts = strSplitByCharacter(&script, ",")

	i = 0.0
	while(i < Double(parts.count)){
		parts[Int(i)].stringx = strTrim(&parts[Int(i)].stringx)
		i = i + 1.0
	}

	line = Line()

	n = CreateNumberFromDecimalString(&parts[Int(2)].stringx)

	line.date = date
	if(arraysStringsEqual(&parts[Int(0)].stringx, &characterArray("Debit").ca)){
		Assign15d(&d, n)
		Assign15d(&c, 0.0)
	}else if(arraysStringsEqual(&parts[Int(0)].stringx, &characterArray("Credit").ca)){
		Assign15d(&d, 0.0)
		Assign15d(&c, n)
	}

	line = CreateLine(&parts[Int(1)].stringx, &d, &c, &parts[Int(3)].stringx, &date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = line
	return returnReference
}


func LuhnCheck(_ number : inout [Character], _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var numberReference : StringReference
	var checkDigitReference : CharacterReference
	var numberString : [Character]
	var digitReference : NumberReference

	numberReference = StringReference()
	checkDigitReference = CharacterReference()
	numberString = Array(repeating:Character(" "), count: Int(1))
	digitReference = NumberReference()

	isValid = arraysCopyStringRange(&number, 0.0, Double(number.count) - 1.0, &numberReference)
	if(isValid){
		isValid = LuhnComputeCheckDigit(&numberReference.stringx, &checkDigitReference, &errorMessage)
		if(isValid){
			if(checkDigitReference.characterValue == number[Int(Double(number.count) - 1.0)]){
			}else{
				numberString[Int(0)] = number[Int(Double(number.count) - 1.0)]
				isValid = CreateNumberFromDecimalStringWithCheck(&numberString, &digitReference, &errorMessage)
				if(isValid){
					errorMessage.stringx = characterArray("Check digit wrong.").ca
				}else{
					errorMessage.stringx = characterArray("Check symbol not a digit.").ca
				}
				isValid = false
			}
		}
	}else{
		errorMessage.stringx = characterArray("Number is too short: must be at least one digit.").ca
	}

	return isValid
}


func LuhnComputeCheckDigit(_ number : inout [Character], _ checkDigitReference : inout CharacterReference, _ errorMessage : inout StringReference) -> Bool{
	var sum, n, i, check : Double
	var alternate, isValid : Bool
	var numberReference : NumberReference
	var numberString : [Character]

	sum = 0.0
	alternate = true
	numberString = Array(repeating:Character(" "), count: Int(1))
	numberReference = NumberReference()
	isValid = true

	i = Double(number.count) - 1.0
	while(i >= 0.0 && isValid){
		numberString[Int(0)] = number[Int(i)]
		isValid = CreateNumberFromDecimalStringWithCheck(&numberString, &numberReference, &errorMessage)
		if(isValid){
			n = numberReference.numberValue
			if(alternate){
				n = n*2.0
				if(n > 9.0){
					n = (n.truncatingRemainder(dividingBy:10.0)) + 1.0
				}
			}
			sum = sum + n
			alternate = !alternate
		}else{
			errorMessage.stringx = characterArray("Invalid digit in number string.").ca
		}
		i = i - 1.0
	}

	if(isValid){
		check = sum.truncatingRemainder(dividingBy:10.0)

		if(check != 0.0){
			check = 10.0 - check
		}

		GetSingleDigitCharacterFromNumberWithCheck(check, 10.0, &checkDigitReference)
	}

	return isValid
}


func LuhnExtendWithCheckDigit(_ number : inout [Character], _ extended : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var i : Double
	var checkDigitReference : CharacterReference

	checkDigitReference = CharacterReference()
	isValid = LuhnComputeCheckDigit(&number, &checkDigitReference, &errorMessage)

	if(isValid){
		extended.stringx = Array(repeating:Character(" "), count: Int(Double(number.count) + 1.0))
		i = 0.0
		while(i < Double(number.count)){
			extended.stringx[Int(i)] = number[Int(i)]
			i = i + 1.0
		}
		extended.stringx[Int(i)] = checkDigitReference.characterValue
	}

	return isValid
}


func ISINCheck(_ isin : inout [Character], _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var numberReference : StringReference
	var checkDigitReference : CharacterReference
	var numberString : [Character]
	var digitReference : NumberReference

	numberReference = StringReference()
	checkDigitReference = CharacterReference()
	numberString = Array(repeating:Character(" "), count: Int(1))
	digitReference = NumberReference()

	if(Double(isin.count) == 12.0){
		arraysCopyStringRange(&isin, 0.0, Double(isin.count) - 1.0, &numberReference)

		isValid = ISINComputeCheckDigit(&numberReference.stringx, &checkDigitReference, &errorMessage)
		if(isValid){
			if(checkDigitReference.characterValue == isin[Int(Double(isin.count) - 1.0)]){
			}else{
				numberString[Int(0)] = isin[Int(Double(isin.count) - 1.0)]
				isValid = CreateNumberFromDecimalStringWithCheck(&numberString, &digitReference, &errorMessage)
				if(isValid){
					errorMessage.stringx = characterArray("Check digit wrong.").ca
				}else{
					errorMessage.stringx = characterArray("Check symbol not a digit.").ca
				}
				isValid = false
			}
		}
	}else{
		isValid = false
		errorMessage.stringx = characterArray("ISIN must be 12 alpha-numeric characters.").ca
	}

	return isValid
}


func ISINComputeCheckDigit(_ isin : inout [Character], _ checkDigitReference : inout CharacterReference, _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var isinNumericReference : StringReference

	isinNumericReference = StringReference()

	if(Double(isin.count) == 11.0){
		isValid = ISINToNumericCode(&isin, &isinNumericReference, &errorMessage)

		if(isValid){
			LuhnComputeCheckDigit(&isinNumericReference.stringx, &checkDigitReference, &errorMessage)
		}
	}else{
		isValid = false
		errorMessage.stringx = characterArray("ISIN must be 11 digits before the checksum digit to be calculated.").ca
	}

	return isValid
}


func ISINExtendWithCheckDigit(_ isin : inout [Character], _ extended : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var i : Double
	var checkDigitReference : CharacterReference

	checkDigitReference = CharacterReference()
	isValid = ISINComputeCheckDigit(&isin, &checkDigitReference, &errorMessage)

	if(isValid){
		extended.stringx = Array(repeating:Character(" "), count: Int(Double(isin.count) + 1.0))
		i = 0.0
		while(i < Double(isin.count)){
			extended.stringx[Int(i)] = isin[Int(i)]
			i = i + 1.0
		}
		extended.stringx[Int(i)] = checkDigitReference.characterValue
	}

	return isValid
}


func ISINToNumericCode(_ isin : inout [Character], _ isinNumericReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var isValid : Bool
	var length, i, pos : Double
	var code : StringReference

	isValid = true
	code = StringReference()

	length = 0.0

	i = 0.0
	while(i < Double(isin.count) && isValid){
		if(cIsLetter(isin[Int(i)])){
			length = length + 2.0
		}else if(cIsNumber(isin[Int(i)])){
			length = length + 1.0
		}else{
			isValid = false
			errorMessage.stringx = characterArray("ISIN can only contain alpha-numeric characters.").ca
		}
		i = i + 1.0
	}

	if(isValid){
		isinNumericReference.stringx = Array(repeating:Character(" "), count: Int(length))

		pos = 0.0

		i = 0.0
		while(i < Double(isin.count)){
			ISINSymbolToCode(isin[Int(i)], &code, &errorMessage)

			isinNumericReference.stringx[Int(pos)] = code.stringx[Int(0)]
			pos = pos + 1.0
			if(Double(code.stringx.count) == 2.0){
				isinNumericReference.stringx[Int(pos)] = code.stringx[Int(1)]
				pos = pos + 1.0
			}
			i = i + 1.0
		}
	}

	return isValid
}


func ISINSymbolToCode(_ c : Character, _ stringReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var c = c;
	var isValid : Bool

	if(cIsLetter(c) && cIsUpperCase(c)){
		if(c == "A"){
			stringReference.stringx = characterArray("10").ca
		}else if(c == "B"){
			stringReference.stringx = characterArray("11").ca
		}else if(c == "C"){
			stringReference.stringx = characterArray("12").ca
		}else if(c == "D"){
			stringReference.stringx = characterArray("13").ca
		}else if(c == "E"){
			stringReference.stringx = characterArray("14").ca
		}else if(c == "F"){
			stringReference.stringx = characterArray("15").ca
		}else if(c == "G"){
			stringReference.stringx = characterArray("16").ca
		}else if(c == "H"){
			stringReference.stringx = characterArray("17").ca
		}else if(c == "I"){
			stringReference.stringx = characterArray("18").ca
		}else if(c == "J"){
			stringReference.stringx = characterArray("19").ca
		}else if(c == "K"){
			stringReference.stringx = characterArray("20").ca
		}else if(c == "L"){
			stringReference.stringx = characterArray("21").ca
		}else if(c == "M"){
			stringReference.stringx = characterArray("22").ca
		}else if(c == "N"){
			stringReference.stringx = characterArray("23").ca
		}else if(c == "O"){
			stringReference.stringx = characterArray("24").ca
		}else if(c == "P"){
			stringReference.stringx = characterArray("25").ca
		}else if(c == "Q"){
			stringReference.stringx = characterArray("26").ca
		}else if(c == "R"){
			stringReference.stringx = characterArray("27").ca
		}else if(c == "S"){
			stringReference.stringx = characterArray("28").ca
		}else if(c == "T"){
			stringReference.stringx = characterArray("29").ca
		}else if(c == "U"){
			stringReference.stringx = characterArray("30").ca
		}else if(c == "V"){
			stringReference.stringx = characterArray("31").ca
		}else if(c == "W"){
			stringReference.stringx = characterArray("32").ca
		}else if(c == "X"){
			stringReference.stringx = characterArray("33").ca
		}else if(c == "Y"){
			stringReference.stringx = characterArray("34").ca
		}else if(c == "Z"){
			stringReference.stringx = characterArray("35").ca
		}

		isValid = true
	}else if(cIsNumber(c)){
		if(c == "0"){
			stringReference.stringx = characterArray("0").ca
		}else if(c == "1"){
			stringReference.stringx = characterArray("1").ca
		}else if(c == "2"){
			stringReference.stringx = characterArray("2").ca
		}else if(c == "3"){
			stringReference.stringx = characterArray("3").ca
		}else if(c == "4"){
			stringReference.stringx = characterArray("4").ca
		}else if(c == "5"){
			stringReference.stringx = characterArray("5").ca
		}else if(c == "6"){
			stringReference.stringx = characterArray("6").ca
		}else if(c == "7"){
			stringReference.stringx = characterArray("7").ca
		}else if(c == "8"){
			stringReference.stringx = characterArray("8").ca
		}else if(c == "9"){
			stringReference.stringx = characterArray("9").ca
		}

		isValid = true
	}else{
		isValid = false
		errorMessage.stringx = characterArray("Character is not an ISIN alpha-character.").ca
	}

	return isValid
}


func GenerateBarcodeEAN13(_ code : inout [Character], _ widthInMm : Double, _ heightInMm : Double, _ pixelsPerMm : Double) -> RGBABitmapImageReferenceClass{
	var widthInMm = widthInMm;
	var heightInMm = heightInMm;
	var pixelsPerMm = pixelsPerMm;
	var w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone : Double
	var charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100 : Double
	var c, type, character : Character
	var image, uninterpolatedBarcode, barcode : RGBABitmapImage
	var widths, group1Pattern, symbolWidths : [Character]
	var counterReference : NumberReference
	var characterReference : CharacterReference

	h = Roundx(heightInMm*pixelsPerMm)
	w = Roundx(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, &GetWhite().ref).ref

	zoom100 = (11.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 7.0)*0.33

	zoom = widthInMm/zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0/37.0
	textQuietZone = textheight*5.0/100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = floor(moduleWidthPixels)
	leftQuietZoneWholePixels = 11.0*moduleWidthWholePixels
	leftQuietZonePixels = 11.0*moduleWidthPixels
	group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*6.0 + 4.0)*moduleWidthPixels
	betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, &GetWhite().ref).ref

	counterReference = CreateNumberReference(leftQuietZoneWholePixels).ref

	group1Pattern = GetEAN13Group1Pattern(code[Int(0)])

	/* Start symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	i = 1.0
	while(i < Double(code.count)){
		c = code[Int(i)]
		if(i <= 6.0){
			type = group1Pattern[Int(i - 1.0)]
			if(type == "L"){
				widths = GetUPCLCodeWidths(c)
			}else{
				widths = GetUPCGCodeWidths(c)
			}
		}else{
			widths = GetUPCRCodeWidths(c)
		}
		DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &widths, shortHeight, &counterReference, moduleWidthWholePixels)

		if(i == 6.0){
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)
		}
		i = i + 1.0
	}

	/* Checksum*/
	checksum = GetCalculateUPCChecksum(&code)
	characterReference = CharacterReference()
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, &characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, shortHeight, &counterReference, moduleWidthWholePixels)

	/* Stop symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(&uninterpolatedBarcode, w, h).ref
	DrawImageOnImage(&image, &barcode, 0.0, 0.0)

	/* Draw digits*/
	i = 0.0
	while(i < Double(code.count)){
		digit = GetNumberFromNumberCharacterForBase(code[Int(i)], 10.0)
		if(i == 0.0){
			DrawDigitOnBarcode(&image, 0.0, textY, digit, pixelsPerMm, zoom)
		}else if(i <= 6.0){
			DrawDigitOnBarcode(&image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}else{
			DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}
		i = i + 1.0
	}
	DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func GetEAN13Group1Pattern(_ code : Character) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == "0"){
		spaces = characterArray("LLLLLL").ca
	}
	if(code == "1"){
		spaces = characterArray("LLGLGG").ca
	}
	if(code == "2"){
		spaces = characterArray("LLGGLG").ca
	}
	if(code == "3"){
		spaces = characterArray("LLGGGL").ca
	}
	if(code == "4"){
		spaces = characterArray("LGLLGG").ca
	}
	if(code == "5"){
		spaces = characterArray("LGGLLG").ca
	}
	if(code == "6"){
		spaces = characterArray("LGGGLL").ca
	}
	if(code == "7"){
		spaces = characterArray("LGLGLG").ca
	}
	if(code == "8"){
		spaces = characterArray("LGLGGL").ca
	}
	if(code == "9"){
		spaces = characterArray("LGGLGL").ca
	}

	return spaces
}


func GenerateBarcodeEAN8(_ code : inout [Character], _ widthInMm : Double, _ heightInMm : Double, _ pixelsPerMm : Double) -> RGBABitmapImageReferenceClass{
	var widthInMm = widthInMm;
	var heightInMm = heightInMm;
	var pixelsPerMm = pixelsPerMm;
	var w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone : Double
	var charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100 : Double
	var c, character : Character
	var image, uninterpolatedBarcode, barcode : RGBABitmapImage
	var widths, symbolWidths : [Character]
	var counterReference : NumberReference
	var characterReference : CharacterReference

	h = Roundx(heightInMm*pixelsPerMm)
	w = Roundx(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, &GetWhite().ref).ref

	zoom100 = (3.0 + 3.0 + 7.0*4.0 + 5.0 + 7.0*4.0 + 3.0 + 3.0)*0.33

	zoom = widthInMm/zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0/37.0
	textQuietZone = textheight*5.0/100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = floor(moduleWidthPixels)
	leftQuietZoneWholePixels = 3.0*moduleWidthWholePixels
	leftQuietZonePixels = 3.0*moduleWidthPixels
	group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*3.0 + 4.0)*moduleWidthPixels
	betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, &GetWhite().ref).ref

	counterReference = CreateNumberReference(leftQuietZoneWholePixels).ref

	/* Start symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	i = 0.0
	while(i < Double(code.count)){
		c = code[Int(i)]
		if(i <= 3.0){
			widths = GetUPCLCodeWidths(c)
		}else{
			widths = GetUPCRCodeWidths(c)
		}
		DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &widths, shortHeight, &counterReference, moduleWidthWholePixels)

		if(i == 3.0){
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)
		}
		i = i + 1.0
	}

	/* Checksum*/
	checksum = GetCalculateUPCChecksum(&code)
	characterReference = CharacterReference()
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, &characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, shortHeight, &counterReference, moduleWidthWholePixels)

	/* Stop symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(&uninterpolatedBarcode, w, h).ref
	DrawImageOnImage(&image, &barcode, 0.0, 0.0)

	/* Draw digits*/
	i = 0.0
	while(i < Double(code.count)){
		digit = GetNumberFromNumberCharacterForBase(code[Int(i)], 10.0)
		if(i <= 3.0){
			DrawDigitOnBarcode(&image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}else{
			DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}
		i = i + 1.0
	}
	DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func GenerateBarcodeUPCA(_ code : inout [Character], _ widthInMm : Double, _ heightInMm : Double, _ pixelsPerMm : Double) -> RGBABitmapImageReferenceClass{
	var widthInMm = widthInMm;
	var heightInMm = heightInMm;
	var pixelsPerMm = pixelsPerMm;
	var w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone : Double
	var charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup : Double
	var c, character : Character
	var image, uninterpolatedBarcode, barcode : RGBABitmapImage
	var widths, symbolWidths : [Character]
	var counterReference : NumberReference
	var characterReference : CharacterReference

	h = Roundx(heightInMm*pixelsPerMm)
	w = Roundx(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, &GetWhite().ref).ref

	zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 3.0 + 9.0)*0.33

	zoom = widthInMm/zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0/37.0
	textQuietZone = textheight*5.0/100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = floor(moduleWidthPixels)
	leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
	leftQuietZonePixels = 9.0*moduleWidthPixels
	group1x = leftQuietZonePixels + (3.0 + 7.0)*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*5.0 + 5.0)*moduleWidthPixels
	distanceToThirdGroup = distanceToSecondGroup + (7.0*5.0 + 5.0)*moduleWidthPixels
	betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, &GetWhite().ref).ref

	counterReference = CreateNumberReference(leftQuietZoneWholePixels).ref

	/* Start symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	i = 0.0
	while(i < Double(code.count)){
		c = code[Int(i)]
		if(i <= 5.0){
			widths = GetUPCLCodeWidths(c)
		}else{
			widths = GetUPCRCodeWidths(c)
		}

		if(i == 0.0){
			DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &widths, longHeight, &counterReference, moduleWidthWholePixels)
		}else{
			DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &widths, shortHeight, &counterReference, moduleWidthWholePixels)
		}

		if(i == 5.0){
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)
		}
		i = i + 1.0
	}

	/* Checksum*/
	checksum = GetCalculateUPCChecksum(&code)
	characterReference = CharacterReference()
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, &characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	/* Stop symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(&uninterpolatedBarcode, w, h).ref
	DrawImageOnImage(&image, &barcode, 0.0, 0.0)

	/* Draw digits*/
	i = 0.0
	while(i < Double(code.count)){
		digit = GetNumberFromNumberCharacterForBase(code[Int(i)], 10.0)
		if(i == 0.0){
			DrawDigitOnBarcode(&image, 0.0, textY, digit, pixelsPerMm, zoom)
		}else if(i <= 5.0){
			DrawDigitOnBarcode(&image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}else{
			DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 6.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}
		i = i + 1.0
	}
	DrawDigitOnBarcode(&image, distanceToThirdGroup + (i - 10.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func GetCalculateUPCChecksum(_ chars : inout [Character]) -> Double{
	var checksum, i, nextWeight, value, nearest10 : Double
	var next : Bool
	var numberString : [Character]

	numberString = Array(repeating:Character(" "), count: Int(1))

	checksum = 0.0
	next = true
	nextWeight = 3.0

	i = Double(chars.count) - 1.0
	while(i >= 0.0){
		numberString[Int(0)] = chars[Int(i)]
		value = CreateNumberFromDecimalString(&numberString)
		checksum = checksum + value*nextWeight

		if(next){
			nextWeight = 1.0
		}else{
			nextWeight = 3.0
		}
		next = !next
		i = i - 1.0
	}

	nearest10 = ceil(checksum/10.0)*10.0

	return nearest10 - checksum
}


func GetUPCStartAndStopCode() -> Double{
	return 10.0
}


func GetEAN13Width() -> Double{
	return 95.0 + 11.0
}


func GetUPCWidths(_ code : Double) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == 10.0){
		spaces = characterArray("101").ca
	}
	if(code == 11.0){
		spaces = characterArray("01010").ca
	}

	return spaces
}


func DrawBarcodeUPCSymbol(_ image : inout RGBABitmapImage, _ widths : inout [Character], _ h : Double, _ counterReference : inout NumberReference, _ moduleWidthPixels : Double) -> Void{
	var h = h;
	var moduleWidthPixels = moduleWidthPixels;
	var i, j : Double
	var widthCharacter : Character
	var color : RGBA

	i = 0.0
	while(i < Double(widths.count)){
		widthCharacter = widths[Int(i)]
		if(widthCharacter == "1"){
			color = GetBlack().ref
		}else{
			color = GetWhite().ref
		}

		j = 0.0
		while(j < moduleWidthPixels){
			DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &color)
			counterReference.numberValue = counterReference.numberValue + 1.0
			j = j + 1.0
		}
		i = i + 1.0
	}
}


func GetUPCLCodeWidths(_ code : Character) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == "0"){
		spaces = characterArray("0001101").ca
	}
	if(code == "1"){
		spaces = characterArray("0011001").ca
	}
	if(code == "2"){
		spaces = characterArray("0010011").ca
	}
	if(code == "3"){
		spaces = characterArray("0111101").ca
	}
	if(code == "4"){
		spaces = characterArray("0100011").ca
	}
	if(code == "5"){
		spaces = characterArray("0110001").ca
	}
	if(code == "6"){
		spaces = characterArray("0101111").ca
	}
	if(code == "7"){
		spaces = characterArray("0111011").ca
	}
	if(code == "8"){
		spaces = characterArray("0110111").ca
	}
	if(code == "9"){
		spaces = characterArray("0001011").ca
	}

	return spaces
}


func GetUPCGCodeWidths(_ code : Character) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == "0"){
		spaces = characterArray("0100111").ca
	}
	if(code == "1"){
		spaces = characterArray("0110011").ca
	}
	if(code == "2"){
		spaces = characterArray("0011011").ca
	}
	if(code == "3"){
		spaces = characterArray("0100001").ca
	}
	if(code == "4"){
		spaces = characterArray("0011101").ca
	}
	if(code == "5"){
		spaces = characterArray("0111001").ca
	}
	if(code == "6"){
		spaces = characterArray("0000101").ca
	}
	if(code == "7"){
		spaces = characterArray("0010001").ca
	}
	if(code == "8"){
		spaces = characterArray("0001001").ca
	}
	if(code == "9"){
		spaces = characterArray("0010111").ca
	}
	return spaces
}


func GetUPCRCodeWidths(_ code : Character) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == "0"){
		spaces = characterArray("1110010").ca
	}
	if(code == "1"){
		spaces = characterArray("1100110").ca
	}
	if(code == "2"){
		spaces = characterArray("1101100").ca
	}
	if(code == "3"){
		spaces = characterArray("1000010").ca
	}
	if(code == "4"){
		spaces = characterArray("1011100").ca
	}
	if(code == "5"){
		spaces = characterArray("1001110").ca
	}
	if(code == "6"){
		spaces = characterArray("1010000").ca
	}
	if(code == "7"){
		spaces = characterArray("1000100").ca
	}
	if(code == "8"){
		spaces = characterArray("1001000").ca
	}
	if(code == "9"){
		spaces = characterArray("1110100").ca
	}

	return spaces
}


func DrawDigitOnBarcode(_ image : inout RGBABitmapImage, _ topx : Double, _ topy : Double, _ digit : Double, _ pixelsPerMm : Double, _ zoom : Double) -> Void{
	var topx = topx;
	var topy = topy;
	var digit = digit;
	var pixelsPerMm = pixelsPerMm;
	var zoom = zoom;
	var digitImage, scaled : RGBABitmapImage

	digitImage = CreateImage(30.0, 37.0, &GetWhite().ref).ref
	DrawDigitCharacter(&digitImage, 0.0, 0.0, digit)
	scaled = BilinaerScaleUpFactor(&digitImage, pixelsPerMm*zoom/DPIToDotsPerMm(300.0)).ref
	DrawImageOnImage(&image, &scaled, floor(topx), floor(topy))
	delete(digitImage)
	delete(scaled)
}


func UPCAToUPCE(_ a : inout [Character]) -> [Character]{
	var mfg, productCode, e : [Character]

	e = Array(repeating:Character(" "), count: Int(7))
	e[Int(0)] = a[Int(0)]

	mfg = strSubstring(&a, 1.0, 6.0)
	productCode = strSubstring(&a, 6.0, 11.0)

	e[Int(1)] = mfg[Int(0)]
	e[Int(2)] = mfg[Int(1)]
	if((strSubstringEquals(&mfg, 2.0, &characterArray("000").ca) || strSubstringEquals(&mfg, 2.0, &characterArray("100").ca) || strSubstringEquals(&mfg, 2.0, &characterArray("200").ca)) && productCode[Int(0)] == "0" && productCode[Int(1)] == "0"){
		e[Int(3)] = productCode[Int(2)]
		e[Int(4)] = productCode[Int(3)]
		e[Int(5)] = productCode[Int(4)]
		e[Int(6)] = mfg[Int(2)]
	}else if(strSubstringEquals(&mfg, 3.0, &characterArray("00").ca) && productCode[Int(0)] == "0" && productCode[Int(1)] == "0" && productCode[Int(2)] == "0"){
		e[Int(3)] = mfg[Int(2)]
		e[Int(4)] = productCode[Int(3)]
		e[Int(5)] = productCode[Int(4)]
		e[Int(6)] = "3"
	}else if(strSubstringEquals(&mfg, 4.0, &characterArray("0").ca) && productCode[Int(0)] == "0" && productCode[Int(1)] == "0" && productCode[Int(2)] == "0" && productCode[Int(3)] == "0"){
		e[Int(3)] = mfg[Int(2)]
		e[Int(4)] = mfg[Int(3)]
		e[Int(5)] = productCode[Int(4)]
		e[Int(6)] = "4"
	}else if(arraysStringsEqual(&productCode, &characterArray("00005").ca) || arraysStringsEqual(&productCode, &characterArray("00006").ca) || arraysStringsEqual(&productCode, &characterArray("00006").ca) || arraysStringsEqual(&productCode, &characterArray("00007").ca) || arraysStringsEqual(&productCode, &characterArray("00008").ca) || arraysStringsEqual(&productCode, &characterArray("00009").ca)){
		e[Int(3)] = mfg[Int(2)]
		e[Int(4)] = mfg[Int(3)]
		e[Int(5)] = mfg[Int(4)]
		e[Int(6)] = productCode[Int(4)]
	}

	return e
}


func UPCEToUPCA(_ e : inout [Character]) -> [Character]{
	var a : [Character]

	a = Array(repeating:Character(" "), count: Int(11))

	a[Int(0)] = e[Int(0)]

	if(e[Int(6)] == "0" || e[Int(6)] == "1" || e[Int(6)] == "2"){
		a[Int(1)] = e[Int(1)]
		a[Int(2)] = e[Int(2)]
		a[Int(3)] = e[Int(6)]
		a[Int(4)] = "0"
		a[Int(5)] = "0"
		a[Int(6)] = "0"
		a[Int(7)] = "0"
		a[Int(8)] = e[Int(3)]
		a[Int(9)] = e[Int(4)]
		a[Int(10)] = e[Int(5)]
	}else if(e[Int(6)] == "3"){
		a[Int(1)] = e[Int(1)]
		a[Int(2)] = e[Int(2)]
		a[Int(3)] = e[Int(3)]
		a[Int(4)] = "0"
		a[Int(5)] = "0"
		a[Int(6)] = "0"
		a[Int(7)] = "0"
		a[Int(8)] = "0"
		a[Int(9)] = e[Int(4)]
		a[Int(10)] = e[Int(5)]
	}else if(e[Int(6)] == "4"){
		a[Int(1)] = e[Int(1)]
		a[Int(2)] = e[Int(2)]
		a[Int(3)] = e[Int(3)]
		a[Int(4)] = e[Int(4)]
		a[Int(5)] = "0"
		a[Int(6)] = "0"
		a[Int(7)] = "0"
		a[Int(8)] = "0"
		a[Int(9)] = "0"
		a[Int(10)] = e[Int(5)]
	}else{
		a[Int(1)] = e[Int(1)]
		a[Int(2)] = e[Int(2)]
		a[Int(3)] = e[Int(3)]
		a[Int(4)] = e[Int(4)]
		a[Int(5)] = e[Int(5)]
		a[Int(6)] = "0"
		a[Int(7)] = "0"
		a[Int(8)] = "0"
		a[Int(9)] = "0"
		a[Int(10)] = e[Int(6)]
	}

	return a
}


func GenerateBarcodeUPCE(_ e : inout [Character], _ widthInMm : Double, _ heightInMm : Double, _ pixelsPerMm : Double) -> RGBABitmapImageReferenceClass{
	var widthInMm = widthInMm;
	var heightInMm = heightInMm;
	var pixelsPerMm = pixelsPerMm;
	var w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone : Double
	var charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup : Double
	var c, character, type : Character
	var image, uninterpolatedBarcode, barcode : RGBABitmapImage
	var widths, symbolWidths, a, pattern : [Character]
	var counterReference : NumberReference
	var characterReference : CharacterReference

	h = Roundx(heightInMm*pixelsPerMm)
	w = Roundx(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, &GetWhite().ref).ref

	zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0)*0.33

	zoom = widthInMm/zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0/37.0
	textQuietZone = textheight*5.0/100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = floor(moduleWidthPixels)
	leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
	leftQuietZonePixels = 9.0*moduleWidthPixels
	group1x = leftQuietZonePixels + (3.0 + 1.0)*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*6.0 + 5.0)*moduleWidthPixels
	betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, &GetWhite().ref).ref

	counterReference = CreateNumberReference(leftQuietZoneWholePixels).ref

	/* Checksum*/
	a = UPCEToUPCA(&e)
	checksum = GetCalculateUPCChecksum(&a)
	characterReference = CharacterReference()
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, &characterReference)
	character = characterReference.characterValue

	/* Start symbol*/
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &symbolWidths, longHeight, &counterReference, moduleWidthWholePixels)

	pattern = GetUPCEPattern(character, e[Int(0)])

	i = 1.0
	while(i < Double(e.count)){
		c = e[Int(i)]
		type = pattern[Int(i - 1.0)]
		if(type == "O"){
			widths = GetUPCLCodeWidths(c)
		}else{
			widths = GetUPCGCodeWidths(c)
		}

		DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &widths, shortHeight, &counterReference, moduleWidthWholePixels)
		i = i + 1.0
	}

	/* Stop symbol*/
	DrawBarcodeUPCSymbol(&uninterpolatedBarcode, &characterArray("010101").ca, longHeight, &counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(&uninterpolatedBarcode, w, h).ref
	DrawImageOnImage(&image, &barcode, 0.0, 0.0)

	/* Draw digits*/
	i = 0.0
	while(i < Double(e.count)){
		digit = GetNumberFromNumberCharacterForBase(e[Int(i)], 10.0)
		if(i == 0.0){
			DrawDigitOnBarcode(&image, 0.0, textY, digit, pixelsPerMm, zoom)
		}else if(i <= 6.0){
			DrawDigitOnBarcode(&image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		}
		i = i + 1.0
	}
	DrawDigitOnBarcode(&image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func GetUPCEPattern(_ check : Character, _ system : Character) -> [Character]{
	var check = check;
	var system = system;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(system == "0"){
		if(check == "0"){
			spaces = characterArray("EEEOOO").ca
		}
		if(check == "1"){
			spaces = characterArray("EEOEOO").ca
		}
		if(check == "2"){
			spaces = characterArray("EEOOEO").ca
		}
		if(check == "3"){
			spaces = characterArray("EEOOOE").ca
		}
		if(check == "4"){
			spaces = characterArray("EOEEOO").ca
		}
		if(check == "5"){
			spaces = characterArray("EOOEEO").ca
		}
		if(check == "6"){
			spaces = characterArray("EOOOEE").ca
		}
		if(check == "7"){
			spaces = characterArray("EOEOEO").ca
		}
		if(check == "8"){
			spaces = characterArray("EOEOOE").ca
		}
		if(check == "9"){
			spaces = characterArray("EOOEOE").ca
		}
	}else if(system == "1"){
		if(check == "0"){
			spaces = characterArray("OOOEEE").ca
		}
		if(check == "1"){
			spaces = characterArray("OOEOEE").ca
		}
		if(check == "2"){
			spaces = characterArray("OOEEOE").ca
		}
		if(check == "3"){
			spaces = characterArray("OOEEEO").ca
		}
		if(check == "4"){
			spaces = characterArray("OEOOEE").ca
		}
		if(check == "5"){
			spaces = characterArray("OEEOOE").ca
		}
		if(check == "6"){
			spaces = characterArray("OEEEOO").ca
		}
		if(check == "7"){
			spaces = characterArray("OEOEOE").ca
		}
		if(check == "8"){
			spaces = characterArray("OEOEEO").ca
		}
		if(check == "9"){
			spaces = characterArray("OEEOEO").ca
		}
	}

	return spaces
}


func Code128EncodingParts(_ cs : inout [Character]) -> [Character]{
	var parts : [Character]
	var i : Double
	var c : Character

	parts = Array(repeating:Character(" "), count: Int(Double(cs.count)))

	i = 0.0
	while(i < Double(cs.count)){
		c = cs[Int(i)]

		if(IsCodeA(c) && IsCodeB(c) && IsCodeC(c)){
			parts[Int(i)] = "X"
		}else if(IsCodeA(c) && IsCodeB(c)){
			parts[Int(i)] = "D"
		}else if(IsCodeA(c)){
			parts[Int(i)] = "A"
		}else if(IsCodeB(c)){
			parts[Int(i)] = "B"
		}
		i = i + 1.0
	}

	return parts
}


func IsCodeA(_ c : Character) -> Bool{
	var c = c;
	return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || charIsCode128ASymbol(c)
}


func IsCodeB(_ c : Character) -> Bool{
	var c = c;
	return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || cIsLowerCase(c) || charIsCode128BSymbol(c)
}


func IsCodeC(_ c : Character) -> Bool{
	var c = c;
	return cIsNumber(c)
}


func Code128EncodingSections(_ cs : inout [Character]) -> SectionsReferenceClass{
	var sections, parts, currentSections : [Character]
	var i, c, next, sum : Double
	var p, selected : Character
	var done : Bool
	var sectionsStruct : Sections
	var counts, currentCounts : [Double]

	parts = Code128EncodingParts(&cs)

	sections = arraysCreateString(Double(cs.count), " ")
	counts = arraysCreateNumberArray(Double(cs.count), 0.0)
	next = 0.0

	/* Pick C-sections.*/
	i = 0.0
	while(i < Double(cs.count)){
		p = parts[Int(i)]

		if(p == "X"){
			done = false
			c = 0.0
			while(i + c < Double(cs.count) && !done){
				if(parts[Int(i + c)] != "X"){
					done = true
					c = c - 1.0
				}
				c = c + 1.0
			}
			/* Compress 2 or more if first, or 4 or more if not.*/
			if(c >= 4.0 || (i == 0.0 && c >= 2.0)){
				sections[Int(next)] = "C"
				c = floor(c/2.0)*2.0
				counts[Int(next)] = c
				next = next + 1.0
				i = i + c - 1.0
			}else{
				sections[Int(next)] = "D"
				counts[Int(next)] = 1.0
				next = next + 1.0
			}
		}else{
			sections[Int(next)] = p
			counts[Int(next)] = 1.0
			next = next + 1.0
		}
		i = i + 1.0
	}

	/* Trim*/
	currentSections = Array(repeating:Character(" "), count: Int(next))
	i = 0.0
	while(i < next){
		currentSections[Int(i)] = sections[Int(i)]
		i = i + 1.0
	}

	currentCounts = Array(repeating:Double(), count: Int(next))
	i = 0.0
	while(i < next){
		currentCounts[Int(i)] = counts[Int(i)]
		i = i + 1.0
	}

	sections = arraysCreateString(Double(cs.count), " ")
	counts = arraysCreateNumberArray(Double(cs.count), 0.0)

	/* Compress A+A&D and B+B&D*/
	next = 0.0
	i = 0.0
	while(i < Double(currentSections.count)){
		p = currentSections[Int(i)]

		if(p == "C" || p == "D"){
			sections[Int(next)] = p
			counts[Int(next)] = currentCounts[Int(i)]
			next = next + 1.0
		}else if(p == "A"){
			sum = 0.0
			done = false
			c = 0.0
			while(i + c < Double(currentSections.count) && !done){
				if(currentSections[Int(i + c)] == "A" || currentSections[Int(i + c)] == "D"){
					sum = sum + currentCounts[Int(i + c)]
				}else{
					done = true
					c = c - 1.0
				}
				c = c + 1.0
			}
			sections[Int(next)] = p
			counts[Int(next)] = sum
			next = next + 1.0
			i = i + c - 1.0
		}else if(p == "B"){
			sum = 0.0
			done = false
			c = 0.0
			while(i + c < Double(currentSections.count) && !done){
				if(currentSections[Int(i + c)] == "B" || currentSections[Int(i + c)] == "D"){
					sum = sum + currentCounts[Int(i + c)]
				}else{
					done = true
					c = c - 1.0
				}
				c = c + 1.0
			}
			sections[Int(next)] = p
			counts[Int(next)] = sum
			next = next + 1.0
			i = i + c - 1.0
		}
		i = i + 1.0
	}

	/* Trim*/
	currentSections = Array(repeating:Character(" "), count: Int(next))
	i = 0.0
	while(i < next){
		currentSections[Int(i)] = sections[Int(i)]
		i = i + 1.0
	}

	currentCounts = Array(repeating:Double(), count: Int(next))
	i = 0.0
	while(i < next){
		currentCounts[Int(i)] = counts[Int(i)]
		i = i + 1.0
	}

	sections = arraysCreateString(Double(cs.count), " ")
	counts = arraysCreateNumberArray(Double(cs.count), 0.0)

	/* Compress D+A&D and D+B&D*/
	next = 0.0
	i = 0.0
	while(i < Double(currentSections.count)){
		p = currentSections[Int(i)]

		sum = 0.0

		if(p == "C" || p == "A" || p == "B"){
			sections[Int(next)] = p
			counts[Int(next)] = currentCounts[Int(i)]
			next = next + 1.0
		}else if(p == "D"){
			selected = " "
			done = false

			sum = 0.0
			c = 0.0
			while(i + c < Double(currentSections.count) && !done){
				p = currentSections[Int(i + c)]

				if(p == "D"){
					sum = sum + currentCounts[Int(i + c)]
				}else if(p == "A" || p == "B"){
					if(selected == " "){
						selected = p
						sum = sum + currentCounts[Int(i + c)]
					}else if(p != selected){
						done = true
						c = c - 1.0
					}else{
						sum = sum + currentCounts[Int(i + c)]
					}
				}else{
					done = true
					c = c - 1.0
				}
				c = c + 1.0
			}
			if(selected == " "){
				selected = "A"
			}
			sections[Int(next)] = selected
			counts[Int(next)] = sum
			next = next + 1.0
			i = i + c - 1.0
		}
		i = i + 1.0
	}

	/* Trim*/
	currentSections = Array(repeating:Character(" "), count: Int(next))
	i = 0.0
	while(i < next){
		currentSections[Int(i)] = sections[Int(i)]
		i = i + 1.0
	}
	sections = currentSections

	currentCounts = Array(repeating:Double(), count: Int(next))
	i = 0.0
	while(i < next){
		currentCounts[Int(i)] = counts[Int(i)]
		i = i + 1.0
	}
	counts = currentCounts

	/* Done*/
	sectionsStruct = Sections()
	sectionsStruct.codes = sections
	sectionsStruct.counts = counts

	var returnReference = SectionsReferenceClass()
	returnReference.ref = sectionsStruct
	return returnReference
}


func Code128Encode(_ cs : inout [Character]) -> [Double]{
	var coded, nextCoded : [Double]
	var isFirst : Bool
	var n, k, next, cnr, count : Double
	var section, lastSection : Character
	var sections : Sections

	coded = Array(repeating:Double(), count: Int(Double(cs.count) + 2.0 + 1.0 + 1.0 + 10.0))
	cnr = 0.0
	isFirst = true
	next = 0.0

	lastSection = "0"

	sections = Code128EncodingSections(&cs).ref

	n = 0.0
	while(n < Double(sections.codes.count)){
		section = sections.codes[Int(n)]
		count = sections.counts[Int(n)]

		/* start code*/
		if(isFirst){
			if(section == "A"){
				coded[Int(next)] = 103.0
			}else if(section == "B"){
				coded[Int(next)] = 104.0
			}else if(section == "C"){
				coded[Int(next)] = 105.0
			}
			next = next + 1.0

			isFirst = false
		}

		/* Encode*/
		if(section == "A"){
			if(lastSection == "B" || lastSection == "C"){
				coded[Int(next)] = 101.0
				next = next + 1.0
			}

			k = 0.0
			while(k < count){
				coded[Int(next)] = GetCode128ACode(cs[Int(cnr + k)])
				next = next + 1.0
				k = k + 1.0
			}
			cnr = cnr + count
		}else if(section == "B"){
			if(lastSection == "A" || lastSection == "C"){
				coded[Int(next)] = 100.0
				next = next + 1.0
			}

			k = 0.0
			while(k < count){
				coded[Int(next)] = GetCode128BCode(cs[Int(cnr + k)])
				next = next + 1.0
				k = k + 1.0
			}
			cnr = cnr + count
		}else if(section == "C"){
			if(lastSection == "A" || lastSection == "B"){
				coded[Int(next)] = 99.0
				next = next + 1.0
			}

			k = 0.0
			while(k < count){
				coded[Int(next)] = GetCode128CCode(cs[Int(cnr + k)], cs[Int(cnr + k + 1.0)])
				next = next + 1.0
				k = k + 2.0
			}
			cnr = cnr + count
		}

		lastSection = section
		n = n + 1.0
	}

	coded[Int(next)] = CalculateCode128ChecksumWithLength(&coded, next)
	next = next + 1.0

	coded[Int(next)] = 108.0
	next = next + 1.0

	/* trim array*/
	nextCoded = Array(repeating:Double(), count: Int(next))
	k = 0.0
	while(k < next){
		nextCoded[Int(k)] = coded[Int(k)]
		k = k + 1.0
	}
	delete(coded)
	coded = nextCoded

	return coded
}


func GetCode128ACode(_ c : Character) -> Double{
	var c = c;
	var code, n : Double

	n = charToDouble(c)

	if(n >= 32.0 && n <= 95.0){
		code = n - 32.0
	}else if(n >= 0.0 && n <= 31.0){
		code = 64.0 + n
	}else{
		code = -1.0
	}

	return code
}


func GetCode128BCode(_ c : Character) -> Double{
	var c = c;
	var code, n : Double

	n = charToDouble(c)

	if(n >= 32.0 && n <= 126.0){
		code = n - 32.0
	}else if(n == 127.0){
		code = 95.0
	}else{
		code = -1.0
	}

	return code
}


func GetCode128CCode(_ c1 : Character, _ c2 : Character) -> Double{
	var c1 = c1;
	var c2 = c2;
	var n1, n2 : Double

	n1 = GetNumberFromNumberCharacterForBase(c1, 10.0)
	n2 = GetNumberFromNumberCharacterForBase(c2, 10.0)

	return n1*10.0 + n2
}


func charIsCode128AandBSymbol(_ character : Character) -> Bool{
	var character = character;
	var common : Bool

	common = false
	if(character == " "){
		common = true
	}else if(character == "!"){
		common = true
	}else if(character == "\""){
		common = true
	}else if(character == "#"){
		common = true
	}else if(character == "$"){
		common = true
	}else if(character == "%"){
		common = true
	}else if(character == "&"){
		common = true
	}else if(character == "\'"){
		common = true
	}else if(character == "("){
		common = true
	}else if(character == ")"){
		common = true
	}else if(character == "*"){
		common = true
	}else if(character == "+"){
		common = true
	}else if(character == ","){
		common = true
	}else if(character == "-"){
		common = true
	}else if(character == "."){
		common = true
	}else if(character == "/"){
		common = true
	}else if(character == ":"){
		common = true
	}else if(character == ";"){
		common = true
	}else if(character == "<"){
		common = true
	}else if(character == "="){
		common = true
	}else if(character == ">"){
		common = true
	}else if(character == "?"){
		common = true
	}else if(character == "@"){
		common = true
	}else if(character == "["){
		common = true
	}else if(character == "\\"){
		common = true
	}else if(character == "]"){
		common = true
	}else if(character == "^"){
		common = true
	}else if(character == "_"){
		common = true
	}

	return common
}


func charIsCode128BSymbol(_ character : Character) -> Bool{
	var character = character;
	var codeB : Bool

	codeB = false
	if(character == "`"){
		codeB = true
	}else if(character == "{"){
		codeB = true
	}else if(character == "|"){
		codeB = true
	}else if(character == "}"){
		codeB = true
	}else if(character == "~"){
		codeB = true
	}else if(charToDouble(character) == 127.0){
		/* del*/
		codeB = true
	}

	return codeB
}


func charIsCode128ASymbol(_ character : Character) -> Bool{
	var character = character;
	var codeA : Bool
	var n : Double

	n = charToDouble(character)

	codeA = false
	if(n >= 0.0 && n <= 31.0){
		codeA = true
	}

	return codeA
}


func GenerateBarcodeCode128(_ chars : inout [Character], _ height : Double) -> RGBABitmapImageReferenceClass{
	var height = height;
	var image : RGBABitmapImage
	var success : Bool
	var errorMessages : StringReference

	image = RGBABitmapImage()
	errorMessages = CreateStringReference(&characterArray("").ca).ref

	success = GenerateBarcodeCode128AllParams(&chars, height, 2.0, &image, &errorMessages)

	delete(errorMessages)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func GenerateBarcodeCode128AllParams(_ chars : inout [Character], _ height : Double, _ moduleWidth : Double, _ image : inout RGBABitmapImage, _ errorMessages : inout StringReference) -> Bool{
	var height = height;
	var moduleWidth = moduleWidth;
	var w, h, i, code : Double
	var counterReference : NumberReference
	var codes : [Double]
	var success : Bool
	var newImage : RGBABitmapImage

	success = IsValidCode128Data(&chars, height, moduleWidth, &errorMessages)

	if(success){
		codes = Code128Encode(&chars)

		h = height
		w = CalculateCode128Width(&codes, moduleWidth)

		newImage = CreateImage(w, h, &GetWhite().ref).ref
		image.x = newImage.x
		delete(newImage)

		counterReference = NumberReference()

		/* Start Quiet Zone*/
		counterReference.numberValue = 10.0*moduleWidth

		i = 0.0
		while(i < Double(codes.count)){
			code = codes[Int(i)]
			DrawBarcodeSymbol(&image, code, h, moduleWidth, &counterReference)
			i = i + 1.0
		}

		/* End Quiet Zone*/
		counterReference.numberValue = counterReference.numberValue + 10.0*moduleWidth
	}

	return success
}


func IsValidCode128Data(_ chars : inout [Character], _ height : Double, _ moduleWidth : Double, _ errorMessages : inout StringReference) -> Bool{
	var height = height;
	var moduleWidth = moduleWidth;
	var validCharacters, i : Double
	var valid : Bool

	validCharacters = 0.0

	i = 0.0
	while(i < Double(chars.count)){
		if(charToDouble(chars[Int(i)]) >= 0.0 && charToDouble(chars[Int(i)]) <= 127.0){
			validCharacters = validCharacters + 1.0
		}
		i = i + 1.0
	}

	if(validCharacters == Double(chars.count)){

		if(height > 0.0){
			if(Truncate(height) == height){
				if(moduleWidth > 0.0){
					if(Truncate(moduleWidth) == moduleWidth){
						valid = true
					}else{
						valid = false
						errorMessages.stringx = strAppendString(&errorMessages.stringx, &characterArray("Module width must be a whole number of pixels.").ca)
					}
				}else{
					valid = false
					errorMessages.stringx = strAppendString(&errorMessages.stringx, &characterArray("Module width must be at least one pixel.").ca)
				}
			}else{
				valid = false
				errorMessages.stringx = strAppendString(&errorMessages.stringx, &characterArray("Height must be a whole number of pixels.").ca)
			}
		}else{
			valid = false
			errorMessages.stringx = strAppendString(&errorMessages.stringx, &characterArray("Height must be at least one pixel.").ca)
		}
	}else{
		valid = false
		errorMessages.stringx = strAppendString(&errorMessages.stringx, &characterArray("Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.").ca)
	}

	return valid
}


func CalculateCode128Width(_ codes : inout [Double], _ moduleWidth : Double) -> Double{
	var moduleWidth = moduleWidth;
	var width : Double

	/* Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.*/
	width = (10.0 + Double(codes.count)*11.0 + 2.0 + 10.0)*moduleWidth

	return width
}


func CalculateCode128Checksum(_ codes : inout [Double]) -> Double{
	return CalculateCode128ChecksumWithLength(&codes, Double(codes.count))
}


func CalculateCode128ChecksumWithLength(_ codes : inout [Double], _ length : Double) -> Double{
	var length = length;
	var checksum, i, position, value : Double

	checksum = 0.0

	position = 1.0
	i = 0.0
	while(i < length){
		if(i > 1.0){
			position = position + 1.0
		}
		value = codes[Int(i)]
		checksum = checksum + position*value
		i = i + 1.0
	}

	return checksum.truncatingRemainder(dividingBy:103.0)
}


func DrawBarcodeSymbol(_ image : inout RGBABitmapImage, _ barcodeNr : Double, _ h : Double, _ moduleWidth : Double, _ counterReference : inout NumberReference) -> Void{
	var barcodeNr = barcodeNr;
	var h = h;
	var moduleWidth = moduleWidth;
	var i, j, k, width : Double
	var widthCharacter : Character
	var widths : [Character]
	var next : Bool
	var nextColor : RGBA

	widths = GetCode128Widths(barcodeNr)

	nextColor = GetBlack().ref
	next = true

	i = 0.0
	while(i < Double(widths.count)){
		widthCharacter = widths[Int(i)]
		width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

		j = 0.0
		while(j < width){
			k = 0.0
			while(k < moduleWidth){
				DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &nextColor)
				counterReference.numberValue = counterReference.numberValue + 1.0
				k = k + 1.0
			}
			j = j + 1.0
		}

		if(next){
			nextColor = GetWhite().ref
		}else{
			nextColor = GetBlack().ref
		}
		next = !next
		i = i + 1.0
	}
}


func GetCode128Widths(_ code : Double) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == 0.0){
		spaces = characterArray("212222").ca
	}
	if(code == 1.0){
		spaces = characterArray("222122").ca
	}
	if(code == 2.0){
		spaces = characterArray("222221").ca
	}
	if(code == 3.0){
		spaces = characterArray("121223").ca
	}
	if(code == 4.0){
		spaces = characterArray("121322").ca
	}
	if(code == 5.0){
		spaces = characterArray("131222").ca
	}
	if(code == 6.0){
		spaces = characterArray("122213").ca
	}
	if(code == 7.0){
		spaces = characterArray("122312").ca
	}
	if(code == 8.0){
		spaces = characterArray("132212").ca
	}
	if(code == 9.0){
		spaces = characterArray("221213").ca
	}
	if(code == 10.0){
		spaces = characterArray("221312").ca
	}
	if(code == 11.0){
		spaces = characterArray("231212").ca
	}
	if(code == 12.0){
		spaces = characterArray("112232").ca
	}
	if(code == 13.0){
		spaces = characterArray("122132").ca
	}
	if(code == 14.0){
		spaces = characterArray("122231").ca
	}
	if(code == 15.0){
		spaces = characterArray("113222").ca
	}
	if(code == 16.0){
		spaces = characterArray("123122").ca
	}
	if(code == 17.0){
		spaces = characterArray("123221").ca
	}
	if(code == 18.0){
		spaces = characterArray("223211").ca
	}
	if(code == 19.0){
		spaces = characterArray("221132").ca
	}
	if(code == 20.0){
		spaces = characterArray("221231").ca
	}
	if(code == 21.0){
		spaces = characterArray("213212").ca
	}
	if(code == 22.0){
		spaces = characterArray("223112").ca
	}
	if(code == 23.0){
		spaces = characterArray("312131").ca
	}
	if(code == 24.0){
		spaces = characterArray("311222").ca
	}
	if(code == 25.0){
		spaces = characterArray("321122").ca
	}
	if(code == 26.0){
		spaces = characterArray("321221").ca
	}
	if(code == 27.0){
		spaces = characterArray("312212").ca
	}
	if(code == 28.0){
		spaces = characterArray("322112").ca
	}
	if(code == 29.0){
		spaces = characterArray("322211").ca
	}
	if(code == 30.0){
		spaces = characterArray("212123").ca
	}
	if(code == 31.0){
		spaces = characterArray("212321").ca
	}
	if(code == 32.0){
		spaces = characterArray("232121").ca
	}
	if(code == 33.0){
		spaces = characterArray("111323").ca
	}
	if(code == 34.0){
		spaces = characterArray("131123").ca
	}
	if(code == 35.0){
		spaces = characterArray("131321").ca
	}
	if(code == 36.0){
		spaces = characterArray("112313").ca
	}
	if(code == 37.0){
		spaces = characterArray("132113").ca
	}
	if(code == 38.0){
		spaces = characterArray("132311").ca
	}
	if(code == 39.0){
		spaces = characterArray("211313").ca
	}
	if(code == 40.0){
		spaces = characterArray("231113").ca
	}
	if(code == 41.0){
		spaces = characterArray("231311").ca
	}
	if(code == 42.0){
		spaces = characterArray("112133").ca
	}
	if(code == 43.0){
		spaces = characterArray("112331").ca
	}
	if(code == 44.0){
		spaces = characterArray("132131").ca
	}
	if(code == 45.0){
		spaces = characterArray("113123").ca
	}
	if(code == 46.0){
		spaces = characterArray("113321").ca
	}
	if(code == 47.0){
		spaces = characterArray("133121").ca
	}
	if(code == 48.0){
		spaces = characterArray("313121").ca
	}
	if(code == 49.0){
		spaces = characterArray("211331").ca
	}
	if(code == 50.0){
		spaces = characterArray("231131").ca
	}
	if(code == 51.0){
		spaces = characterArray("213113").ca
	}
	if(code == 52.0){
		spaces = characterArray("213311").ca
	}
	if(code == 53.0){
		spaces = characterArray("213131").ca
	}
	if(code == 54.0){
		spaces = characterArray("311123").ca
	}
	if(code == 55.0){
		spaces = characterArray("311321").ca
	}
	if(code == 56.0){
		spaces = characterArray("331121").ca
	}
	if(code == 57.0){
		spaces = characterArray("312113").ca
	}
	if(code == 58.0){
		spaces = characterArray("312311").ca
	}
	if(code == 59.0){
		spaces = characterArray("332111").ca
	}
	if(code == 60.0){
		spaces = characterArray("314111").ca
	}
	if(code == 61.0){
		spaces = characterArray("221411").ca
	}
	if(code == 62.0){
		spaces = characterArray("431111").ca
	}
	if(code == 63.0){
		spaces = characterArray("111224").ca
	}
	if(code == 64.0){
		spaces = characterArray("111422").ca
	}
	if(code == 65.0){
		spaces = characterArray("121124").ca
	}
	if(code == 66.0){
		spaces = characterArray("121421").ca
	}
	if(code == 67.0){
		spaces = characterArray("141122").ca
	}
	if(code == 68.0){
		spaces = characterArray("141221").ca
	}
	if(code == 69.0){
		spaces = characterArray("112214").ca
	}
	if(code == 70.0){
		spaces = characterArray("112412").ca
	}
	if(code == 71.0){
		spaces = characterArray("122114").ca
	}
	if(code == 72.0){
		spaces = characterArray("122411").ca
	}
	if(code == 73.0){
		spaces = characterArray("142112").ca
	}
	if(code == 74.0){
		spaces = characterArray("142211").ca
	}
	if(code == 75.0){
		spaces = characterArray("241211").ca
	}
	if(code == 76.0){
		spaces = characterArray("221114").ca
	}
	if(code == 77.0){
		spaces = characterArray("413111").ca
	}
	if(code == 78.0){
		spaces = characterArray("241112").ca
	}
	if(code == 79.0){
		spaces = characterArray("134111").ca
	}
	if(code == 80.0){
		spaces = characterArray("111242").ca
	}
	if(code == 81.0){
		spaces = characterArray("121142").ca
	}
	if(code == 82.0){
		spaces = characterArray("121241").ca
	}
	if(code == 83.0){
		spaces = characterArray("114212").ca
	}
	if(code == 84.0){
		spaces = characterArray("124112").ca
	}
	if(code == 85.0){
		spaces = characterArray("124211").ca
	}
	if(code == 86.0){
		spaces = characterArray("411212").ca
	}
	if(code == 87.0){
		spaces = characterArray("421112").ca
	}
	if(code == 88.0){
		spaces = characterArray("421211").ca
	}
	if(code == 89.0){
		spaces = characterArray("212141").ca
	}
	if(code == 90.0){
		spaces = characterArray("214121").ca
	}
	if(code == 91.0){
		spaces = characterArray("412121").ca
	}
	if(code == 92.0){
		spaces = characterArray("111143").ca
	}
	if(code == 93.0){
		spaces = characterArray("111341").ca
	}
	if(code == 94.0){
		spaces = characterArray("131141").ca
	}
	if(code == 95.0){
		spaces = characterArray("114113").ca
	}
	if(code == 96.0){
		spaces = characterArray("114311").ca
	}
	if(code == 97.0){
		spaces = characterArray("411113").ca
	}
	if(code == 98.0){
		spaces = characterArray("411311").ca
	}
	if(code == 99.0){
		spaces = characterArray("113141").ca
	}
	if(code == 100.0){
		spaces = characterArray("114131").ca
	}
	if(code == 101.0){
		spaces = characterArray("311141").ca
	}
	if(code == 102.0){
		spaces = characterArray("411131").ca
	}
	if(code == 103.0){
		spaces = characterArray("211412").ca
	}
	if(code == 104.0){
		spaces = characterArray("211214").ca
	}
	if(code == 105.0){
		spaces = characterArray("211232").ca
	}
	if(code == 106.0){
		spaces = characterArray("233111").ca
	}
	if(code == 107.0){
		spaces = characterArray("211133").ca
	}
	if(code == 108.0){
		spaces = characterArray("2331112").ca
	}

	return spaces
}


func GenerateBarcodeCode39(_ chars : inout [Character], _ height : Double) -> RGBABitmapImageReferenceClass{
	var height = height;
	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = GenerateBarcodeCode39WithChecksumOption(&chars, height, false).ref
	return returnReference
}


func GenerateBarcodeCode39WithChecksumOption(_ chars : inout [Character], _ height : Double, _ includeChecksum : Bool) -> RGBABitmapImageReferenceClass{
	var height = height;
	var includeChecksum = includeChecksum;
	var w, h, i, barcodeNr, checksum : Double
	var c : Character
	var counterReference : NumberReference
	var image : RGBABitmapImage

	h = height
	w = CalculateCode39Width(&chars, includeChecksum)*2.0

	image = CreateImage(w, h, &GetWhite().ref).ref

	counterReference = CreateNumberReference(10.0*2.0).ref

	/* Start symbol*/
	DrawBarcode39Symbol(&image, Get39StartAndStopCode(), h, &counterReference, true)

	i = 0.0
	while(i < Double(chars.count)){
		c = chars[Int(i)]
		barcodeNr = AsciiToCode39(c)
		DrawBarcode39Symbol(&image, barcodeNr, h, &counterReference, true)
		i = i + 1.0
	}

	if(includeChecksum){
		checksum = CalculateCode39Checksum(&chars)
		DrawBarcode39Symbol(&image, checksum, h, &counterReference, true)
	}

	/* Stop symbol*/
	DrawBarcode39Symbol(&image, Get39StartAndStopCode(), h, &counterReference, false)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func CalculateCode39Checksum(_ chars : inout [Character]) -> Double{
	var checksum, i, value : Double
	var c : Character

	checksum = 0.0

	i = 0.0
	while(i < Double(chars.count)){
		c = chars[Int(i)]
		value = AsciiToCode39(c)
		checksum = checksum + value
		i = i + 1.0
	}

	return checksum.truncatingRemainder(dividingBy:43.0)
}


func Get39StartAndStopCode() -> Double{
	return 43.0
}


func CalculateCode39Width(_ chars : inout [Character], _ includeChecksum : Bool) -> Double{
	var includeChecksum = includeChecksum;
	var width : Double

	/* quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone*/
	width = 10.0 + 12.0 + 1.0 + Double(chars.count)*12.0 + Double(chars.count)*1.0 + 12.0 + 10.0

	if(includeChecksum){
		width = width + 1.0 + 12.0
	}

	return width
}


func DrawBarcode39Symbol(_ image : inout RGBABitmapImage, _ barcodeNr : Double, _ h : Double, _ counterReference : inout NumberReference, _ addSeparator : Bool) -> Void{
	var barcodeNr = barcodeNr;
	var h = h;
	var addSeparator = addSeparator;
	var j, k, width : Double
	var widthCharacter : Character
	var widths : [Character]
	var next : Bool
	var nextColor : RGBA

	widths = GetCode39Widths(barcodeNr)

	nextColor = GetBlack().ref
	next = true

	j = 0.0
	while(j < Double(widths.count)){
		widthCharacter = widths[Int(j)]
		width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

		k = 0.0
		while(k < width){
			DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &nextColor)
			counterReference.numberValue = counterReference.numberValue + 1.0
			DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &nextColor)
			counterReference.numberValue = counterReference.numberValue + 1.0
			k = k + 1.0
		}

		if(next){
			nextColor = GetWhite().ref
		}else{
			nextColor = GetBlack().ref
		}
		next = !next
		j = j + 1.0
	}

	/* Space*/
	if(addSeparator){
		DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &GetWhite().ref)
		counterReference.numberValue = counterReference.numberValue + 1.0
		DrawVerticalLine1px(&image, counterReference.numberValue, 0.0, h, &GetWhite().ref)
		counterReference.numberValue = counterReference.numberValue + 1.0
	}
}


func GetCode39Widths(_ code : Double) -> [Character]{
	var code = code;
	var spaces : [Character]

	spaces = characterArray("").ca

	if(code == 0.0){
		spaces = characterArray("111221211").ca
	}
	if(code == 1.0){
		spaces = characterArray("211211112").ca
	}
	if(code == 2.0){
		spaces = characterArray("112211112").ca
	}
	if(code == 3.0){
		spaces = characterArray("212211111").ca
	}
	if(code == 4.0){
		spaces = characterArray("111221112").ca
	}
	if(code == 5.0){
		spaces = characterArray("211221111").ca
	}
	if(code == 6.0){
		spaces = characterArray("112221111").ca
	}
	if(code == 7.0){
		spaces = characterArray("111211212").ca
	}
	if(code == 8.0){
		spaces = characterArray("211211211").ca
	}
	if(code == 9.0){
		spaces = characterArray("112211211").ca
	}
	if(code == 10.0){
		spaces = characterArray("211112112").ca
	}
	if(code == 11.0){
		spaces = characterArray("112112112").ca
	}
	if(code == 12.0){
		spaces = characterArray("212112111").ca
	}
	if(code == 13.0){
		spaces = characterArray("111122112").ca
	}
	if(code == 14.0){
		spaces = characterArray("211122111").ca
	}
	if(code == 15.0){
		spaces = characterArray("112122111").ca
	}
	if(code == 16.0){
		spaces = characterArray("111112212").ca
	}
	if(code == 17.0){
		spaces = characterArray("211112211").ca
	}
	if(code == 18.0){
		spaces = characterArray("112112211").ca
	}
	if(code == 19.0){
		spaces = characterArray("111122211").ca
	}
	if(code == 20.0){
		spaces = characterArray("211111122").ca
	}
	if(code == 21.0){
		spaces = characterArray("112111122").ca
	}
	if(code == 22.0){
		spaces = characterArray("212111121").ca
	}
	if(code == 23.0){
		spaces = characterArray("111121122").ca
	}
	if(code == 24.0){
		spaces = characterArray("211121121").ca
	}
	if(code == 25.0){
		spaces = characterArray("112121121").ca
	}
	if(code == 26.0){
		spaces = characterArray("111111222").ca
	}
	if(code == 27.0){
		spaces = characterArray("211111221").ca
	}
	if(code == 28.0){
		spaces = characterArray("112111221").ca
	}
	if(code == 29.0){
		spaces = characterArray("111121221").ca
	}
	if(code == 30.0){
		spaces = characterArray("221111112").ca
	}
	if(code == 31.0){
		spaces = characterArray("122111112").ca
	}
	if(code == 32.0){
		spaces = characterArray("222111111").ca
	}
	if(code == 33.0){
		spaces = characterArray("121121112").ca
	}
	if(code == 34.0){
		spaces = characterArray("221121111").ca
	}
	if(code == 35.0){
		spaces = characterArray("122121111").ca
	}
	if(code == 36.0){
		spaces = characterArray("121111212").ca
	}
	if(code == 37.0){
		spaces = characterArray("221111211").ca
	}
	if(code == 38.0){
		spaces = characterArray("122111211").ca
	}
	if(code == 39.0){
		spaces = characterArray("121212111").ca
	}
	if(code == 40.0){
		spaces = characterArray("121211121").ca
	}
	if(code == 41.0){
		spaces = characterArray("121112121").ca
	}
	if(code == 42.0){
		spaces = characterArray("111212121").ca
	}
	if(code == 43.0){
		spaces = characterArray("121121211").ca
	}

	return spaces
}


func AsciiToCode39(_ c : Character) -> Double{
	var c = c;
	var nr : Double
	var asciiToNrTable : [Double]

	asciiToNrTable = GetAsciiToCode39Table()
	nr = charToDouble(c)

	return asciiToNrTable[Int(nr)]
}


func GetAsciiToCode39Table() -> [Double]{
	var c : [Double]

	c = Array(repeating:Double(), count: Int(256))

	c[Int(charToDouble("0"))] = 0.0
	c[Int(charToDouble("1"))] = 1.0
	c[Int(charToDouble("2"))] = 2.0
	c[Int(charToDouble("3"))] = 3.0
	c[Int(charToDouble("4"))] = 4.0
	c[Int(charToDouble("5"))] = 5.0
	c[Int(charToDouble("6"))] = 6.0
	c[Int(charToDouble("7"))] = 7.0
	c[Int(charToDouble("8"))] = 8.0
	c[Int(charToDouble("9"))] = 9.0
	c[Int(charToDouble("A"))] = 10.0
	c[Int(charToDouble("B"))] = 11.0
	c[Int(charToDouble("C"))] = 12.0
	c[Int(charToDouble("D"))] = 13.0
	c[Int(charToDouble("E"))] = 14.0
	c[Int(charToDouble("F"))] = 15.0
	c[Int(charToDouble("G"))] = 16.0
	c[Int(charToDouble("H"))] = 17.0
	c[Int(charToDouble("I"))] = 18.0
	c[Int(charToDouble("J"))] = 19.0
	c[Int(charToDouble("K"))] = 20.0
	c[Int(charToDouble("L"))] = 21.0
	c[Int(charToDouble("M"))] = 22.0
	c[Int(charToDouble("N"))] = 23.0
	c[Int(charToDouble("O"))] = 24.0
	c[Int(charToDouble("P"))] = 25.0
	c[Int(charToDouble("Q"))] = 26.0
	c[Int(charToDouble("R"))] = 27.0
	c[Int(charToDouble("S"))] = 28.0
	c[Int(charToDouble("T"))] = 29.0
	c[Int(charToDouble("U"))] = 30.0
	c[Int(charToDouble("V"))] = 31.0
	c[Int(charToDouble("W"))] = 32.0
	c[Int(charToDouble("X"))] = 33.0
	c[Int(charToDouble("Y"))] = 34.0
	c[Int(charToDouble("Z"))] = 35.0
	c[Int(charToDouble("-"))] = 36.0
	c[Int(charToDouble("."))] = 37.0
	c[Int(charToDouble(" "))] = 38.0
	c[Int(charToDouble("$"))] = 39.0
	c[Int(charToDouble("/"))] = 40.0
	c[Int(charToDouble("+"))] = 41.0
	c[Int(charToDouble("%"))] = 42.0
	c[Int(charToDouble("*"))] = 43.0

	return c
}


func IsQRNumericString(_ chars : inout [Character]) -> Bool{
	var i : Double
	var valid : Bool

	valid = true

	i = 0.0
	while(i < Double(chars.count)){
		if(IsQRNumericCharacter(chars[Int(i)])){
		}else{
			valid = false
		}
		i = i + 1.0
	}

	return valid
}


func IsQRNumericCharacter(_ aChar : Character) -> Bool{
	var aChar = aChar;
	return cIsNumber(aChar)
}


func IsQRAlphanumericString(_ chars : inout [Character]) -> Bool{
	var i : Double
	var valid : Bool
	var c : Character

	valid = true

	i = 0.0
	while(i < Double(chars.count)){
		c = chars[Int(i)]

		valid = IsQRAlphanumericCharacter(c)
		i = i + 1.0
	}

	return valid
}


func IsQRAlphanumericCharacter(_ c : Character) -> Bool{
	var c = c;
	var valid : Bool

	valid = true

	if(cIsNumber(c)){
	}else if(IsQRAlphaUppercase(c)){
	}else if(c == " "){
	}else if(c == "$"){
	}else if(c == "%"){
	}else if(c == "*"){
	}else if(c == "+"){
	}else if(c == "-"){
	}else if(c == "."){
	}else if(c == "/"){
	}else if(c == ":"){
	}else{
		valid = false
	}
	return valid
}


func IsQRJIS8Character(_ c : Character) -> Bool{
	var c = c;
	var code : Double
	var valid : Bool

	code = charToDouble(c)

	if(code >= 0.0 && code < 128.0){
		valid = true
	}else{
		valid = false
	}

	return valid
}


func IsQRAlphaUppercase(_ character : Character) -> Bool{
	var character = character;
	var isUpper : Bool

	isUpper = true
	if(character == "A"){
	}else if(character == "B"){
	}else if(character == "C"){
	}else if(character == "D"){
	}else if(character == "E"){
	}else if(character == "F"){
	}else if(character == "G"){
	}else if(character == "H"){
	}else if(character == "I"){
	}else if(character == "J"){
	}else if(character == "K"){
	}else if(character == "L"){
	}else if(character == "M"){
	}else if(character == "N"){
	}else if(character == "O"){
	}else if(character == "P"){
	}else if(character == "Q"){
	}else if(character == "R"){
	}else if(character == "S"){
	}else if(character == "T"){
	}else if(character == "U"){
	}else if(character == "V"){
	}else if(character == "W"){
	}else if(character == "X"){
	}else if(character == "Y"){
	}else if(character == "Z"){
	}else{
		isUpper = false
	}

	return isUpper
}


func QRAlphanumericToCode(_ c : Character) -> Double{
	var c = c;
	var code : Double

	if(c == "0"){
		code = 0.0
	}else if(c == "1"){
		code = 1.0
	}else if(c == "2"){
		code = 2.0
	}else if(c == "3"){
		code = 3.0
	}else if(c == "4"){
		code = 4.0
	}else if(c == "5"){
		code = 5.0
	}else if(c == "6"){
		code = 6.0
	}else if(c == "7"){
		code = 7.0
	}else if(c == "8"){
		code = 8.0
	}else if(c == "9"){
		code = 9.0
	}else if(c == "A"){
		code = 10.0
	}else if(c == "B"){
		code = 11.0
	}else if(c == "C"){
		code = 12.0
	}else if(c == "D"){
		code = 13.0
	}else if(c == "E"){
		code = 14.0
	}else if(c == "F"){
		code = 15.0
	}else if(c == "G"){
		code = 16.0
	}else if(c == "H"){
		code = 17.0
	}else if(c == "I"){
		code = 18.0
	}else if(c == "J"){
		code = 19.0
	}else if(c == "K"){
		code = 20.0
	}else if(c == "L"){
		code = 21.0
	}else if(c == "M"){
		code = 22.0
	}else if(c == "N"){
		code = 23.0
	}else if(c == "O"){
		code = 24.0
	}else if(c == "P"){
		code = 25.0
	}else if(c == "Q"){
		code = 26.0
	}else if(c == "R"){
		code = 27.0
	}else if(c == "S"){
		code = 28.0
	}else if(c == "T"){
		code = 29.0
	}else if(c == "U"){
		code = 30.0
	}else if(c == "V"){
		code = 31.0
	}else if(c == "W"){
		code = 32.0
	}else if(c == "X"){
		code = 33.0
	}else if(c == "Y"){
		code = 34.0
	}else if(c == "Z"){
		code = 35.0
	}else if(c == " "){
		code = 36.0
	}else if(c == "$"){
		code = 37.0
	}else if(c == "%"){
		code = 38.0
	}else if(c == "*"){
		code = 39.0
	}else if(c == "+"){
		code = 40.0
	}else if(c == "-"){
		code = 41.0
	}else if(c == "."){
		code = 42.0
	}else if(c == "/"){
		code = 43.0
	}else if(c == ":"){
		code = 44.0
	}else{
		code = 0.0
	}

	return code
}


func QRAddErrorCodesAndInterleave(_ cws : inout [Double], _ version : Double, _ errorCorrectionLevel : Character) -> [Double]{
	var version = version;
	var errorCorrectionLevel = errorCorrectionLevel;
	var eccsPerBlock, errorCorrectionLevelNumber, nrOfBlocks, i, j, cw, cwsInBlock, e : Double
	var ecc, eccPerBlockSpec, blockSpecs, blockLengths, block, complete : [Double]
	var blocks, blockEccs : [NumberArrayReference]

	eccPerBlockSpec = StringToNumberArray(&characterArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30").ca)

	blockSpecs = StringToNumberArray(&characterArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81").ca)

	errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel)

	eccsPerBlock = eccPerBlockSpec[Int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]
	nrOfBlocks = blockSpecs[Int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]

	blockLengths = QRComputeBlockLengths(Double(cws.count), nrOfBlocks)

	blocks = Array(repeating:NumberArrayReference(), count: Int(nrOfBlocks))
	blockEccs = Array(repeating:NumberArrayReference(), count: Int(nrOfBlocks))

	cw = 0.0
	i = 0.0
	while(i < nrOfBlocks){
		/* Create block.*/
		cwsInBlock = blockLengths[Int(i)]
		block = Array(repeating:Double(), count: Int(cwsInBlock))
		j = 0.0
		while(j < cwsInBlock){
			block[Int(j)] = cws[Int(cw)]
			cw = cw + 1.0
			j = j + 1.0
		}

		/* Compute eccs.*/
		ecc = ComputeReedSolomonCodes(&block, eccsPerBlock)

		blocks[Int(i)] = NumberArrayReference()
		blocks[Int(i)].numberArray = block
		blockEccs[Int(i)] = NumberArrayReference()
		blockEccs[Int(i)].numberArray = ecc
		i = i + 1.0
	}

	/* Compose full data block:*/
	complete = Array(repeating:Double(), count: Int(Double(cws.count) + eccsPerBlock*nrOfBlocks))

	e = 0.0
	/* Interleave codewords:*/
	i = 0.0
	while(i < floor(Double(cws.count)/nrOfBlocks)){
		j = 0.0
		while(j < nrOfBlocks){
			complete[Int(e)] = blocks[Int(j)].numberArray[Int(i)]
			e = e + 1.0
			j = j + 1.0
		}
		i = i + 1.0
	}

	/* Interleave remaining code words:*/
	i = 0.0
	while(i < nrOfBlocks){
		if(blockLengths[Int(i)] > blockLengths[Int(0)]){
			complete[Int(e)] = blocks[Int(i)].numberArray[Int(blockLengths[Int(i)] - 1.0)]
			e = e + 1.0
		}
		i = i + 1.0
	}

	i = 0.0
	while(i < eccsPerBlock){
		j = 0.0
		while(j < nrOfBlocks){
			complete[Int(e)] = blockEccs[Int(j)].numberArray[Int(i)]
			e = e + 1.0
			j = j + 1.0
		}
		i = i + 1.0
	}

	return complete
}


func QRComputeBlockLengths(_ length : Double, _ blocks : Double) -> [Double]{
	var length = length;
	var blocks = blocks;
	var q, r, i : Double
	var blockLengths : [Double]

	blockLengths = Array(repeating:Double(), count: Int(blocks))

	q = floor(length/blocks)
	r = length.truncatingRemainder(dividingBy:blocks)

	i = 0.0
	while(i < blocks){
		blockLengths[Int(i)] = q
		i = i + 1.0
	}

	if(r > 0.0){
		i = 0.0
		while(i < r){
			blockLengths[Int(Double(blockLengths.count) - 1.0 - i)] = q + 1.0
			i = i + 1.0
		}
	}

	return blockLengths
}


func GenerateQRCode(_ imageReference : inout RGBABitmapImageReference, _ chars : inout [Character], _ errorCorrectionLevel : Character, _ errorMessage : inout StringReference) -> Bool{
	var errorCorrectionLevel = errorCorrectionLevel;
	var version : Double
	var versionReference : NumberReference
	var success : Bool

	versionReference = NumberReference()
	success = QRGetRequiredVersionFromData(&chars, errorCorrectionLevel, &versionReference, &errorMessage)

	if(success){
		version = versionReference.numberValue

		GenerateQRCodeWithAllOptions(&imageReference, &chars, version, errorCorrectionLevel, QRQuietZoneSize(), &errorMessage)
	}

	return success
}


func QRGetRequiredVersionFromData(_ chars : inout [Character], _ errorCorrectionLevelCode : Character, _ versionReference : inout NumberReference, _ errorMessage : inout StringReference) -> Bool{
	var errorCorrectionLevelCode = errorCorrectionLevelCode;
	var modeReference : StringReference
	var success, done : Bool
	var i, l, errorCorrectionLevelNumber : Double
	var modeName : [Character]
	var symbolBitsSpec : [Double]
	var lengthReference : NumberReference

	modeReference = StringReference()
	success = QRDetectMode(&chars, &modeReference, &errorMessage)

	if(success){
		modeName = modeReference.stringx

		symbolBitsSpec = GetQRSymbolLengthsForVersions()

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

		done = false
		lengthReference = NumberReference()
		i = 1.0
		while(i <= 40.0 && !done){
			success = QRComputeNumberOfCodewords(Double(chars.count), i, &modeName, &lengthReference, &errorMessage)

			if(success){
				l = lengthReference.numberValue

				if(l <= symbolBitsSpec[Int((i - 1.0)*4.0 + errorCorrectionLevelNumber)]){
					versionReference.numberValue = i
					done = true
				}
			}else{
				done = true
			}
			i = i + 1.0
		}

		if(!done){
			success = false
			errorMessage.stringx = characterArray("Too much data for any QR code.").ca
		}
	}

	return success
}


func GenerateQRCodeWithAllOptions(_ imageReference : inout RGBABitmapImageReference, _ chars : inout [Character], _ version : Double, _ errorCorrectionLevel : Character, _ quietZoneSize : Double, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var errorCorrectionLevel = errorCorrectionLevel;
	var quietZoneSize = quietZoneSize;
	var image, quietZoneImage, basis : RGBABitmapImage
	var masks, withMasks : [RGBABitmapImage]
	var size, sizeWithQuietZone, i, min, choice : Double
	var bs, formatbits, mode : [Character]
	var cws, allcws, pentalies : [Double]
	var success : Bool
	var modeReference, bsReference : StringReference

	modeReference = StringReference()
	success = QRDetectMode(&chars, &modeReference, &errorMessage)

	if(success){
		mode = modeReference.stringx

		size = QRVersionToModules(version)

		image = CreateImage(size, size, &GetTransparent().ref).ref

		QRAddTimingPattern(&image, version)

		QRAddFinderPattern(&image, version)

		QRAddAlignmentPatterns(&image, version)

		QRAddDummyFormatBits(&image, version)

		if(version >= 7.0){
			QRAddVersionBits(&image, version)
		}

		bsReference = StringReference()

		success = GetQRCodewordBitSequence(&chars, version, &mode, &bsReference, &errorMessage)

		if(success){
			bs = bsReference.stringx

			cws = QRSegmentsToCodeWords(&bs, version, errorCorrectionLevel)
			allcws = QRAddErrorCodesAndInterleave(&cws, version, errorCorrectionLevel)

			basis = CopyImage(&image).ref

			QRAddCodewords(&image, version, &allcws)

			formatbits = Array(repeating:Character(" "), count: Int(15))

			masks = Array(repeating:RGBABitmapImage(), count: Int(8))
			withMasks = Array(repeating:RGBABitmapImage(), count: Int(8))
			pentalies = Array(repeating:Double(), count: Int(8))
			i = 0.0
			while(i < 8.0){
				masks[Int(i)] = CreateMask(i, version).ref
				withMasks[Int(i)] = QRApplyMask(&basis, &image, &masks[Int(i)]).ref
				QRComputeFormatBits(&formatbits, errorCorrectionLevel, i)
				QRAddFormatBits(&withMasks[Int(i)], &formatbits)
				/*System.out.println("Mask " + (int)i);*/
				pentalies[Int(i)] = QRComputePenalty(&withMasks[Int(i)])
				i = i + 1.0
			}

			choice = 0.0
			min = pentalies[Int(choice)]
			i = 0.0
			while(i < 8.0){
				if(pentalies[Int(i)] < min){
					choice = i
					min = pentalies[Int(choice)]
				}
				i = i + 1.0
			}

			image = withMasks[Int(choice)]

			sizeWithQuietZone = size + 2.0*quietZoneSize
			quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, &GetWhite().ref).ref
			DrawImageOnImage(&quietZoneImage, &image, quietZoneSize, quietZoneSize)

			imageReference.image = quietZoneImage
		}
	}

	return success
}


func GetQRCodewordBitSequence(_ chars : inout [Character], _ version : Double, _ modeName : inout [Character], _ bsReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var success : Bool

	if(arraysStringsEqual(&modeName, &characterArray("Numeric").ca)){
		success = QRNumericDataToSegment(&chars, version, &bsReference, &errorMessage)
	}else if(arraysStringsEqual(&modeName, &characterArray("Alphanumeric").ca)){
		success = QRAlphanumericDataToSegment(&chars, version, &bsReference, &errorMessage)
	}else if(arraysStringsEqual(&modeName, &characterArray("8-bit Byte").ca)){
		success = QR8BitByteDataToSegment(&chars, version, &bsReference, &errorMessage)
	}else{
		success = false
		errorMessage.stringx = characterArray("Invalid data mode.").ca
	}

	return success
}


func QRComputeNumberOfCodewords(_ dataLength : Double, _ version : Double, _ modeName : inout [Character], _ lengthReference : inout NumberReference, _ errorMessage : inout StringReference) -> Bool{
	var dataLength = dataLength;
	var version = version;
	var length, r, last, c : Double
	var success : Bool
	var countReference : NumberReference

	length = 0.0
	countReference = NumberReference()

	success = QRGetCountLength(version, &modeName, &countReference, &errorMessage)

	if(success){
		c = countReference.numberValue

		if(arraysStringsEqual(&modeName, &characterArray("Numeric").ca)){
			r = 0.0
			last = dataLength.truncatingRemainder(dividingBy:3.0)
			if(last == 0.0){
				r = 0.0
			}else if(last == 1.0){
				r = 4.0
			}else if(last == 2.0){
				r = 7.0
			}

			length = 4.0 + c + 10.0*floor(dataLength/3.0) + r
		}else if(arraysStringsEqual(&modeName, &characterArray("Alphanumeric").ca)){
			length = 4.0 + c + 11.0*floor(dataLength/2.0) + 6.0*(dataLength.truncatingRemainder(dividingBy:2.0))
		}else if(arraysStringsEqual(&modeName, &characterArray("8-bit Byte").ca)){
			length = 4.0 + c + 8.0*dataLength
		}else{
			success = false
		}
	}else{
		success = false
	}

	if(success){
		lengthReference.numberValue = length
	}

	return success
}


func QRAddVersionBits(_ image : inout RGBABitmapImage, _ version : Double) -> Void{
	var version = version;
	var ecc, i, x, y, offset : Double
	var str : StringReference
	var code : [Character]

	ecc = ComputeBHC18_6Code(version)

	code = Array(repeating:Character(" "), count: Int(18))

	str = StringReference()
	CreateStringFromNumberWithCheck(version, 2.0, &str)

	offset = 6.0 - Double(str.stringx.count)
	i = 0.0
	while(i < 6.0){
		if(i < offset){
			code[Int(i)] = "0"
		}else{
			code[Int(i)] = str.stringx[Int(i - offset)]
		}
		i = i + 1.0
	}

	CreateStringFromNumberWithCheck(ecc, 2.0, &str)

	offset = 12.0 - Double(str.stringx.count)
	i = 0.0
	while(i < 12.0){
		if(i < offset){
			code[Int(6.0 + i)] = "0"
		}else{
			code[Int(6.0 + i)] = str.stringx[Int(i - offset)]
		}
		i = i + 1.0
	}

	i = 0.0
	while(i < 18.0){
		x = ImageWidth(&image) - 11.0 + i.truncatingRemainder(dividingBy:3.0)
		y = 0.0 + floor(i/3.0)

		if(code[Int(18.0 - 1.0 - i)] == "1"){
			SetPixel(&image, x, y, &GetBlack().ref)
			SetPixel(&image, y, x, &GetBlack().ref)
		}else{
			SetPixel(&image, x, y, &GetWhite().ref)
			SetPixel(&image, y, x, &GetWhite().ref)
		}
		i = i + 1.0
	}
}


func QRAddAlignmentPatterns(_ image : inout RGBABitmapImage, _ version : Double) -> Void{
	var version = version;
	var i, j, x, y, nrOfPositions : Double
	var positions, col2, col3, col4, col5, col6, col7 : [Double]
	var includePattern : Bool

	positions = Array(repeating:Double(), count: Int(7))

	col2 = StringToNumberArray(&characterArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30").ca)
	col3 = StringToNumberArray(&characterArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58").ca)
	col4 = StringToNumberArray(&characterArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86").ca)
	col5 = StringToNumberArray(&characterArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114").ca)
	col6 = StringToNumberArray(&characterArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142").ca)
	col7 = StringToNumberArray(&characterArray("150, 154, 158, 162, 166, 170").ca)

	positions[Int(0)] = 6.0
	nrOfPositions = 0.0

	if(version == 1.0){
		nrOfPositions = 0.0
	}
	if(version >= 2.0){
		nrOfPositions = 2.0
		positions[Int(1)] = col2[Int(version - 2.0)]
	}
	if(version >= 7.0){
		nrOfPositions = 3.0
		positions[Int(2)] = col3[Int(version - 7.0)]
	}
	if(version >= 14.0){
		nrOfPositions = 4.0
		positions[Int(3)] = col4[Int(version - 14.0)]
	}
	if(version >= 21.0){
		nrOfPositions = 5.0
		positions[Int(4)] = col5[Int(version - 21.0)]
	}
	if(version >= 28.0){
		nrOfPositions = 6.0
		positions[Int(5)] = col6[Int(version - 28.0)]
	}
	if(version >= 35.0){
		nrOfPositions = 7.0
		positions[Int(6)] = col7[Int(version - 35.0)]
	}

	i = 0.0
	while(i < nrOfPositions){
		j = 0.0
		while(j < nrOfPositions){
			x = positions[Int(i)]
			y = positions[Int(j)]

			if(x <= 8.0 && y <= 8.0){
				includePattern = false
			}else if(x >= ImageWidth(&image) - 8.0 && y <= 8.0){
				includePattern = false
			}else if(x <= 8.0 && y >= ImageWidth(&image) - 7.0){
				includePattern = false
			}else{
				includePattern = true
			}

			if(includePattern){
				QRAddAlignmentPattern(&image, x, y)
			}
			j = j + 1.0
		}
		i = i + 1.0
	}
}


func QRAddAlignmentPattern(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double) -> Void{
	var x = x;
	var y = y;
	DrawRectangle1px(&image, x, y, 0.0, 0.0, &GetBlack().ref)
	DrawRectangle1px(&image, x - 1.0, y - 1.0, 2.0, 2.0, &GetWhite().ref)
	DrawRectangle1px(&image, x - 2.0, y - 2.0, 4.0, 4.0, &GetBlack().ref)
}


func QR8BitByteDataToSegment(_ data : inout [Character], _ version : Double, _ bsReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var bs, mode : [Character]
	var length, c, d, i, n, j, offset : Double
	var nstr : StringReference
	var lengthReference, countReference : NumberReference
	var success : Bool

	countReference = NumberReference()
	success = QRGetCountLength(version, &characterArray("8-bit Byte").ca, &countReference, &errorMessage)

	if(success){
		c = countReference.numberValue
		d = Double(data.count)

		lengthReference = NumberReference()
		success = QRComputeNumberOfCodewords(Double(data.count), version, &characterArray("8-bit Byte").ca, &lengthReference, &errorMessage)

		if(success){
			length = lengthReference.numberValue

			bs = arraysCreateString(length, "0")

			/* Characters*/
			nstr = StringReference()

			i = 0.0
			while(i < d){
				n = charToDouble(data[Int(i)])

				CreateStringFromNumberWithCheck(n, 2.0, &nstr)

				offset = 8.0 - Double(nstr.stringx.count)
				j = 0.0
				while(j < Double(nstr.stringx.count)){
					bs[Int(4.0 + c + 8.0*i + j + offset)] = nstr.stringx[Int(j)]
					j = j + 1.0
				}
				i = i + 1.0
			}

			/* Character count*/
			CreateStringFromNumberWithCheck(d, 2.0, &nstr)
			offset = 4.0 + c - Double(nstr.stringx.count)
			j = 0.0
			while(j < Double(nstr.stringx.count)){
				bs[Int(offset + j)] = nstr.stringx[Int(j)]
				j = j + 1.0
			}

			/* Mode*/
			mode = QR8BitByteModeIndicator()
			j = 0.0
			while(j < 4.0){
				bs[Int(j)] = mode[Int(j)]
				j = j + 1.0
			}

			bsReference.stringx = bs
		}
	}

	return success
}


func QRDetectMode(_ chars : inout [Character], _ modeReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var success : Bool
	var i, mode : Double
	var c : Character

	mode = 0.0
	success = false

	i = 0.0
	while(i < Double(chars.count)){
		c = chars[Int(i)]

		if(cIsNumber(c)){
			if(mode == 0.0){
				mode = 1.0
				success = true
			}
		}else if(IsQRAlphanumericCharacter(c)){
			if(mode <= 1.0){
				mode = 2.0
				success = true
			}
		}else if(IsQRJIS8Character(c)){
			if(mode <= 2.0){
				mode = 3.0
				success = true
			}
		}else{
			mode = 5.0
			success = false
			errorMessage.stringx = characterArray("Data contains invalid characters").ca
		}
		i = i + 1.0
	}

	if(mode == 0.0){
		errorMessage.stringx = characterArray("There is no data to put in the QR code.").ca
	}
	if(mode == 1.0){
		modeReference.stringx = characterArray("Numeric").ca
	}
	if(mode == 2.0){
		modeReference.stringx = characterArray("Alphanumeric").ca
	}
	if(mode == 3.0){
		modeReference.stringx = characterArray("8-bit Byte").ca
	}

	return success
}


func QRComputePenalty(_ image : inout RGBABitmapImage) -> Double{
	var totalP, runP, boxP, findP, balP : Double

	runP = QRComputePenaltyForRuns(&image)
	/*System.out.println("runP: " + ", " + (int)runP);*/
	boxP = QRComputePenaltyForBoxes(&image)
	/*System.out.println("boxP: " + ", " + (int)boxP);*/
	findP = QRComputePenaltyForFinders(&image)
	/*System.out.println("findP: " + ", " + (int)findP);*/
	balP = QRComputePenaltyForBalance(&image)
	/*System.out.println("balP: " + ", " + (int)balP);*/
	/* Total penalty*/
	totalP = runP + boxP + balP + findP + balP
	/*System.out.println(totalP);*/
	return totalP
}


func QRComputePenaltyForBalance(_ image : inout RGBABitmapImage) -> Double{
	var x, y, h, w, balP, total, black, deviation : Double
	var isBlack : Bool

	h = ImageHeight(&image)
	w = ImageWidth(&image)

	total = h*w
	black = 0.0

	y = 0.0
	while(y < h){
		x = 0.0
		while(x < w){
			isBlack = PixelIsBlack(&image, x, y)

			if(isBlack){
				black = black + 1.0
			}
			x = x + 1.0
		}
		y = y + 1.0
	}

	deviation = abs(100.0*black/total - 50.0)
	balP = floor(deviation/5.0)*10.0

	return balP
}


func QRComputePenaltyForFinders(_ image : inout RGBABitmapImage) -> Double{
	var x, y, h, w, findP : Double
	var d1, w1, d2, d3, d4, w2, d5, w3, w4, w5, w6 : Bool

	h = ImageHeight(&image)
	w = ImageWidth(&image)

	findP = 0.0
	y = 0.0
	while(y < h){
		x = 0.0
		while(x < w - 10.0){
			d1 = PixelIsBlack(&image, x + 0.0, y)
			w1 = PixelIsBlack(&image, x + 1.0, y)
			d2 = PixelIsBlack(&image, x + 2.0, y)
			d3 = PixelIsBlack(&image, x + 3.0, y)
			d4 = PixelIsBlack(&image, x + 4.0, y)
			w2 = PixelIsBlack(&image, x + 5.0, y)
			d5 = PixelIsBlack(&image, x + 6.0, y)
			w3 = PixelIsBlack(&image, x + 7.0, y)
			w4 = PixelIsBlack(&image, x + 8.0, y)
			w5 = PixelIsBlack(&image, x + 9.0, y)
			w6 = PixelIsBlack(&image, x + 10.0, y)

			if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
				findP = findP + 40.0
			}

			w3 = PixelIsBlack(&image, x + 0.0, y)
			w4 = PixelIsBlack(&image, x + 1.0, y)
			w5 = PixelIsBlack(&image, x + 2.0, y)
			w6 = PixelIsBlack(&image, x + 3.0, y)
			d1 = PixelIsBlack(&image, x + 4.0, y)
			w1 = PixelIsBlack(&image, x + 5.0, y)
			d2 = PixelIsBlack(&image, x + 6.0, y)
			d3 = PixelIsBlack(&image, x + 7.0, y)
			d4 = PixelIsBlack(&image, x + 8.0, y)
			w2 = PixelIsBlack(&image, x + 9.0, y)
			d5 = PixelIsBlack(&image, x + 10.0, y)

			if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
				findP = findP + 40.0
			}
			x = x + 1.0
		}
		y = y + 1.0
	}

	x = 0.0
	while(x < w){
		y = 0.0
		while(y < h - 10.0){
			d1 = PixelIsBlack(&image, x, y + 0.0)
			w1 = PixelIsBlack(&image, x, y + 1.0)
			d2 = PixelIsBlack(&image, x, y + 2.0)
			d3 = PixelIsBlack(&image, x, y + 3.0)
			d4 = PixelIsBlack(&image, x, y + 4.0)
			w2 = PixelIsBlack(&image, x, y + 5.0)
			d5 = PixelIsBlack(&image, x, y + 6.0)
			w3 = PixelIsBlack(&image, x, y + 7.0)
			w4 = PixelIsBlack(&image, x, y + 8.0)
			w5 = PixelIsBlack(&image, x, y + 9.0)
			w6 = PixelIsBlack(&image, x, y + 10.0)

			if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
				findP = findP + 40.0
			}

			w3 = PixelIsBlack(&image, x, y + 0.0)
			w4 = PixelIsBlack(&image, x, y + 1.0)
			w5 = PixelIsBlack(&image, x, y + 2.0)
			w6 = PixelIsBlack(&image, x, y + 3.0)
			d1 = PixelIsBlack(&image, x, y + 4.0)
			w1 = PixelIsBlack(&image, x, y + 5.0)
			d2 = PixelIsBlack(&image, x, y + 6.0)
			d3 = PixelIsBlack(&image, x, y + 7.0)
			d4 = PixelIsBlack(&image, x, y + 8.0)
			w2 = PixelIsBlack(&image, x, y + 9.0)
			d5 = PixelIsBlack(&image, x, y + 10.0)

			if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
				findP = findP + 40.0
			}
			y = y + 1.0
		}
		x = x + 1.0
	}

	return findP
}


func QRComputePenaltyForBoxes(_ image : inout RGBABitmapImage) -> Double{
	var x, y, h, w, boxP : Double
	var ul, ur, ll, lr : Bool

	h = ImageHeight(&image)
	w = ImageWidth(&image)

	boxP = 0.0
	y = 0.0
	while(y < h - 1.0){
		x = 0.0
		while(x < w - 1.0){
			ul = PixelIsBlack(&image, x + 0.0, y + 0.0)
			ur = PixelIsBlack(&image, x + 1.0, y + 0.0)
			ll = PixelIsBlack(&image, x + 0.0, y + 1.0)
			lr = PixelIsBlack(&image, x + 1.0, y + 1.0)

			if(ul && ur && ll && lr || !ul && !ur && !ll && !lr){
				boxP = boxP + 3.0
			}
			x = x + 1.0
		}
		y = y + 1.0
	}

	return boxP
}


func PixelIsBlack(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double) -> Bool{
	var x = x;
	var y = y;
	return GetImagePixel(&image, x, y).ref.r == 0.0
}


func QRComputePenaltyForRuns(_ image : inout RGBABitmapImage) -> Double{
	var first, prev, cur : Bool
	var run, x, y, h, w, runP : Double
	var last : Bool

	h = ImageHeight(&image)
	w = ImageWidth(&image)

	runP = 0.0

	/* Horizontal penalty*/
	y = 0.0
	while(y < h){
		first = true
		prev = true
		cur = true
		run = 1.0

		x = 0.0
		while(x <= w){
			last = x == w
			if(!last){
				cur = PixelIsBlack(&image, x, y)
			}

			if(!first){
				if(prev == cur && !last){
					run = run + 1.0
				}

				if(prev != cur || last){
					if(run >= 5.0){
						runP = runP + 3.0 + run - 5.0
					}
					run = 1.0
				}
			}

			first = false
			prev = cur
			x = x + 1.0
		}
		y = y + 1.0
	}

	/* Vertical penalty*/
	x = 0.0
	while(x < w){
		first = true
		prev = true
		cur = true
		run = 1.0

		y = 0.0
		while(y <= h){
			last = y == h
			if(!last){
				cur = PixelIsBlack(&image, x, y)
			}

			if(!first){
				if(prev == cur && !last){
					run = run + 1.0
				}

				if(prev != cur || last){
					if(run >= 5.0){
						runP = runP + 3.0 + run - 5.0
					}
					run = 1.0
				}
			}

			first = false
			prev = cur
			y = y + 1.0
		}
		x = x + 1.0
	}
	return runP
}


func QRAddFormatBits(_ image : inout RGBABitmapImage, _ formatbits : inout [Character]) -> Void{
	var b : Character
	var i, x, y : Double
	var black, white, color : RGBA

	black = GetBlack().ref
	white = GetWhite().ref

	x = 8.0
	y = 0.0

	/* Upper-left*/
	i = 0.0
	while(i < Double(formatbits.count)){
		b = formatbits[Int(14.0 - i)]
		if(b == "1"){
			color = black
		}else{
			color = white
		}

		SetPixel(&image, x, y, &color)

		if(i < 7.0){
			y = y + 1.0
		}
		if(i == 5.0){
			y = y + 1.0
		}

		if(i >= 7.0){
			x = x - 1.0
		}
		if(i == 8.0){
			x = x - 1.0
		}
		i = i + 1.0
	}

	/* Lower left and top right*/
	x = ImageWidth(&image) - 1.0
	y = 8.0

	i = 0.0
	while(i < Double(formatbits.count)){
		b = formatbits[Int(14.0 - i)]
		if(b == "1"){
			color = black
		}else{
			color = white
		}

		SetPixel(&image, x, y, &color)

		if(i < 7.0){
			x = x - 1.0
		}
		if(i == 7.0){
			y = ImageHeight(&image) - 7.0
			x = 8.0
		}

		if(i > 7.0){
			y = y + 1.0
		}
		i = i + 1.0
	}
}


func QRComputeFormatBits(_ bits : inout [Character], _ errorCorrectionLevel : Character, _ mask : Double) -> Void{
	var errorCorrectionLevel = errorCorrectionLevel;
	var mask = mask;
	var i, bhc, offset, errorCorrectionCode, n : Double
	var xorpattern : [Character]
	var str : StringReference
	var a, b, r : Bool

	errorCorrectionCode = 0.0
	if(errorCorrectionLevel == "L"){
		errorCorrectionCode = 1.0
	}else if(errorCorrectionLevel == "M"){
		errorCorrectionCode = 0.0
	}else if(errorCorrectionLevel == "Q"){
		errorCorrectionCode = 3.0
	}else if(errorCorrectionLevel == "H"){
		errorCorrectionCode = 2.0
	}

	n = OrByte(ShiftLeftByte(errorCorrectionCode, 3.0), mask)

	bhc = ComputeBHC15_5Code(n)

	n = Or4Byte(ShiftLeft4Byte(n, 10.0), bhc)

	str = StringReference()
	CreateStringFromNumberWithCheck(n, 2.0, &str)

	offset = 15.0 - Double(str.stringx.count)
	i = 0.0
	while(i < 15.0){
		if(i < offset){
			bits[Int(i)] = "0"
		}else{
			bits[Int(i)] = str.stringx[Int(i - offset)]
		}
		i = i + 1.0
	}

	xorpattern = characterArray("101010000010010").ca

	i = 0.0
	while(i < 15.0){
		a = bits[Int(i)] == "1"
		b = xorpattern[Int(i)] == "1"

		r = Xor(a, b)

		if(r){
			bits[Int(i)] = "1"
		}else{
			bits[Int(i)] = "0"
		}
		i = i + 1.0
	}
}


func QRApplyMask(_ basis : inout RGBABitmapImage, _ image : inout RGBABitmapImage, _ mask : inout RGBABitmapImage) -> RGBABitmapImageReferenceClass{
	var withMask : RGBABitmapImage
	var i, j : Double
	var a, b, r : Bool

	withMask = CopyImage(&image).ref

	i = 0.0
	while(i < ImageWidth(&basis)){
		j = 0.0
		while(j < ImageHeight(&basis)){
			if(GetImagePixel(&basis, i, j).ref.a == 0.0){
				a = PixelIsBlack(&image, i, j)
				b = PixelIsBlack(&mask, i, j)

				/* xor*/
				r = Xor(a, b)

				if(r){
					SetPixel(&withMask, i, j, &GetBlack().ref)
				}else{
					SetPixel(&withMask, i, j, &GetWhite().ref)
				}
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = withMask
	return returnReference
}


func Xor(_ a : Bool, _ b : Bool) -> Bool{
	var a = a;
	var b = b;
	return a && !b || !a && b
}


func CreateMask(_ mask : Double, _ version : Double) -> RGBABitmapImageReferenceClass{
	var mask = mask;
	var version = version;
	var size, i, j : Double
	var black : Bool
	var image : RGBABitmapImage

	size = QRVersionToModules(version)

	image = CreateImage(size, size, &GetTransparent().ref).ref

	black = true
	i = 0.0
	while(i < size){
		j = 0.0
		while(j < size){
			if(mask == 0.0){
				black = (i + j).truncatingRemainder(dividingBy:2.0) == 0.0
			}else if(mask == 1.0){
				black = i.truncatingRemainder(dividingBy:2.0) == 0.0
			}else if(mask == 2.0){
				black = j.truncatingRemainder(dividingBy:3.0) == 0.0
			}else if(mask == 3.0){
				black = (i + j).truncatingRemainder(dividingBy:3.0) == 0.0
			}else if(mask == 4.0){
				black = (floor(i/2.0) + floor(j/3.0)).truncatingRemainder(dividingBy:2.0) == 0.0
			}else if(mask == 5.0){
				black = (i*j).truncatingRemainder(dividingBy:2.0) + (i*j).truncatingRemainder(dividingBy:3.0) == 0.0
			}else if(mask == 6.0){
				black = ((i*j).truncatingRemainder(dividingBy:2.0) + (i*j).truncatingRemainder(dividingBy:3.0)).truncatingRemainder(dividingBy:2.0) == 0.0
			}else if(mask == 7.0){
				black = ((i*j).truncatingRemainder(dividingBy:3.0) + (i + j).truncatingRemainder(dividingBy:2.0)).truncatingRemainder(dividingBy:2.0) == 0.0
			}

			if(black){
				SetPixel(&image, j, i, &GetBlack().ref)
			}else{
				SetPixel(&image, j, i, &GetWhite().ref)
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func QRAddDummyFormatBits(_ image : inout RGBABitmapImage, _ version : Double) -> Void{
	var version = version;
	var i, size : Double

	size = QRVersionToModules(version)

	i = 0.0
	while(i < 9.0){
		if(i != 6.0){
			SetPixel(&image, i, 8.0, &GetWhite().ref)
			SetPixel(&image, 8.0, i, &GetWhite().ref)
		}
		if(i != 8.0){
			SetPixel(&image, size - 1.0 - i, 8.0, &GetWhite().ref)
			SetPixel(&image, 8.0, size - 1.0 - i, &GetWhite().ref)
		}
		i = i + 1.0
	}

	SetPixel(&image, 8.0, size - 8.0, &GetBlack().ref)
}


func QRAddCodewords(_ image : inout RGBABitmapImage, _ version : Double, _ cws : inout [Double]) -> Void{
	var version = version;
	var ll : LinkedListCharacters
	var i, j, x, y, size, offset, bit : Double
	var s : StringReference
	var bits : [Character]
	var b : Character
	var w, d : Bool
        
	ll = CreateLinkedListCharacter().ref
	s = StringReference()
        
	i = 0.0
	while(i < Double(cws.count)){
		CreateStringFromNumberWithCheck(cws[Int(i)], 2.0, &s)

		offset = 8.0 - Double(s.stringx.count)
		j = 0.0
		while(j < 8.0){
			if(j < offset){
				LinkedListAddCharacter(&ll, "0")
			}else{
				LinkedListAddCharacter(&ll, s.stringx[Int(j - offset)])
			}
			j = j + 1.0
		}

		delete(s.stringx)
		i = i + 1.0
	}

	bits = LinkedListCharactersToArray(&ll)

	size = QRVersionToModules(version)
	x = size - 1.0
	y = size - 1.0
	d = true
	w = true
	bit = 0.0
	offset = 0.0
	i = 0.0
	while(i < pow(size, 2.0) - size){
		if(GetImagePixel(&image, x - offset, y).ref.a == 0.0){
			if(bit < Double(bits.count)){
				b = bits[Int(bit)]

				if(b == "1"){
					SetPixel(&image, (x - offset), y, &GetBlack().ref)
				}else{
					SetPixel(&image, (x - offset), y, &GetWhite().ref)
				}

				bit = bit + 1.0
			}else{
				/* Some symbols have nothing at the end.*/
				SetPixel(&image, (x - offset), y, &GetWhite().ref)
			}
		}

		if(d){
			if(w){
				x = x - 1.0
			}else{
				x = x + 1.0
				y = y - 1.0
			}
		}else if(w){
			x = x - 1.0
		}else{
			x = x + 1.0
			y = y + 1.0
		}

		w = !w

		if(i.truncatingRemainder(dividingBy:2.0*size) == 2.0*size - 1.0){
			if(d){
				x = x - 2.0
				y = y + 1.0
				w = true
			}else{
				x = x - 2.0
				y = y - 1.0
				w = true
			}

			d = !d
		}

		if(x == 6.0){
			offset = 1.0
		}
		i = i + 1.0
	}
}


func QRAddTimingPattern(_ image : inout RGBABitmapImage, _ version : Double) -> Void{
	var version = version;
	var size, i : Double
	var black : Bool

	size = QRVersionToModules(version)

	black = true
	i = 0.0
	while(i < size){
		if(black){
			SetPixel(&image, i, 6.0, &GetBlack().ref)
			SetPixel(&image, 6.0, i, &GetBlack().ref)
		}else{
			SetPixel(&image, i, 6.0, &GetWhite().ref)
			SetPixel(&image, 6.0, i, &GetWhite().ref)
		}

		black = !black
		i = i + 1.0
	}
}


func QRAddFinderPattern(_ image : inout RGBABitmapImage, _ version : Double) -> Void{
	var version = version;
	var finderPattern : RGBABitmapImage
	var size : Double

	size = QRVersionToModules(version)
	finderPattern = GetQRFinderPattern().ref
	DrawImageOnImage(&image, &finderPattern, -1.0, -1.0)
	DrawImageOnImage(&image, &finderPattern, size - 7.0 - 1.0, -1.0)
	DrawImageOnImage(&image, &finderPattern, -1.0, size - 7.0 - 1.0)
}


func GetQRFinderPattern() -> RGBABitmapImageReferenceClass{
	var fp : RGBABitmapImage

	fp = CreateImage(9.0, 9.0, &GetBlack().ref).ref

	DrawRectangle1px(&fp, 2.0, 2.0, 4.0, 4.0, &GetWhite().ref)
	DrawRectangle1px(&fp, 0.0, 0.0, 8.0, 8.0, &GetWhite().ref)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func QRQuietZoneSize() -> Double{
	return 4.0
}


func QRVersionToModules(_ version : Double) -> Double{
	var version = version;
	return 17.0 + 4.0*version
}


func QRNumericDataToSegment(_ data : inout [Character], _ version : Double, _ bsReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var bs, group, mode : [Character]
	var length, c, d, r, i, n, j, offset, last : Double
	var nstr : StringReference
	var countReference, lengthReference : NumberReference
	var success : Bool

	countReference = NumberReference()
	success = QRGetCountLength(version, &characterArray("Numeric").ca, &countReference, &errorMessage)

	if(success){
		c = countReference.numberValue
		d = Double(data.count)

		r = 0.0
		last = d.truncatingRemainder(dividingBy:3.0)
		if(last == 0.0){
			r = 0.0
		}else if(last == 1.0){
			r = 4.0
		}else if(last == 2.0){
			r = 7.0
		}

		lengthReference = NumberReference()
		success = QRComputeNumberOfCodewords(Double(data.count), version, &characterArray("Numeric").ca, &lengthReference, &errorMessage)
		if(success){
			length = lengthReference.numberValue

			bs = arraysCreateString(length, "0")

			/* Characters*/
			group = Array(repeating:Character(" "), count: Int(3))
			nstr = StringReference()

			i = 0.0
			while(i < floor(d/3.0)){
				group[Int(0)] = data[Int(i*3.0 + 0.0)]
				group[Int(1)] = data[Int(i*3.0 + 1.0)]
				group[Int(2)] = data[Int(i*3.0 + 2.0)]

				n = CreateNumberFromDecimalString(&group)
				CreateStringFromNumberWithCheck(n, 2.0, &nstr)

				offset = 10.0 - Double(nstr.stringx.count)
				j = 0.0
				while(j < Double(nstr.stringx.count)){
					bs[Int(4.0 + c + i*10.0 + offset + j)] = nstr.stringx[Int(j)]
					j = j + 1.0
				}
				i = i + 1.0
			}

			if(last == 1.0){
				group[Int(0)] = "0"
				group[Int(1)] = "0"
				group[Int(2)] = data[Int(Double(data.count) - 1.0)]
			}

			if(last == 2.0){
				group[Int(0)] = "0"
				group[Int(1)] = data[Int(Double(data.count) - 2.0)]
				group[Int(2)] = data[Int(Double(data.count) - 1.0)]
			}

			if(last == 1.0 || last == 2.0){
				n = CreateNumberFromDecimalString(&group)
				CreateStringFromNumberWithCheck(n, 2.0, &nstr)

				offset = r - Double(nstr.stringx.count)
				j = 0.0
				while(j < Double(nstr.stringx.count)){
					bs[Int(Double(bs.count) - r + offset + j)] = nstr.stringx[Int(j)]
					j = j + 1.0
				}
			}

			/* Character count*/
			CreateStringFromNumberWithCheck(d, 2.0, &nstr)
			offset = 4.0 + c - Double(nstr.stringx.count)
			j = 0.0
			while(j < Double(nstr.stringx.count)){
				bs[Int(offset + j)] = nstr.stringx[Int(j)]
				j = j + 1.0
			}

			/* Mode*/
			mode = QRNumericModeIndicator()
			j = 0.0
			while(j < 4.0){
				bs[Int(j)] = mode[Int(j)]
				j = j + 1.0
			}

			bsReference.stringx = bs
		}
	}

	return success
}


func QRGetCountLength(_ version : Double, _ modeName : inout [Character], _ cReference : inout NumberReference, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var c : Double
	var success : Bool

	success = true
	c = 0.0

	if(arraysStringsEqual(&modeName, &characterArray("Numeric").ca)){
		if(version >= 1.0 && version <= 9.0){
			c = 10.0
		}else if(version >= 10.0 && version <= 26.0){
			c = 12.0
		}else if(version >= 27.0 && version <= 40.0){
			c = 14.0
		}else{
			success = false
			errorMessage.stringx = characterArray("Invalid version number.").ca
		}
	}else if(arraysStringsEqual(&modeName, &characterArray("Alphanumeric").ca)){
		if(version >= 1.0 && version <= 9.0){
			c = 9.0
		}else if(version >= 10.0 && version <= 26.0){
			c = 11.0
		}else if(version >= 27.0 && version <= 40.0){
			c = 13.0
		}else{
			success = false
			errorMessage.stringx = characterArray("Invalid version number.").ca
		}
	}else if(arraysStringsEqual(&modeName, &characterArray("8-bit Byte").ca)){
		if(version >= 1.0 && version <= 9.0){
			c = 8.0
		}else if(version >= 10.0 && version <= 26.0){
			c = 16.0
		}else if(version >= 27.0 && version <= 40.0){
			c = 16.0
		}else{
			success = false
			errorMessage.stringx = characterArray("Invalid version number.").ca
		}
	}else{
		success = false
		errorMessage.stringx = characterArray("Invalid mode name.").ca
	}

	if(success){
		cReference.numberValue = c
	}

	return success
}


func QRNumericModeIndicator() -> [Character]{
	return characterArray("0001").ca
}


func QRAlphanumericModeIndicator() -> [Character]{
	return characterArray("0010").ca
}


func QRTerminatorModeIndicator() -> [Character]{
	return characterArray("0000").ca
}


func QR8BitByteModeIndicator() -> [Character]{
	return characterArray("0100").ca
}


func QRKanjiModeIndicator() -> [Character]{
	return characterArray("1000").ca
}


func QRAlphanumericDataToSegment(_ data : inout [Character], _ version : Double, _ bsReference : inout StringReference, _ errorMessage : inout StringReference) -> Bool{
	var version = version;
	var bs, mode : [Character]
	var length, c, d, i, n, j, offset, c0, c1 : Double
	var nstr : StringReference
	var success : Bool
	var lengthReference, countReference : NumberReference

	countReference = NumberReference()
	success = QRGetCountLength(version, &characterArray("Alphanumeric").ca, &countReference, &errorMessage)

	if(success){
		c = countReference.numberValue
		d = Double(data.count)

		lengthReference = NumberReference()
		success = QRComputeNumberOfCodewords(Double(data.count), version, &characterArray("Alphanumeric").ca, &lengthReference, &errorMessage)

		if(success){
			length = lengthReference.numberValue

			bs = arraysCreateString(length, "0")

			/* Characters*/
			nstr = StringReference()

			i = 0.0
			while(i < floor(d/2.0)){
				c0 = QRAlphanumericToCode(data[Int(i*2.0 + 0.0)])
				c1 = QRAlphanumericToCode(data[Int(i*2.0 + 1.0)])

				n = c0*45.0 + c1

				CreateStringFromNumberWithCheck(n, 2.0, &nstr)

				offset = 11.0 - Double(nstr.stringx.count)
				j = 0.0
				while(j < Double(nstr.stringx.count)){
					bs[Int(4.0 + c + i*11.0 + offset + j)] = nstr.stringx[Int(j)]
					j = j + 1.0
				}
				i = i + 1.0
			}

			if(d.truncatingRemainder(dividingBy:2.0) == 1.0){
				n = QRAlphanumericToCode(data[Int(Double(data.count) - 1.0)])

				CreateStringFromNumberWithCheck(n, 2.0, &nstr)

				offset = 6.0 - Double(nstr.stringx.count)
				j = 0.0
				while(j < Double(nstr.stringx.count)){
					bs[Int(Double(bs.count) - 6.0 + offset + j)] = nstr.stringx[Int(j)]
					j = j + 1.0
				}
			}

			/* Character count*/
			CreateStringFromNumberWithCheck(d, 2.0, &nstr)
			offset = 4.0 + c - Double(nstr.stringx.count)
			j = 0.0
			while(j < Double(nstr.stringx.count)){
				bs[Int(offset + j)] = nstr.stringx[Int(j)]
				j = j + 1.0
			}

			/* Mode*/
			mode = QRAlphanumericModeIndicator()
			j = 0.0
			while(j < 4.0){
				bs[Int(j)] = mode[Int(j)]
				j = j + 1.0
			}

			bsReference.stringx = bs
		}
	}

	return success
}


func QRSegmentsToCodeWords(_ data : inout [Character], _ version : Double, _ errorCorrectionLevelCode : Character) -> [Double]{
	var version = version;
	var errorCorrectionLevelCode = errorCorrectionLevelCode;
	var symbolBits, terminatorLength, d, n, padding, cw, j, r, errorCorrectionLevelNumber : Double
	var codewords, symbolBitsSpec : [Double]
	var str : [Character]
	var nref : NumberReference
	var errorMessage : StringReference
	var padSymbol : Bool

	symbolBitsSpec = GetQRSymbolLengthsForVersions()

	errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

	symbolBits = symbolBitsSpec[Int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]

	terminatorLength = min(symbolBits - Double(data.count), 4.0)

	d = Double(data.count) + terminatorLength
	n = ceil(d/8.0)
	padding = n*8.0 - d

	codewords = Array(repeating:Double(), count: Int(floor(symbolBits/8.0)))

	str = Array(repeating:Character(" "), count: Int(8))
	nref = NumberReference()
	errorMessage = StringReference()

	cw = 0.0
	while(cw < floor(Double(data.count)/8.0)){
		str[Int(0)] = data[Int(cw*8.0 + 0.0)]
		str[Int(1)] = data[Int(cw*8.0 + 1.0)]
		str[Int(2)] = data[Int(cw*8.0 + 2.0)]
		str[Int(3)] = data[Int(cw*8.0 + 3.0)]
		str[Int(4)] = data[Int(cw*8.0 + 4.0)]
		str[Int(5)] = data[Int(cw*8.0 + 5.0)]
		str[Int(6)] = data[Int(cw*8.0 + 6.0)]
		str[Int(7)] = data[Int(cw*8.0 + 7.0)]

		CreateNumberFromStringWithCheck(&str, 2.0, &nref, &errorMessage)

		codewords[Int(cw)] = nref.numberValue
		cw = cw + 1.0
	}

	/* Remaining data, terminator and bit-padding.*/
	r = Double(data.count).truncatingRemainder(dividingBy:8.0)
	if(r != 0.0){
		j = 0.0
		while(j < 8.0){
			if(j < r){
				str[Int(j)] = data[Int(Double(data.count) - r + j)]
			}else{
				str[Int(j)] = "0"
			}
			j = j + 1.0
		}

		CreateNumberFromStringWithCheck(&str, 2.0, &nref, &errorMessage)

		codewords[Int(cw)] = nref.numberValue
		cw = cw + 1.0
	}

	if(r == 0.0 && terminatorLength + padding == 8.0){
		codewords[Int(cw)] = 0.0
		cw = cw + 1.0
	}else if(8.0 - r >= terminatorLength + padding){
	}else{
		codewords[Int(cw)] = 0.0
		cw = cw + 1.0
	}

	/* Byte Padding*/
	padSymbol = true
	while(cw < Double(codewords.count)){
		if(padSymbol){
			codewords[Int(cw)] = 236.0
		}else{
			codewords[Int(cw)] = 17.0
		}
		padSymbol = !padSymbol
		cw = cw + 1.0
	}

	return codewords
}


func GetQRSymbolLengthsForVersions() -> [Double]{
	return StringToNumberArray(&characterArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208").ca)
}


func QREccLetterToNumber(_ errorCorrectionLevelCode : Character) -> Double{
	var errorCorrectionLevelCode = errorCorrectionLevelCode;
	var errorCorrectionLevelNumber : Double

	errorCorrectionLevelNumber = 0.0

	if(errorCorrectionLevelCode == "L"){
		errorCorrectionLevelNumber = 0.0
	}else if(errorCorrectionLevelCode == "M"){
		errorCorrectionLevelNumber = 1.0
	}else if(errorCorrectionLevelCode == "Q"){
		errorCorrectionLevelNumber = 2.0
	}else if(errorCorrectionLevelCode == "H"){
		errorCorrectionLevelNumber = 3.0
	}
	return errorCorrectionLevelNumber
}


func ErGyldigOrgNummerString(_ orgnummer : inout [Character]) -> Bool{
	var gyldig : Bool
	var o : [Double]
	var i : Double

	o = Array(repeating:Double(), count: Int(9))

	gyldig = true

	if(Double(orgnummer.count) == 9.0){

		i = 0.0
		while(i < 9.0){
			if(cIsNumber(orgnummer[Int(i)])){
				o[Int(i)] = cCharacterToDecimalDigit(orgnummer[Int(i)])
			}else{
				gyldig = false
			}
			i = i + 1.0
		}

		if(gyldig){
			gyldig = ErGyldigOrgNummer(&o)
		}
	}else{
		gyldig = false
	}

	return gyldig
}


func ErGyldigOrgNummer(_ o : inout [Double]) -> Bool{
	var gyldig : Bool
	var sum, rest, kontrollsiffer : Double

	if(Double(o.count) == 9.0){
		sum = o[Int(0)]*3.0 + o[Int(1)]*2.0 + o[Int(2)]*7.0 + o[Int(3)]*6.0 + o[Int(4)]*5.0 + o[Int(5)]*4.0 + o[Int(6)]*3.0 + o[Int(7)]*2.0
		rest = sum.truncatingRemainder(dividingBy:11.0)
		if(rest == 0.0){
			kontrollsiffer = 0.0
		}else{
			kontrollsiffer = 11.0 - rest
		}

		gyldig = rest != 1.0 && kontrollsiffer == o[Int(8)]
	}else{
		gyldig = false
	}

	return gyldig
}


func IsValidNorwegianPersonalIdentificationNumber(_ fnummer : inout [Character], _ message : inout StringReference) -> Bool{
	var valid : Bool
	var i, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11 : Double
	var k1, k2 : Double
	var dateRef : DateReference

	valid = Double(fnummer.count) == 11.0
	if(valid){
		i = 0.0
		while(i < Double(fnummer.count)){
			if(cIsNumber(fnummer[Int(i)])){
			}else{
				valid = false
			}
			i = i + 1.0
		}

		if(valid){
			d1 = cCharacterToDecimalDigit(fnummer[Int(0)])
			d2 = cCharacterToDecimalDigit(fnummer[Int(1)])
			d3 = cCharacterToDecimalDigit(fnummer[Int(2)])
			d4 = cCharacterToDecimalDigit(fnummer[Int(3)])
			d5 = cCharacterToDecimalDigit(fnummer[Int(4)])
			d6 = cCharacterToDecimalDigit(fnummer[Int(5)])
			d7 = cCharacterToDecimalDigit(fnummer[Int(6)])
			d8 = cCharacterToDecimalDigit(fnummer[Int(7)])
			d9 = cCharacterToDecimalDigit(fnummer[Int(8)])
			d10 = cCharacterToDecimalDigit(fnummer[Int(9)])
			d11 = cCharacterToDecimalDigit(fnummer[Int(10)])

			dateRef = DateReference()
			valid = GetDateFromNorwegianPersonalIdentificationNumber(&fnummer, &dateRef, &message)

			if(valid){
				valid = IsValidDate(&dateRef.date, &message)
				if(valid){
					k1 = d1*3.0 + d2*7.0 + d3*6.0 + d4*1.0 + d5*8.0 + d6*9.0 + d7*4.0 + d8*5.0 + d9*2.0
					k1 = k1.truncatingRemainder(dividingBy:11.0)
					if(k1 != 0.0){
						k1 = 11.0 - k1
					}
					if(k1 == 10.0){
						valid = false
						message.stringx = characterArray("Control digit 1 is 10, which is invalid.").ca
					}

					if(valid){
						k2 = d1*5.0 + d2*4.0 + d3*3.0 + d4*2.0 + d5*7.0 + d6*6.0 + d7*5.0 + d8*4.0 + d9*3.0 + k1*2.0
						k2 = k2.truncatingRemainder(dividingBy:11.0)
						if(k2 != 0.0){
							k2 = 11.0 - k2
						}
						if(k2 == 10.0){
							valid = false
							message.stringx = characterArray("Control digit 2 is 10, which is invalid.").ca
						}

						if(valid){
							if(k1 == d10){
								if(k2 == d11){
									valid = true
								}else{
									valid = false
									message.stringx = characterArray("Check of control digit 2 failed.").ca
								}
							}else{
								valid = false
								message.stringx = characterArray("Check of control digit 1 failed.").ca
							}
						}
					}
				}else{
					message.stringx = characterArray("The date is not a valid date.").ca
				}
			}
		}else{
			message.stringx = characterArray("Each character must be a decimal digit.").ca
		}
	}else{
		message.stringx = characterArray("Must be exactly 11 digits long.").ca
	}

	return valid
}


func GetDateFromNorwegianPersonalIdentificationNumber(_ fnummer : inout [Character], _ dateRef : inout DateReference, _ message : inout StringReference) -> Bool{
	var individnummer : Double
	var day, month, year : Double
	var i, d1, d2, d3, d4, d5, d6, d7, d8, d9 : Double
	var success : Bool

	dateRef.date = Date()

	success = Double(fnummer.count) == 11.0
	if(success){
		i = 0.0
		while(i < Double(fnummer.count)){
			if(cIsNumber(fnummer[Int(i)])){
			}else{
				success = false
			}
			i = i + 1.0
		}

		if(success){
			d1 = cCharacterToDecimalDigit(fnummer[Int(0)])
			d2 = cCharacterToDecimalDigit(fnummer[Int(1)])
			d3 = cCharacterToDecimalDigit(fnummer[Int(2)])
			d4 = cCharacterToDecimalDigit(fnummer[Int(3)])
			d5 = cCharacterToDecimalDigit(fnummer[Int(4)])
			d6 = cCharacterToDecimalDigit(fnummer[Int(5)])
			d7 = cCharacterToDecimalDigit(fnummer[Int(6)])
			d8 = cCharacterToDecimalDigit(fnummer[Int(7)])
			d9 = cCharacterToDecimalDigit(fnummer[Int(8)])

			/* Individnummer*/
			individnummer = d7*100.0 + d8*10.0 + d9

			/* Make date*/
			day = d1*10.0 + d2
			month = d3*10.0 + d4
			year = d5*10.0 + d6

			if(individnummer >= 0.0 && individnummer <= 499.0){
				year = year + 1900.0
			}else if(individnummer >= 500.0 && individnummer <= 749.0 && year >= 54.0 && year <= 99.0){
				year = year + 1800.0
			}else if(individnummer >= 900.0 && individnummer <= 999.0 && year >= 40.0 && year <= 99.0){
				year = year + 1900.0
			}else if(individnummer >= 500.0 && individnummer <= 999.0 && year >= 0.0 && year <= 39.0){
				year = year + 2000.0
			}else{
				success = false
				message.stringx = characterArray("Invalid combination of individnummer and year.").ca
			}

			if(success){
				dateRef.date.year = year
				dateRef.date.month = month
				dateRef.date.day = day
			}
		}else{
			message.stringx = characterArray("Each character must be a decimal digit.").ca
		}
	}else{
		message.stringx = characterArray("Must be exactly 11 digits long.").ca
	}

	return success
}


func HentKommunenavnFraNummer(_ kommunenummer : inout [Character], _ kommunenavnReference : inout StringReference, _ errorMessages : inout StringReference) -> Bool{
	var nr : Double
	var success : Bool
	var nummer, kommunenavn : [StringReference]

	kommunenavn = HentKommunenavn()

	nummer = HentGyldigeKommunenummer()
	success = false

	nr = 0.0
	while(nr < Double(nummer.count) && !success){
		if(arraysStringsEqual(&nummer[Int(nr)].stringx, &kommunenummer)){
			success = true
			kommunenavnReference.stringx = kommunenavn[Int(nr)].stringx
		}
		nr = nr + 1.0
	}

	if(!success){
		errorMessages.stringx = characterArray("Kommunenummer er ikke gyldig.").ca
	}

	return success
}


func ErGyldigKommunenummer(_ kommunenummer : inout [Character]) -> Bool{
	var gyldig : Bool
	var i : Double
	var nummer : [StringReference]

	gyldig = false

	if(Double(kommunenummer.count) == 4.0){
		nummer = HentGyldigeKommunenummer()

		i = 0.0
		while(i < Double(nummer.count) && !gyldig){
			if(arraysStringsEqual(&nummer[Int(i)].stringx, &kommunenummer)){
				gyldig = true
			}
			i = i + 1.0
		}
	}

	return gyldig
}


func HentKommunenavn() -> [StringReference]{
	var kommunenavn : [StringReference]
	var kommunenavnliste : [Character]

	kommunenavnliste = characterArray("\u{00c5}fjord, Agdenes, \u{00c5}l, \u{00c5}lesund, Alstahaug, Alta, Alvdal, \u{00c5}mli, \u{00c5}mot, And\u{00f8}y, \u{00c5}rdal, Aremark, Arendal, \u{00c5}s, \u{00c5}seral, Asker, Askim, Ask\u{00f8}y, Askvoll, \u{00c5}snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u{00f8}land, Austevoll, Austrheim, Aver\u{00f8}y, B\u{00e6}rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u{00e5}tsfjord, Beiarn, Berg, Bergen, Berlev\u{00e5}g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u{00f8} i Nordland , B\u{00f8} i Telemark, Bod\u{00f8}, Bokn, B\u{00f8}mlo, Bremanger, Br\u{00f8}nn\u{00f8}y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u{00f8}nna, Dovre, Drammen, Drangedal, Dyr\u{00f8}y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u{00e6}rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u{00f8}y, Fitjar, Fjaler, Fjell, Fl\u{00e5}, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u{00f8}rde, Forsand, Fosnes, Fr\u{00e6}na, Fredrikstad, Frogn, Froland, Frosta, Fr\u{00f8}ya, Fusa, Fyresdal, G\u{00e1}ivuotna - K\u{00e5}fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u{00e5}l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u{00f8}vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u{00e5}, Hadsel, H\u{00e6}gebostad, Halden, Halsa, Hamar, Hamar\u{00f8}y - H\u{00e1}bmer, Hammerfest, Haram, Hareid, Harstad - H\u{00e1}rstt\u{00e1}k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u{00f8}y i  M\u{00f8}re og Romsdal, Her\u{00f8}y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u{00f8}l, Hol, Hole, Holmestrand, Holt\u{00e5}len, Hornindal, Horten, H\u{00f8}yanger, H\u{00f8}ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u{00f8}y, Indre Fosen, Iveland, Jevnaker, J\u{00f8}lster, Jondal, K\u{00e1}r\u{00e1}\u{0161}johka - Karasjok, Karls\u{00f8}y, Karm\u{00f8}y, Kl\u{00e6}bu, Klepp, Kongsberg, Kongsvinger, Krager\u{00f8}, Kristiansand, Kristiansund, Kr\u{00f8}dsherad, Kv\u{00e6}fjord, Kv\u{00e6}nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u{00f8}y, L\u{00e6}rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u{00e5}s, Lindesnes, Loab\u{00e1}k - Lavangen, L\u{00f8}dingen, Lom, Loppa, L\u{00f8}renskog, L\u{00f8}ten, Lund, Lunner, Lur\u{00f8}y, Luster, Lyngdal, Lyngen, M\u{00e5}lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u{00e5}s\u{00f8}y, Meland, Meldal, Melhus, Mel\u{00f8}y, Mer\u{00e5}ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u{00e6}r\u{00f8}y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u{00e1}isa - Raisi, Nore og Uvdal, Notodden, Odda, \u{00d8}ksnes, Oppdal, Oppeg\u{00e5}rd, Orkdal, \u{00d8}rland, \u{00d8}rskog, \u{00d8}rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u{00f8}y, \u{00d8}stre Toten, Overhalla, \u{00d8}vre Eiker, \u{00d8}yer, \u{00d8}ygarden, \u{00d8}ystre Slidre, Porsanger - Pors\u{00e1}\u{014b}gu - Porsanki, Porsgrunn, Raarvikhe - R\u{00f8}yrvik, R\u{00e5}de, Rad\u{00f8}y, R\u{00e6}lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u{00f8}y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u{00f8}r, Roan, R\u{00f8}d\u{00f8}y, Rollag, R\u{00f8}mskog, R\u{00f8}ros, R\u{00f8}st, R\u{00f8}yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u{00f8}re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u{00f8}y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u{00e5}nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u{00e5}k, Skjerv\u{00f8}y, Skodje, Sm\u{00f8}la, Sn\u{00e5}ase - Sn\u{00e5}sa, Snillfjord, Sogndal, S\u{00f8}gne, Sokndal, Sola, Solund, S\u{00f8}mna, S\u{00f8}ndre Land, Songdalen, S\u{00f8}r-Aurdal, S\u{00f8}rfold, S\u{00f8}r-Fron, S\u{00f8}r-Odal, S\u{00f8}rreisa, Sortland - Suort\u{00e1}, S\u{00f8}rum, S\u{00f8}r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u{00f8}rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u{00f8}nsberg, Torsken, Tr\u{00e6}na, Tran\u{00f8}y, Tr\u{00f8}gstad, Troms\u{00f8}, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u{00e6}r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u{00e1}rga - Nesseby, Utsira, Vads\u{00f8}, V\u{00e6}r\u{00f8}y, V\u{00e5}g\u{00e5}, V\u{00e5}gan, V\u{00e5}gs\u{00f8}y, Vaksdal, V\u{00e5}ler i Hedmark, V\u{00e5}ler i \u{00d8}stfold, Valle, Vang, Vanylven, Vard\u{00f8}, Vefsn, Vega, Veg\u{00e5}rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u{00e5}g\u{00f8}y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, ").ca

	kommunenavn = strSplitByString(&kommunenavnliste, &characterArray(", ").ca)

	return kommunenavn
}


func HentGyldigeKommunenummer() -> [StringReference]{
	var kommunenummerliste : [Character]
	var kommunenummer : [StringReference]

	kommunenummerliste = characterArray("5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235").ca

	kommunenummer = strSplitByString(&kommunenummerliste, &characterArray(", ").ca)

	return kommunenummer
}


func HentPoststedListe() -> [StringReference]{
	var p, l : [StringReference]
	var poststeder : [Character]
	var nr : [Double]
	var i : Double

	poststeder = characterArray("OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, HASLUM, SANDVIKA, FORNEBU, JAR, RUD, H\u{00d8}VIKODDEN, SLEPENDEN, V\u{00d8}YENENGA, V\u{00d8}YENENGA, EIKSMARKA, B\u{00c6}RUMS VERK, BEKKESTUA, BEKKESTUA, STABEKK, H\u{00d8}VIK, H\u{00d8}VIK, LYSAKER, LYSAKER, LYSAKER, LYSAKER, H\u{00d8}VIK, LOMMEDALEN, FORNEBU, FORNEBU, \u{00d8}STER\u{00c5}S, KOLS\u{00c5}S, RYKKINN, SNAR\u{00d8}YA, SANDVIKA, SANDVIKA, SANDVIKA, V\u{00d8}YENENGA, SKUI, SLEPENDEN, GJETTUM, HASLUM, GJETTUM, RYKKINN, RYKKINN, LOMMEDALEN, RUD, KOLS\u{00c5}S, B\u{00c6}RUMS VERK, B\u{00c6}RUMS VERK, BEKKESTUA, BEKKESTUA, JAR, EIKSMARKA, FORNEBU, \u{00d8}STER\u{00c5}S, HOSLE, H\u{00d8}VIK, FORNEBU, BLOMMENHOLM, LYSAKER, SNAR\u{00d8}YA, STABEKK, STABEKK, ASKER, ASKER, ASKER, BILLINGSTAD, BILLINGSTAD, BILLINGSTAD, NESBRU, NESBRU, HEGGEDAL, VETTRE, ASKER, ASKER, ASKER, ASKER, ASKER, BORGEN, HEGGEDAL, VOLLEN, VOLLEN, VETTRE, VOLLEN, NESBRU, HVALSTAD, BILLINGSTAD, NES\u{00d8}YA, ASKER, SKI, SKI, SKI, LANGHUS, SIGGERUD, LANGHUS, SKI, VINTERBRO, KR\u{00c5}KSTAD, SKOTBU, KOLBOTN, KOLBOTN, SOFIEMYR, T\u{00c5}RN\u{00c5}SEN, TROLL\u{00c5}SEN, OPPEG\u{00c5}RD, OPPEG\u{00c5}RD, SOFIEMYR, KOLBOTN, OPPEG\u{00c5}RD, SVARTSKOG, TROLL\u{00c5}SEN, SIGGERUD, VINTERBRO, \u{00c5}S, \u{00c5}S, \u{00c5}S, \u{00c5}S, \u{00c5}S, \u{00c5}S, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, DR\u{00d8}BAK, NESODDTANGEN, NESODDTANGEN, NESODDTANGEN, BJ\u{00d8}RNEMYR, FAGERSTRAND, NORDRE FROGN, NESODDTANGEN, FAGERSTRAND, FJELLSTRAND, NESODDEN, STR\u{00d8}MMEN, STR\u{00d8}MMEN, STR\u{00d8}MMEN, FINSTADJORDET, RASTA, L\u{00d8}RENSKOG, L\u{00d8}RENSKOG, FJELLHAMAR, L\u{00d8}RENSKOG, L\u{00d8}RENSKOG, FINSTADJORDET, RASTA, FJELLHAMAR, L\u{00d8}RENSKOG, KURLAND, SLATTUM, HAGAN, NITTEDAL, HAGAN, HAKADAL, HAKADAL, NITTEDAL, HAKADAL, HAKADAL, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, VESTBY, VESTBY, HVITSTEN, H\u{00d8}LEN, SON, SON, LARKOLLEN, LARKOLLEN, DILLING, RYGGE, RYGGE, RYGGE, SPERREBOTN, V\u{00c5}LER I \u{00d8}STFOLD, SVINNDAL, V\u{00c5}LER I \u{00d8}STFOLD, MOSS, MOSS, MOSS, MOSS, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, MANSTAD, MANSTAD, ENGELSVIKEN, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, R\u{00c5}DE, R\u{00c5}DE, SALTNES, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, TORP, TORP, TORP, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, ROLVS\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, KR\u{00c5}KER\u{00d8}Y, SKJ\u{00c6}RHALDEN, SKJ\u{00c6}RHALDEN, VESTER\u{00d8}Y, VESTER\u{00d8}Y, HERF\u{00d8}L, NEDG\u{00c5}RDEN, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, GR\u{00c5}LUM, GR\u{00c5}LUM, GR\u{00c5}LUM, YVEN, GRE\u{00c5}KER, GRE\u{00c5}KER, GRE\u{00c5}KER, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, ISE, HAFSLUNDS\u{00d8}Y, HAFSLUNDS\u{00d8}Y, VARTEIG, BORGENHAUGEN, BORGENHAUGEN, BORGENHAUGEN, KLAVESTADHAUGEN, KLAVESTADHAUGEN, SKJEBERG, SKJEBERG, SKJEBERG, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, BERG I \u{00d8}STFOLD, TISTEDAL, TISTEDAL, TISTEDAL, TISTEDAL, SPONVIKA, KORNSJ\u{00d8}, AREMARK, AREMARK, ASKIM, ASKIM, ASKIM, SPYDEBERG, TOMTER, SKIPTVET, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, SKIPTVET, SPYDEBERG, SPYDEBERG, KNAPSTAD, TOMTER, HOB\u{00d8}L, ASKIM, ASKIM, ASKIM, ASKIM, MYSEN, MYSEN, MYSEN, SLITU, TR\u{00d8}GSTAD, TR\u{00d8}GSTAD, B\u{00c5}STAD, B\u{00c5}STAD, \u{00d8}RJE, \u{00d8}RJE, OTTEID, H\u{00c6}RLAND, EIDSBERG, RAKKESTAD, RAKKESTAD, DEGERNES, DEGERNES, RAKKESTAD, FETSUND, FETSUND, GAN, ENEBAKKNESET, FLATEBY, ENEBAKK, YTRE ENEBAKK, FLATEBY, YTRE ENEBAKK, S\u{00d8}RUMSAND, S\u{00d8}RUMSAND, S\u{00d8}RUM, S\u{00d8}RUM, BLAKER, BLAKER, R\u{00c5}N\u{00c5}SFOSS, AULI, AULI, AURSKOG, AURSKOG, BJ\u{00d8}RKELANGEN, BJ\u{00d8}RKELANGEN, R\u{00d8}MSKOG, SETSKOG, L\u{00d8}KEN, L\u{00d8}KEN, FOSSER, HEMNES, HEMNES, LILLESTR\u{00d8}M, LILLESTR\u{00d8}M, LILLESTR\u{00d8}M, LILLESTR\u{00d8}M, R\u{00c6}LINGEN, L\u{00d8}VENSTAD, KJELLER, FJERDINGBY, NORDBY, STR\u{00d8}MMEN, STR\u{00d8}MMEN, LILLESTR\u{00d8}M, SKJETTEN, BLYSTADLIA, LEIRSUND, FROGNER, FROGNER, L\u{00d8}VENSTAD, SKEDSMOKORSET, SKEDSMOKORSET, SKEDSMOKORSET, GJERDRUM, SKEDSMOKORSET, GJERDRUM, FJERDINGBY, SKJETTEN, KJELLER, LILLESTR\u{00d8}M, R\u{00c6}LINGEN, NANNESTAD, NANNESTAD, MAURA, \u{00c5}SGREINA, HOLTER, HOLTER, MAURA, KL\u{00d8}FTA, KL\u{00d8}FTA, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, MOGREINA, NORDKISA, ALGARHEIM, JESSHEIM, SESSVOLLMOEN, GARDERMOEN, GARDERMOEN, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, R\u{00c5}HOLT, R\u{00c5}HOLT, DAL, B\u{00d8}N, EIDSVOLL VERK, DAL, EIDSVOLL, EIDSVOLL, HURDAL, HURDAL, MINNESUND, FEIRING, MINNESUND, SKARNES, SKARNES, SL\u{00c5}STAD, DISEN\u{00c5}, SANDER, SAGSTUA, SAGSTUA, BRUVOLL, KNAPPER, GARDVIK, GARDVIK, AUSTVATN, \u{00c5}RNES, \u{00c5}RNES, VORMSUND, VORMSUND, BR\u{00c5}RUD, SKOGBYGDA, SKOGBYGDA, HVAM, OPPAKER, HVAM, FENSTAD, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, GRANLI, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, ROVERUD, ROVERUD, HOKK\u{00c5}SEN, LUNDERS\u{00c6}TER, BRANDVAL, \u{00c5}BOGEN, GALTERUD, AUSTMARKA, KONGSVINGER, KONGSVINGER, AUSTMARKA, SKOTTERUD, SKOTTERUD, TOB\u{00d8}L, VESTMARKA, MATRAND, MAGNOR, MAGNOR, GRUE FINNSKOG, GRUE FINNSKOG, KIRKEN\u{00c6}R, KIRKEN\u{00c6}R, GRINDER, NAMN\u{00c5}, ARNEBERG, FLISA, FLISA, GJES\u{00c5}SEN, \u{00c5}SNES FINNSKOG, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, OTTESTAD, OTTESTAD, OTTESTAD, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, FURNES, HAMAR, RIDABU, INGEBERG, VANG P\u{00c5} HEDMARKEN, HAMAR, HAMAR, FURNES, RIDABU, VANG P\u{00c5} HEDMARKEN, VALLSET, VALLSET, \u{00c5}SVANG, ROMEDAL, ROMEDAL, STANGE, STANGE, TANGEN, ESPA, TANGEN, L\u{00d8}TEN, L\u{00d8}TEN, ILSENG, \u{00c5}DALSBRUK, ILSENG, NES P\u{00c5} HEDMARKEN, NES P\u{00c5} HEDMARKEN, STAVSJ\u{00d8}, GAUPEN, RUDSH\u{00d8}GDA, RUDSH\u{00d8}GDA, N\u{00c6}ROSET, \u{00c5}SMARKA, BR\u{00d8}TTUM, BR\u{00d8}TTUM, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, MOELV, MOELV, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, HERNES, ELVERUM, S\u{00d8}RSKOGBYGDA, ELVERUM, ELVERUM, HERADSBYGD, J\u{00d8}MNA, ELVERUM, ELVERUM, ELVERUM, TRYSIL, TRYSIL, NYBERGSUND, \u{00d8}STBY, \u{00d8}STBY, LJ\u{00d8}RDALEN, LJ\u{00d8}RDALEN, PLASSEN, S\u{00d8}RE OSEN, T\u{00d8}RBERGET, JORDET, SLETT\u{00c5}S, BRASKEREIDFOSS, BRASKEREIDFOSS, V\u{00c5}LER I SOL\u{00d8}R, HASLEMOEN, GRAVBERGET, V\u{00c5}LER I SOL\u{00d8}R, ENGERDAL, ENGERDAL, HERADSBYGD, DREVSJ\u{00d8}, DREVSJ\u{00d8}, ELG\u{00c5}, S\u{00d8}RE OSEN, S\u{00d8}M\u{00c5}DALEN, RENA, RENA, OSEN, OSEN, ATNA, SOLLIA, HANESTAD, KOPPANG, KOPPANG, RENDALEN, RENDALEN, RENDALEN, RENDALEN, RENDALEN, TYNSET, TYNSET, TYLLDALEN, KVIKNE, KVIKNE, TOLGA, TOLGA, VINGELEN, \u{00d8}VERSJ\u{00d8}DALEN, OS I \u{00d8}STERDALEN, OS I \u{00d8}STERDALEN, DALSBYGDA, TUFSINGDALEN, ALVDAL, ALVDAL, FOLLDAL, FOLLDAL, GRIMSBU, DALHOLEN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, VINGROM, LILLEHAMMER, LILLEHAMMER, MESNALI, LILLEHAMMER, SJUSJ\u{00d8}EN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LISMARKA, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, MESNALI, VINGROM, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, F\u{00c5}BERG, LILLEHAMMER, F\u{00c5}BERG, SJUSJ\u{00d8}EN, LILLEHAMMER, RINGEBU, RINGEBU, VENABYGD, F\u{00c5}VANG, F\u{00c5}VANG, TRETTEN, \u{00d8}YER, \u{00d8}YER, TRETTEN, VINSTRA, VINSTRA, KVAM, KVAM, SK\u{00c5}BU, SK\u{00c5}BU, S\u{00d8}R-FRON, G\u{00c5}L\u{00c5}, S\u{00d8}R-FRON, S\u{00d8}R-FRON, \u{00d8}STRE GAUSDAL, \u{00d8}STRE GAUSDAL, SVINGVOLL, VESTRE GAUSDAL, VESTRE GAUSDAL, FOLLEBU, SVATSUM, ESPEDALEN, DOMB\u{00c5}S, DOMB\u{00c5}S, HJERKINN, DOVRE, DOVRESKOGEN, DOVRE, LESJA, LORA, LESJAVERK, LESJASKOG, BJORLI, OTTA, LESJA, SEL, H\u{00d8}VRINGEN, MYSUS\u{00c6}TER, OTTA, HEIDAL, NEDRE HEIDAL, SEL, HEIDAL, V\u{00c5}G\u{00c5}, LALM, LALM, TESSANDEN, V\u{00c5}G\u{00c5}, GARMO, LOM, B\u{00d8}VERDALEN, LOM, SKJ\u{00c5}K, NORDBERG, SKJ\u{00c5}K, GROTLI, GRAN, BRANDBU, ROA, JAREN, LUNNER, HARESTUA, GRUA, BRANDBU, GRINDVOLL, LUNNER, ROA, GRUA, HARESTUA, GRAN, BRANDBU, JAREN, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, HUNNDALEN, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, HUNNDALEN, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, GJ\u{00d8}VIK, NORDRE TOTEN, GJ\u{00d8}VIK, BYBRUA, GJ\u{00d8}VIK, HUNNDALEN, RAUFOSS, RAUFOSS, BIRI, RAUFOSS, RAUFOSS, RAUFOSS, BIRI, BIRISTRAND, SNERTINGDAL, \u{00d8}VRE SNERTINGDAL, REINSVOLL, SNERTINGDAL, EINA, KOLBU, B\u{00d8}VERBRU, B\u{00d8}VERBRU, KOLBU, SKREIA, KAPP, LENA, LENA, REINSVOLL, EINA, SKREIA, KAPP, HOV, LAND\u{00c5}SBYGDA, FLUBERG, FALL, ENGER, HOV, DOKKA, ODNES, NORD-TORPA, AUST-TORPA, DOKKA, ETNEDAL, ETNEDAL, FAGERNES, FAGERNES, LEIRA I VALDRES, AURDAL, AURDAL, SKRAUTV\u{00c5}L, ULNES, LEIRA I VALDRES, TISLEIDALEN, BAGN, BAGN, REINLI, BEGNADALEN, BEGNA, HEGGENES, HEGGENES, ROGNE, SKAMMESTEIN, BEITO, BEITOST\u{00d8}LEN, BEITOST\u{00d8}LEN, R\u{00d8}N, R\u{00d8}N, SLIDRE, SLIDRE, LOMEN, RYFOSS, RYFOSS, VANG I VALDRES, VANG I VALDRES, \u{00d8}YE, TYINKRYSSET, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, MJ\u{00d8}NDALEN, MJ\u{00d8}NDALEN, STEINBERG, KROKSTADELVA, KROKSTADELVA, SOLBERGELVA, SOLBERGELVA, SOLBERGMOEN, SVELVIK, SVELVIK, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, BERGER, SANDE I VESTFOLD, SANDE I VESTFOLD, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOF, HOF, SUNDBYFOSS, EIDSFOSS, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, N\u{00d8}TTER\u{00d8}Y, SEM, VEAR, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, N\u{00d8}TTER\u{00d8}Y, N\u{00d8}TTER\u{00d8}Y, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, T\u{00d8}NSBERG, N\u{00d8}TTER\u{00d8}Y, T\u{00d8}NSBERG, HUS\u{00d8}YSUND, HUS\u{00d8}YSUND, DUKEN, T\u{00d8}NSBERG, TOR\u{00d8}D, TOR\u{00d8}D, SKALLESTAD, SKALLESTAD, N\u{00d8}TTER\u{00d8}Y, KJ\u{00d8}PMANNSKJ\u{00c6}R, VESTSKOGEN, KJ\u{00d8}PMANNSKJ\u{00c6}R, VEIERLAND, TJ\u{00d8}ME, HVASSER, TOLVSR\u{00d8}D, TOLVSR\u{00d8}D, TOLVSR\u{00d8}D, TOLVSR\u{00d8}D, TOLVSR\u{00d8}D, MELSOMVIK, BARK\u{00c5}KER, ANDEBU, MELSOMVIK, STOKKE, STOKKE, ANDEBU, N\u{00d8}TTER\u{00d8}Y, REVETAL, TJ\u{00d8}ME, TOLVSR\u{00d8}D, \u{00c5}SG\u{00c5}RDSTRAND, MELSOMVIK, STOKKE, SEM, SEM, VEAR, VEAR, REVETAL, RAMNES, UNDRUMSDAL, V\u{00c5}LE, V\u{00c5}LE, \u{00c5}SG\u{00c5}RDSTRAND, NYKIRKE, HORTEN, HORTEN, HORTEN, BORRE, SKOPPUM, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, SKOPPUM, HORTEN, NYKIRKE, BORRE, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, KODAL, SANDEFJORD, KODAL, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, SVARSTAD, SVARSTAD, STEINSHOLT, TJODALYNG, TJODALYNG, KVELDE, KVELDE, LARVIK, STAVERN, STAVERN, STAVERN, STAVERN, HELGEROA, NEVLUNGHAVN, HELGEROA, HOKKSUND, HOKKSUND, HOKKSUND, HOKKSUND, VESTFOSSEN, VESTFOSSEN, FISKUM, SKOTSELV, SKOTSELV, \u{00c5}MOT, \u{00c5}MOT, \u{00c5}MOT, PRESTFOSS, PRESTFOSS, SOLUMSMOEN, EGGEDAL, NEDRE EGGEDAL, EGGEDAL, GEITHUS, GEITHUS, VIKERSUND, VIKERSUND, LIER, LIER, LIER, LIER, LIER, TRANBY, TRANBY, TRANBY, TRANBY, SYLLING, SYLLING, LIERSTRANDA, LIER, LIERSTRANDA, LIERSKOGEN, LIERSKOGEN, REISTAD, GULLAUG, GULLAUG, GULLAUG, SPIKKESTAD, SPIKKESTAD, R\u{00d8}YKEN, R\u{00d8}YKEN, HYGGEN, SLEMMESTAD, SLEMMESTAD, B\u{00d8}DALEN, \u{00c5}ROS, S\u{00c6}TRE, S\u{00c6}TRE, B\u{00c5}TST\u{00d8}, N\u{00c6}RSNES, N\u{00c6}RSNES, FILTVET, TOFTE, TOFTE, KANA, HOLMSBU, FILTVET, KLOKKARSTUA, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, H\u{00d8}NEFOSS, JEVNAKER, JEVNAKER, BJONEROA, NES I \u{00c5}DAL, NES I \u{00c5}DAL, HALLINGBY, HALLINGBY, BJONEROA, HEDALEN, R\u{00d8}YSE, R\u{00d8}YSE, KROKKLEIVA, TYRISTRAND, TYRISTRAND, SOKNA, KR\u{00d8}DEREN, NORESUND, KR\u{00d8}DEREN, SOLLIH\u{00d8}GDA, FL\u{00c5}, NESBYEN, NESBYEN, NORESUND, TUNHOVD, FL\u{00c5}, GOL, GOL, HEMSEDAL, HEMSEDAL, \u{00c5}L, \u{00c5}L, HOL, HOL, HOVET, TORPO, GEILO, GEILO, DAGALI, USTAOSET, HAUGAST\u{00d8}L, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, HEISTADMOEN, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, SKOLLENBORG, SKOLLENBORG, FLESBERG, LAMPELAND, SVENE, LAMPELAND, LYNGDAL I NUMEDAL, SKOLLENBORG, ROLLAG, VEGGLI, VEGGLI, NORE, R\u{00d8}DBERG, R\u{00d8}DBERG, UVDAL, NORE, HVITTINGFOSS, HVITTINGFOSS, PASSEBEKK, TINN AUSTBYGD, HOVIN I TELEMARK, ATR\u{00c5}, MILAND, RJUKAN, RJUKAN, SAULAND, ATR\u{00c5}, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, HJARTDAL, GRANSHERAD, SAULAND, TUDDAL, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SILJAN, SILJAN, DRANGEDAL, T\u{00d8}RDAL, NESLANDSVATN, SANNIDAL, KRAGER\u{00d8}, KRAGER\u{00d8}, SK\u{00c5}T\u{00d8}Y, JOMFRULAND, KRAGER\u{00d8} SKJ\u{00c6}RG\u{00c5}RD, SKIEN, SKIEN, STABBESTAD, KRAGER\u{00d8}, HELLE, KRAGER\u{00d8}, SKIEN, SANNIDAL, HELLE, DRANGEDAL, SKIEN, SKIEN, SKIEN, B\u{00d8} I TELEMARK, B\u{00d8} I TELEMARK, B\u{00d8} I TELEMARK, B\u{00d8} I TELEMARK, B\u{00d8} I TELEMARK, B\u{00d8} I TELEMARK, GVARV, H\u{00d8}RTE, AKKERHAUGEN, NORDAGUTU, LUNDE, ULEFOSS, ULEFOSS, LUNDE, B\u{00d8} I TELEMARK, GVARV, SELJORD, KVITESEID, SELJORD, FLATDAL, \u{00c5}MOTSDAL, MORGEDAL, VR\u{00c5}LIOSEN, KVITESEID, VR\u{00c5}DAL, VR\u{00c5}DAL, NISSEDAL, TREUNGEN, RAULAND, FYRESDAL, DALEN, \u{00c5}MDALS VERK, TREUNGEN, RAULAND, FYRESDAL, DALEN, VINJE, EDLAND, VINJE, H\u{00d8}YDALSMO, VINJESVINGEN, EDLAND, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, LANGANGEN, PORSGRUNN, PORSGRUNN, BREVIK, STATHELLE, STATHELLE, STATHELLE, HERRE, STATHELLE, STATHELLE, LANGESUND, BREVIK, LANGESUND, LANGESUND, STATHELLE, PORSGRUNN, PORSGRUNN, PORSGRUNN, HERRE, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, SOLA, SOLA, R\u{00d8}YNEBERG, R\u{00c6}GE, TJELTA, SOLA, TANANGER, TANANGER, TANANGER, R\u{00d8}YNEBERG, TJELTA, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, RANDABERG, RANDABERG, RANDABERG, VASS\u{00d8}Y, HUNDV\u{00c5}G, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HUNDV\u{00c5}G, STAVANGER, HUNDV\u{00c5}G, HUNDV\u{00c5}G, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, SOLA, TANANGER, STAVANGER, J\u{00d8}RPELAND, IDSE, FORSAND, FORSAND, TAU, S\u{00d8}R-HIDLE, TAU, J\u{00d8}RPELAND, LYSEBOTN, FL\u{00d8}YRLI, SONGESAND, HJELMELAND, J\u{00d8}SENFJORDEN, \u{00c5}RDAL I RYFYLKE, FISTER, SKIFTUN, HJELMELAND, RENNES\u{00d8}Y, VESTRE \u{00c5}M\u{00d8}Y, BRIMSE, AUSTRE \u{00c5}M\u{00d8}Y, MOSTER\u{00d8}Y, BRU, RENNES\u{00d8}Y, FINN\u{00d8}Y, FINN\u{00d8}Y, TALGJE, FOGN, HELG\u{00d8}Y I RYFYLKE, BYRE, S\u{00d8}RBOKN, SJERNAR\u{00d8}Y, NORD-HIDLE, SJERNAR\u{00d8}Y, KVITS\u{00d8}Y, KVITS\u{00d8}Y, SKARTVEIT, OMBO, FOLD\u{00d8}Y, SAUDA, SAUDA, SAUDASJ\u{00d8}EN, VANVIK, SAND, ERFJORD, JELSA, HEBNES, SULDALSOSEN, SAND, SULDALSOSEN, NESFLATEN, KOPERVIK, TORVASTAD, AVALDSNES, KVALAV\u{00c5}G, H\u{00c5}VIK, \u{00c5}KREHAMN, SANDVE, STOL, S\u{00c6}VELANDSVIK, VEAV\u{00c5}GEN, SKUDENESHAVN, KOPERVIK, KOPERVIK, VEAV\u{00c5}GEN, \u{00c5}KREHAMN, SKUDENESHAVN, TORVASTAD, AVALDSNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u{00c5}K, HOMMERS\u{00c5}K, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, \u{00c5}LG\u{00c5}RD, FIGGJO, OLTEDAL, DIRDAL, SANDNES, SANDNES, SANDNES, \u{00c5}LG\u{00c5}RD, BRYNE, BRYNE, UNDHEIM, ORRE, BRYNE, BRYNE, BRYNE, LYE, LYE, BRYNE, KLEPPE, KLEPP STASJON, VOLL, KVERNALAND, KVERNALAND, KLEPP STASJON, KLEPPE, VARHAUG, SIREV\u{00c5}G, VIGRESTAD, BRUSAND, SIREV\u{00c5}G, N\u{00c6}RB\u{00d8}, N\u{00c6}RB\u{00d8}, VARHAUG, VIGRESTAD, EGERSUND, EGERSUND, EGERSUND, EGERSUND, EGERSUND, HELLVIK, HELLELAND, EGERSUND, EGERSUND, HAUGE I DALANE, HAUGE I DALANE, VIKES\u{00c5}, HELLELAND, BJERKREIM, VIKES\u{00c5}, OLTEDAL, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u{00c5}K, SANDNES, SANDNES, SANDNES, SANDNES, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, \u{00c5}NA-SIRA, HIDRASUND, ANDABEL\u{00d8}Y, GYLAND, SIRA, SIRA, TONSTAD, TONSTAD, TJ\u{00d8}RHOM, MOI, HOVSHERAD, UALAND, MOI, KVINLOG, KVINESDAL, \u{00d8}YESTRANDA, FEDA, KVINESDAL, KVINESDAL, KVINESDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, HOLUM, LINDESNES, LINDESNES, LINDESNES, LINDESNES, LINDESNES, KONSMO, KONSMO, KOLLUNGTVEIT, BYREMO, \u{00d8}YSLEB\u{00d8}, MARNARDAL, MARNARDAL, BJELLAND, \u{00c5}SERAL, \u{00c5}SERAL, FOSSDAL, FARSUND, FARSUND, FARSUND, FARSUND, FARSUND, VANSE, VANSE, VANSE, BORHAUG, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, KORSHAMN, KV\u{00c5}S, SNARTEMO, TINGVATN, EIKEN, EIKEN, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KARDEMOMME BY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, MOSBY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u{00d8}Y, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, S\u{00d8}GNE, S\u{00d8}GNE, S\u{00d8}GNE, S\u{00d8}GNE, S\u{00d8}GNE, NODELAND, FINSLAND, BRENN\u{00c5}SEN, FINSLAND, HAMRESANDEN, KJEVIK, TVEIT, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u{00d8}Y, S\u{00d8}GNE, S\u{00d8}GNE, S\u{00d8}GNE, BRENN\u{00c5}SEN, NODELAND, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, TVEIT, VENNESLA, VENNESLA, VENNESLA, VENNESLA, \u{00d8}VREB\u{00d8}, VENNESLA, VENNESLA, VENNESLA, \u{00d8}VREB\u{00d8}, H\u{00c6}GELAND, H\u{00c6}GELAND, IVELAND, IVELAND, VATNESTR\u{00d8}M, EVJE, EVJE, EVJE, HORNNES, BYGLANDSFJORD, GRENDI, BYGLAND, BYGLAND, VALLE, VALLE, RYSSTAD, RYSSTAD, BYKLE, HOVDEN I SETESDAL, HOVDEN I SETESDAL, BIRKELAND, HEREFOSS, ENGESLAND, H\u{00d8}V\u{00c5}G, BREKKEST\u{00d8}, LILLESAND, LILLESAND, LILLESAND, H\u{00d8}V\u{00c5}G, LILLESAND, BIRKELAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, KONGSHAVN, SALTR\u{00d8}D, KOLBJ\u{00d8}RNSVIK, HIS, F\u{00c6}RVIK, FROLAND, RYKENE, RYKENE, NEDENES, BJORBEKK, ARENDAL, FROLANDS VERK, MJ\u{00c5}VATN, HYNNEKLEIV, MYKLAND, RISDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, SALTR\u{00d8}D, F\u{00c6}RVIK, HIS, NEDENES, FROLAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, NELAUG, \u{00c5}MLI, \u{00c5}MLI, SEL\u{00c5}SVATN, D\u{00d8}LEMO, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, HOMBORSUND, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, TVEDESTRAND, TVEDESTRAND, TVEDESTRAND, SONGE, LYNG\u{00d8}R, GJEVING, VESTRE SAND\u{00d8}YA, BOR\u{00d8}Y, STAUB\u{00d8}, STAUB\u{00d8}, NES VERK, RIS\u{00d8}R, RIS\u{00d8}R, RIS\u{00d8}R, RIS\u{00d8}R, RIS\u{00d8}R, RIS\u{00d8}R, RIS\u{00d8}R, SUNDEBRU, GJERSTAD, VEG\u{00c5}RSHEI, S\u{00d8}NDELED, GJERSTAD, VEG\u{00c5}RSHEI, S\u{00d8}NDELED, SUNDEBRU, AKLAND, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, EIDSV\u{00c5}GNESET, EIDSV\u{00c5}G I \u{00c5}SANE, EIDSV\u{00c5}G I \u{00c5}SANE, \u{00d8}VRE ERVIK, SALHUS, HORDVIK, HYLKJE, BREISTEIN, TERTNES, TERTNES, ULSET, ULSET, ULSET, ULSET, ULSET, ULSET, MORVIK, MORVIK, NYBORG, NYBORG, NYBORG, FLAKTVEIT, FLAKTVEIT, MJ\u{00d8}LKER\u{00c5}EN, MJ\u{00d8}LKER\u{00c5}EN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, STRAUMSGREND, B\u{00d8}NES, B\u{00d8}NES, B\u{00d8}NES, B\u{00d8}NES, LAKSEV\u{00c5}G, LAKSEV\u{00c5}G, LAKSEV\u{00c5}G, LAKSEV\u{00c5}G, LAKSEV\u{00c5}G, LAKSEV\u{00c5}G, BJ\u{00d8}RNDALSTR\u{00c6}, LODDEFJORD, LODDEFJORD, LODDEFJORD, MATHOPEN, LODDEFJORD, BJ\u{00d8}R\u{00d8}YHAMN, LODDEFJORD, GODVIK, OLSVIK, OLSVIK, OS, OS, OS, OS, OS, S\u{00d8}FTELAND, OS, OS, OS, OS, S\u{00d8}FTELAND, LEPS\u{00d8}Y, LYSEKLOSTER, LYSEKLOSTER, LEPS\u{00d8}Y, HAGAVIK, NORDSTR\u{00d8}NO, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, KALANDSEIDET, PARADIS, PARADIS, PARADIS, R\u{00c5}DAL, R\u{00c5}DAL, R\u{00c5}DAL, R\u{00c5}DAL, R\u{00c5}DAL, FANA, FANA, S\u{00d8}REIDGREND, S\u{00d8}REIDGREND, SANDSLI, SANDSLI, KOKSTAD, BLOMSTERDALEN, HJELLESTAD, INDRE ARNA, INDRE ARNA, ARNATVEIT, TRENGEREID, GARNES, YTRE ARNA, ESPELAND, HAUKELAND, VALESTRANDSFOSSEN, LONEV\u{00c5}G, FOTLANDSV\u{00c5}G, TYSSEBOTNEN, BRUVIK, HAUS, VALESTRANDSFOSSEN, LONEV\u{00c5}G, HAUS, KLEPPEST\u{00d8}, KLEPPEST\u{00d8}, STRUSSHAMN, FOLLESE, HETLEVIK, FLORV\u{00c5}G, ERDAL, ASK, KLEPPEST\u{00d8}, KLEPPEST\u{00d8}, HAUGLANDSHELLA, KJERRGARDEN, KJERRGARDEN, HERDLA, STRUSSHAMN, KLEPPEST\u{00d8}, KLEPPEST\u{00d8}, KLEPPEST\u{00d8}, KLEPPEST\u{00d8}, FOLLESE, ASK, HAUGLANDSHELLA, FLORV\u{00c5}G, RONG, TJELDST\u{00d8}, HELLES\u{00d8}Y, HERNAR, TJELDST\u{00d8}, RONG, STRAUME, STRAUME, STRAUME, KNARREVIK, \u{00c5}GOTNES, \u{00c5}GOTNES, BRATTHOLMEN, STRAUME, STRAUME, KNARREVIK, FJELL, FJELL, KOLLTVEIT, \u{00c5}GOTNES, TUR\u{00d8}Y, MISJE, SKOGSV\u{00c5}G, STEINSLAND, KLOKKARVIK, STEINSLAND, T\u{00c6}LAV\u{00c5}G, GLESV\u{00c6}R, SKOGSV\u{00c5}G, TORANGSV\u{00c5}G, BAKKASUND, M\u{00d8}KSTER, LITLAKALS\u{00d8}Y, STOREB\u{00d8}, STOREB\u{00d8}, KOLBEINSVIK, VESTRE VINNESV\u{00c5}G, BEKKJARVIK, STOLMEN, BEKKJARVIK, STORD, STORD, STORD, STORD, STORD, STORD, SAGV\u{00c5}G, STORD, SAGV\u{00c5}G, STORD, STORD, HUGLO, STORD, STORD, STORD, STORD, FITJAR, FITJAR, RUBBESTADNESET, BRANDASUND, URANGSV\u{00c5}G, FOLDR\u{00d8}YHAMN, BREMNES, FINN\u{00c5}S, MOSTERHAMN, B\u{00d8}MLO, ESPEV\u{00c6}R, BREMNES, MOSTERHAMN, B\u{00d8}MLO, SUNDE I SUNNHORDLAND, VALEN, SANDVOLL, UT\u{00c5}KER, S\u{00c6}B\u{00d8}VIK, HALSN\u{00d8}Y KLOSTER, H\u{00d8}YLANDSBYGD, ARNAVIK, FJELBERG, HUSNES, HER\u{00d8}YSUNDET, USKEDALEN, DIMMELSVIK, USKEDALEN, ROSENDAL, SEIMSFOSS, SNILSTVEIT\u{00d8}Y, L\u{00d8}FALLSTRAND, \u{00c6}NES, MAURANGER, HUSNES, S\u{00c6}B\u{00d8}VIK, ROSENDAL, MATRE, \u{00c5}KRA, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KARMSUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KOLNES, KARMSUND, VORMEDAL, VORMEDAL, R\u{00d8}YKSUND, UTSIRA, FE\u{00d8}Y, R\u{00d8}V\u{00c6}R, SVEIO, AUKLANDSHAMN, VALEV\u{00c5}G, F\u{00d8}RDE I HORDALAND, F\u{00d8}RDE I HORDALAND, SVEIO, NEDSTRAND, BOKN, NEDSTRAND, F\u{00d8}RRESFJORDEN, TYSV\u{00c6}RV\u{00c5}G, HERVIK, SKJOLDASTRAUMEN, VIKEBYGD, BOKN, AKSDAL, SKJOLD, AKSDAL, \u{00d8}VRE VATS, NEDRE VATS, \u{00d8}LEN, \u{00d8}LENSV\u{00c5}G, VIKEDAL, BJOA, SANDEID, VIKEDAL, \u{00d8}LEN, SANDEID, ETNE, ETNE, SK\u{00c5}NEVIK, SK\u{00c5}NEVIK, F\u{00d8}RRESFJORDEN, MARKHUS, FJ\u{00c6}RA, NORHEIMSUND, NORHEIMSUND, NORHEIMSUND, \u{00d8}YSTESE, \u{00c5}LVIK, \u{00d8}YSTESE, STEINST\u{00d8}, \u{00c5}LVIK, T\u{00d8}RVIKBYGD, KYSNESSTRAND, JONDAL, HERAND, JONDAL, STRANDEBARM, STRANDEBARM, OMASTRAND, OMASTRAND, HATLESTRAND, VARALDS\u{00d8}Y, \u{00d8}LVE, EIKELANDSOSEN, FUSA, HOLMEFJORD, STRANDVIK, S\u{00c6}VAREID, S\u{00c6}VAREID, NORDTVEITGREND, BALDERSHEIM, FUSA, EIKELANDSOSEN, TYSSE, TYSSE, \u{00c5}RLAND, \u{00c5}RLAND, TYSNES, REKSTEREN, UGGDAL, FLATR\u{00c5}KER, LUNDEGREND, \u{00c5}RBAKKA, ONARHEIM, UGGDAL, TYSNES, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, EVANGER, VOSS, VOSS, SKULESTADMO, SKULESTADMO, VOSSESTRAND, VOSSESTRAND, VOSS, STALHEIM, MYRDAL, FINSE, STANGHELLE, DALEKVAM, DALEKVAM, BOLSTAD\u{00d8}YRI, STANGHELLE, VAKSDAL, VAKSDAL, STAMNES, EIDSLANDET, MODALEN, ULVIK, ULVIK, MODALEN, GRANVIN, VALLAVIK, GRANVIN, AURLAND, FL\u{00c5}M, FL\u{00c5}M, AURLAND, UNDREDAL, GUDVANGEN, STYVI, ODDA, ODDA, ODDA, R\u{00d8}LDAL, SKARE, TYSSEDAL, HOVLAND, N\u{00c5}, N\u{00c5}, GRIMO, UTNE, UTNE, KINSARVIK, LOFTHUS, KINSARVIK, EIDFJORD, \u{00d8}VRE EIDFJORD, V\u{00d8}RINGSFOSS, EIDFJORD, LOFTHUS, KINSARVIK, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, ISDALST\u{00d8}, ISDALST\u{00d8}, ISDALST\u{00d8}, FREKHAUG, ALVERSUND, ISDALST\u{00d8}, ALVERSUND, SEIM, EIKANGERV\u{00c5}G, ISDALST\u{00d8}, HJELM\u{00c5}S, ISDALST\u{00d8}, ROSSLAND, FREKHAUG, FREKHAUG, MANGER, B\u{00d8}V\u{00c5}GEN, MANGER, B\u{00d8}V\u{00c5}GEN, S\u{00c6}B\u{00d8}V\u{00c5}GEN, SLETTA, AUSTRHEIM, AUSTRHEIM, FEDJE, FEDJE, LIND\u{00c5}S, FONNES, FONNES, MONGSTAD, LIND\u{00c5}S, HUNDVIN, MYKING, DALS\u{00d8}YRA, BREKKE, BJORDAL, DALS\u{00d8}YRA, BREKKE, BJORDAL, EIVINDVIK, EIVINDVIK, BYRKNES\u{00d8}Y, \u{00c5}NNELAND, MJ\u{00d8}MNA, BYRKNES\u{00d8}Y, MASFJORDNES, MASFJORDNES, HAUGSV\u{00c6}R, MATREDAL, HAUGSV\u{00c6}R, HOSTELAND, HOSTELAND, OSTEREIDET, OSTEREIDET, VIKANES, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, LANGEV\u{00c5}G, EIDSNES, FISKARSTRAND, MAUSEIDV\u{00c5}G, EIDSNES, FISKARSTRAND, LANGEV\u{00c5}G, VIGRA, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, \u{00c5}LESUND, VALDER\u{00d8}YA, VALDER\u{00d8}YA, GISKE, GOD\u{00d8}YA, GOD\u{00d8}YA, ELLINGS\u{00d8}Y, VALDER\u{00d8}YA, VIGRA, HAREID, BRANDAL, HJ\u{00d8}RUNGAV\u{00c5}G, HADDAL, ULSTEINVIK, ULSTEINVIK, EIKSUND, HAREID, TJ\u{00d8}RV\u{00c5}G, MOLTUSTRANDA, MOLTUSTRANDA, GJERDSVIKA, GURSK\u{00d8}Y, GURSK\u{00d8}Y, GURSKEN, GJERDSVIKA, LARSNES, LARSNES, KVAMS\u{00d8}Y, KVAMS\u{00d8}Y, SANDSHAMN, SANDSHAMN, FOSNAV\u{00c5}G, FOSNAV\u{00c5}G, FOSNAV\u{00c5}G, LEIN\u{00d8}Y, B\u{00d8}LANDET, RUNDE, NERLANDS\u{00d8}Y, FOSNAV\u{00c5}G, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, AUSTEFJORDEN, FOLKESTAD, LAUVSTAD, LAUVSTAD, SYVDE, FISK\u{00c5}, SYVDE, ROVDE, EIDS\u{00c5}, FISK\u{00c5}, SYLTE, \u{00c5}HEIM, \u{00c5}HEIM, \u{00c5}RAM, \u{00d8}RSTA, \u{00d8}RSTA, \u{00d8}RSTA, \u{00d8}RSTA, \u{00d8}RSTA, \u{00d8}RSTA, \u{00d8}RSTA, HOVDEBYGDA, HOVDEBYGDA, S\u{00c6}B\u{00d8}, S\u{00c6}B\u{00d8}, VARTDAL, VARTDAL, BARSTADVIK, TRANDAL, STORESTANDAL, BJ\u{00d8}RKE, NORANGSFJORDEN, STRANDA, STRANDA, VALLDAL, VALLDAL, LIABYGDA, TAFJORD, NORDDAL, EIDSDAL, GEIRANGER, GEIRANGER, HELLESYLT, HELLESYLT, STRAUMGJERDE, IKORNNES, IKORNNES, HUNDEIDVIK, SYKKYLVEN, STRAUMGJERDE, SYKKYLVEN, \u{00d8}RSKOG, \u{00d8}RSKOG, STORDAL, EIDSDAL, STORDAL, SKODJE, SKODJE, TENNFJORD, VATNE, BRATTV\u{00c5}G, HILDRE, S\u{00d8}VIK, S\u{00d8}VIK, BRATTV\u{00c5}G, VATNE, STOREKALV\u{00d8}Y, HARAMS\u{00d8}Y, HARAMS\u{00d8}Y, KJERSTAD, LONGVA, FJ\u{00d8}RTOFT, \u{00c5}NDALSNES, \u{00c5}NDALSNES, VEBLUNGSNES, INNFJORDEN, ISFJORDEN, VERMA, VERMA, ISFJORDEN, EIDSBYGDA, \u{00c5}FARNES, \u{00c5}FARNES, MITTET, VISTDAL, VISTDAL, M\u{00c5}NDALEN, M\u{00c5}NDALEN, V\u{00c5}GSTRANDA, V\u{00c5}GSTRANDA, FIKSDAL, VESTNES, TRESFJORD, VIKEBUKT, TOMREFJORD, FIKSDAL, REKDAL, VIKEBUKT, TRESFJORD, TOMREFJORD, VESTNES, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, AUREOSEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, SEKKEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, BUD, BUD, HUSTAD, MOLDE, MOLDE, MOLDE, ELNESV\u{00c5}GEN, TORNES I ROMSDAL, FARSTAD, MALMEFJORDEN, FARSTAD, ELNESV\u{00c5}GEN, HJELSET, KLEIVE, KLEIVE, HJELSET, KORTGARDEN, SK\u{00c5}LA, BOLS\u{00d8}YA, SK\u{00c5}LA, EIDSV\u{00c5}G I ROMSDAL, EIDSV\u{00c5}G I ROMSDAL, RAUDSAND, ERESFJORD, ERESFJORD, EIKESDAL, MIDSUND, MIDSUND, AUKRA, AUKRA, ONA, SAND\u{00d8}Y, HAR\u{00d8}Y, ORTEN, HAR\u{00d8}Y, MYKLEBOST, EIDE, LYNGSTAD, VEVANG, EIDE, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, AVER\u{00d8}Y, AVER\u{00d8}Y, AVER\u{00d8}Y, AVER\u{00d8}Y, AVER\u{00d8}Y, AVER\u{00d8}Y, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, SM\u{00d8}LA, SM\u{00d8}LA, TUSTNA, TUSTNA, SUNNDALS\u{00d8}RA, SUNNDALS\u{00d8}RA, \u{00d8}KSENDAL, FURUGRENDA, GR\u{00d8}A, GJ\u{00d8}RA, GJ\u{00d8}RA, \u{00c5}LVUNDEID, \u{00c5}LVUNDFJORD, \u{00c5}LVUNDFJORD, TINGVOLL, MEISINGSET, TORJULV\u{00c5}GEN, TINGVOLL, BATNFJORDS\u{00d8}RA, BATNFJORDS\u{00d8}RA, GJEMNES, ANGVIK, FLEMMA, OSMARKA, TORVIKBUKT, KVANNE, TORVIKBUKT, STANGVIK, B\u{00d8}FJORDEN, B\u{00c6}VERFJORD, TODALEN, SURNADAL, SURNADAL, \u{00d8}VRE SURNADAL, VIND\u{00d8}LA, SURNADAL, RINDAL, RINDALSSKOGEN, RINDAL, \u{00d8}YDEGARD, \u{00d8}YDEGARD, KVISVIK, HALSANAUSTAN, V\u{00c5}GLAND, VALS\u{00d8}YBOTN, VALS\u{00d8}YFJORD, V\u{00c5}GLAND, AURE, AURE, MJOSUNDET, FOLDFJORDEN, VIHALS, LESUND, KJ\u{00d8}RSVIKBUGEN, M\u{00c5}L\u{00d8}Y, M\u{00c5}L\u{00d8}Y, M\u{00c5}L\u{00d8}Y, M\u{00c5}L\u{00d8}Y, DEKNEPOLLEN, RAUDEBERG, BRYGGJA, RAUDEBERG, BRYGGJA, ALMENNINGEN, SILDA, BARMEN, HUSEV\u{00c5}G, FLATRAKET, DEKNEPOLLEN, SKATESTRAUMEN, SVELGEN, SVELGEN, BREMANGER, BREMANGER, KALV\u{00c5}G, KALV\u{00c5}G, DAVIK, RUGSUND, \u{00c5}LFOTEN, SELJE, SELJE, STADLANDET, STADLANDET, HORNINDAL, HORNINDAL, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, KJ\u{00d8}LSDALEN, ST\u{00c5}RHEIM, LOTE, HOLM\u{00d8}YANE, STRYN, STRYN, STRYN, OLDEN, OLDEN, LOEN, LOEN, OLDEDALEN, BRIKSDALSBRE, INNVIK, INNVIK, BLAKS\u{00c6}TER, HOPLAND, UTVIK, HJELLEDALEN, OPPSTRYN, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, NAUSTDAL, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, F\u{00d8}RDE, NAUSTDAL, HAUKEDALEN, F\u{00d8}RDE, F\u{00d8}RDE, SANDANE, SANDANE, SANDANE, BYRKJELO, BREIM, HESTENES\u{00d8}YRA, HYEN, BYRKJELO, HYEN, SKEI I J\u{00d8}LSTER, SKEI I J\u{00d8}LSTER, VASSENDEN, FJ\u{00c6}RLAND, VASSENDEN, FJ\u{00c6}RLAND, KAUPANGER, SOGNDAL, SOGNDAL, SOGNDAL, KAUPANGER, FR\u{00d8}NNINGEN, SOGNDAL, FARDAL, SLINDE, LEIKANGER, LEIKANGER, GAUPNE, HAFSLO, GAUPNE, HAFSLO, ORNES, JOSTEDAL, LUSTER, MARIFJ\u{00d8}RA, LUSTER, H\u{00d8}YHEIMSVIK, SKJOLDEN, FORTUN, VEITASTROND, SOLVORN, \u{00c5}RDALSTANGEN, \u{00d8}VRE \u{00c5}RDAL, \u{00d8}VRE \u{00c5}RDAL, \u{00c5}RDALSTANGEN, L\u{00c6}RDAL, L\u{00c6}RDAL, BORGUND, VIK I SOGN, VIK I SOGN, VANGSNES, FEIOS, FRESVIK, BALESTRAND, BALESTRAND, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, FLOR\u{00d8}, KINN, FLOR\u{00d8}, SVAN\u{00d8}YBUKT, ROGNALDSV\u{00c5}G, BAREKSTAD, BATALDEN, S\u{00d8}R-SKORPA, TANS\u{00d8}Y, HARDBAKKE, HARDBAKKE, KRAKHELLA, YTR\u{00d8}YGREND, KOLGROV, HERSVIKBYGDA, EIKEFJORD, EIKEFJORD, SVORTEVIK, STAVANG, LAVIK, LAVIK, LEIRVIK I SOGN, LEIRVIK I SOGN, HYLLESTAD, S\u{00d8}RB\u{00d8}V\u{00c5}G, S\u{00d8}RB\u{00d8}V\u{00c5}G, DALE I SUNNFJORD, DALE I SUNNFJORD, KORSSUND, GUDDAL, HELLEVIK I FJALER, FLEKKE, STRAUMSNES, SANDE I SUNNFJORD, SANDE I SUNNFJORD, SKILBREI, BYGSTAD, BYGSTAD, VIKSDALEN, ASKVOLL, HOLMEDAL, KVAMMEN, STONGFJORDEN, ATL\u{00d8}Y, V\u{00c6}RLANDET, BULANDET, ASKVOLL, H\u{00d8}YANGER, H\u{00d8}YANGER, KYRKJEB\u{00d8}, VADHEIM, VADHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, RANHEIM, RANHEIM, RANHEIM, RANHEIM, JONSVATNET, JAKOBSLI, JAKOBSLI, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, BOSBERG, TRONDHEIM, HEIMDAL, SPONGDAL, TILLER, SAUPSTAD, FLAT\u{00c5}SEN, HEIMDAL, SJETNEMARKA, KATTEM, LEINSTRAND, HEIMDAL, HEIMDAL, TILLER, TILLER, TILLER, SAUPSTAD, SAUPSTAD, FLAT\u{00c5}SEN, RISSA, RISSA, STADSBYGD, FEV\u{00c5}G, HASSELVIKA, HASSELVIKA, HUSBYSJ\u{00d8}EN, R\u{00c5}KV\u{00c5}G, HUSBYSJ\u{00d8}EN, R\u{00c5}KV\u{00c5}G, STADSBYGD, LEKSVIK, LEKSVIK, VANVIKAN, VANVIKAN, OPPHAUG, BREKSTAD, BREKSTAD, OPPHAUG, UTHAUG, STORFOSNA, STORFOSNA, KR\u{00c5}KV\u{00c5}G, GARTEN, LEKSA, BJUGN, BJUGN, LYS\u{00d8}YSUNDET, OKSVOLL, TARVA, VALLERSUND, LYS\u{00d8}YSUNDET, \u{00c5}FJORD, \u{00c5}FJORD, REVSNES, STOKK\u{00d8}Y, LINES\u{00d8}YA, REVSNES, STOKK\u{00d8}Y, ROAN, ROAN, BESSAKER, BRANDSFJORD, KYRKS\u{00c6}TER\u{00d8}RA, KYRKS\u{00c6}TER\u{00d8}RA, VINJE\u{00d8}RA, HELLANDSJ\u{00d8}EN, KORSVEGEN, KORSVEGEN, G\u{00c5}SBAKKEN, MELHUS, MELHUS, MELHUS, GIMSE, KV\u{00c5}L, LUNDAMO, LUNDAMO, LER, LER, HOVIN I GAULDAL, HOVIN I GAULDAL, HITRA, HITRA, ANSNES, KNARRLAGSUND, KVENV\u{00c6}R, KNARRLAGSUND, KVENV\u{00c6}R, SANDSTAD, HESTVIKA, MELANDSJ\u{00d8}, DOLM\u{00d8}Y, SUNDLANDET, HEMNSKJELA, SNILLFJORD, SNILLFJORD, SISTRANDA, SISTRANDA, HAMARVIK, HAMARVIK, KVERVA, KVERVA, TITRAN, DYRVIK, NORDDYR\u{00d8}Y, NORDDYR\u{00d8}Y, SULA, BOG\u{00d8}YV\u{00c6}R, MAUSUND, GJ\u{00c6}SINGEN, S\u{00d8}RBUR\u{00d8}Y, SAU\u{00d8}Y, SOKNEDAL, SOKNEDAL, ST\u{00d8}REN, ST\u{00d8}REN, ROGNES, BUDALEN, ORKANGER, ORKANGER, ORKANGER, GJ\u{00d8}LME, LENSVIK, LENSVIK, AGDENES, AGDENES, FANNREM, FANNREM, SVORKMO, SVORKMO, L\u{00d8}KKEN VERK, L\u{00d8}KKEN VERK, STOR\u{00c5}S, STOR\u{00c5}S, JERPSTAD, MELDAL, MELDAL, OPPDAL, OPPDAL, L\u{00d8}NSET, VOGNILL, DRIVA, BUVIKA, BUVIKA, B\u{00d8}RSA, VIGGJA, EGGKLEIVA, SKAUN, SKAUN, B\u{00d8}RSA, R\u{00d8}ROS, BREKKEBYGD, GL\u{00c5}MOS, R\u{00d8}ROS, \u{00c5}LEN, HALTDALEN, \u{00c5}LEN, SINGS\u{00c5}S, SINGS\u{00c5}S, SINGS\u{00c5}S, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, SKATVAL, SKATVAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, STJ\u{00d8}RDAL, HELL, ELVARLI, HEGRA, FLORNES, HEGRA, MER\u{00c5}KER, MER\u{00c5}KER, KOPPER\u{00c5}, KL\u{00c6}BU, KL\u{00c6}BU, TANEM, HOMMELVIK, HOMMELVIK, VIKHAMMER, SAKSVIK, MALVIK, VIKHAMMER, HELL, SELBU, SELBU, SELBU, SELBUSTRAND, TYDAL, TYDAL, FLAKNAN, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, SKOGN, SKOGN, MARKABYGDA, RONGLAN, EKNE, YTTER\u{00d8}Y, \u{00c5}SEN, \u{00c5}SEN, \u{00c5}SENFJORD, FROSTA, FROSTA, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VUKU, VUKU, INDER\u{00d8}Y, INDER\u{00d8}Y, INDER\u{00d8}Y, MOSVIK, MOSVIK, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINSDALEN, STEINSDALEN, YTTERV\u{00c5}G, HEPS\u{00d8}Y, OPPLAND, HASV\u{00c5}G, S\u{00c6}TERVIK, NAMDALSEID, NAMDALSEID, SN\u{00c5}SA, SN\u{00c5}SA, FLATANGER, FLATANGER, NORD-STATLAND, MALM, MALM, FOLLAFOSS, FOLLAFOSS, VERRABOTN, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, SALSNES, LUND, FOSSLANDSOSEN, SPILLUM, SPILLUM, BANGSUND, BANGSUND, J\u{00d8}A, SKAGE I NAMDALEN, OVERHALLA, OVERHALLA, SKAGE I NAMDALEN, GRONG, GRONG, HARRAN, HARRAN, KONGSMOEN, H\u{00d8}YLANDET, H\u{00d8}YLANDET, NORDLI, NORDLI, S\u{00d8}RLI, S\u{00d8}RLI, NAMSSKOGAN, NAMSSKOGAN, TRONES, SKOROVATN, BREKKVASSELV, LIMINGEN, LIMINGEN, R\u{00d8}RVIK, R\u{00d8}RVIK, R\u{00d8}RVIK, OTTERS\u{00d8}Y, OTTERS\u{00d8}Y, INDRE N\u{00c6}R\u{00d8}Y, ABELV\u{00c6}R, SALSBRUKET, KOLVEREID, KOLVEREID, GJERDINGA, TERR\u{00c5}K, TERR\u{00c5}K, HARANGSFJORD, BINDALSEIDET, BINDALSEIDET, FOLDEREID, FOLDEREID, NAUSTBUKTA, GUTVIK, LEKA, LEKA, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, TVERLANDET, SALTSTRAUMEN, SALTSTRAUMEN, TVERLANDET, V\u{00c6}R\u{00d8}Y, V\u{00c6}R\u{00d8}Y, R\u{00d8}ST, R\u{00d8}ST, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, BOD\u{00d8}, KJERRING\u{00d8}Y, FLEINV\u{00c6}R, HELLIGV\u{00c6}R, BLIKSV\u{00c6}R, GIV\u{00c6}R, LANDEGODE, JAN MAYEN, MISV\u{00c6}R, SKJERSTAD, BREIVIK I SALTEN, MISV\u{00c6}R, MOLDJORD, TOLL\u{00c5}, MOLDJORD, NYG\u{00c5}RDSJ\u{00d8}EN, YTRE BEIARN, SANDHORN\u{00d8}Y, S\u{00d8}RARN\u{00d8}Y, S\u{00d8}RARN\u{00d8}Y, NORDARN\u{00d8}Y, INNDYR, INNDYR, STORVIK, REIP\u{00c5}, NEVERDAL, \u{00d8}RNES, \u{00d8}RNES, MEL\u{00d8}Y, BOLGA, ST\u{00d8}TT, GLOMFJORD, GLOMFJORD, ENGAV\u{00c5}GEN, ENGAV\u{00c5}GEN, HALSA, HALSA, MYKEN, MELFJORDBOTN, V\u{00c5}GAHOLMEN, \u{00c5}GSKARDET, V\u{00c5}GAHOLMEN, TJONGSFJORDEN, JEKTVIK, NORDVERNES, GJERSVIKGRENDA, S\u{00d8}RFJORDEN, R\u{00d8}D\u{00d8}Y, GJER\u{00d8}Y, SELS\u{00d8}YVIK, STORSELS\u{00d8}Y, NORDNES\u{00d8}Y, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, VALNESFJORD, FAUSKE, FAUSKE, R\u{00d8}SVIK, STRAUMEN, SULITJELMA, SULITJELMA, STRAUMEN, VALNESFJORD, ROGNAN, ROGNAN, R\u{00d8}KLAND, R\u{00d8}KLAND, INNHAVET, INNHAVET, ENGAN, M\u{00d8}RSVIKBOTN, DRAG, DRAG, NEVERVIK, MUSKEN, STORJORD I TYSFJORD, ULVSV\u{00c5}G, STOR\u{00c5}, LEINESFJORD, LEINESFJORD, LEINES, NORDFOLD, ENGEL\u{00d8}YA, BOG\u{00d8}Y, ENGEL\u{00d8}YA, SKUTVIK, HAMAR\u{00d8}Y, TRAN\u{00d8}Y, HAMAR\u{00d8}Y, SVOLV\u{00c6}R, SVOLV\u{00c6}R, SVOLV\u{00c6}R, KABELV\u{00c5}G, KABELV\u{00c5}G, HENNINGSV\u{00c6}R, HENNINGSV\u{00c6}R, KLEPPSTAD, GIMS\u{00d8}YSAND, LAUKVIK, LAUPSTAD, STR\u{00d8}NSTAD, SKROVA, BRETTESNES, STORFJELL, DIGERMULEN, TENGELFJORD, MYRLAND, STORMOLLA, STAMSUND, SENNESVIK, VALBERG, B\u{00d8}STAD, B\u{00d8}STAD, LEKNES, GRAVDAL, BALLSTAD, BALLSTAD, LEKNES, GRAVDAL, STAMSUND, RAMBERG, NAPP, SUND I LOFOTEN, FREDVANG, RAMBERG, REINE, S\u{00d8}RV\u{00c5}GEN, S\u{00d8}RV\u{00c5}GEN, REINE, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, GULLESFJORD, L\u{00d8}DINGEN, L\u{00d8}DINGEN, VESTBYGD, KVITNES, HENNES, SORTLAND, SORTLAND, SORTLAND, BARKESTAD, TUNSTAD, MYRE, ALSV\u{00c5}G, ST\u{00d8}, MYRE, MELBU, LONKAN, STOKMARKNES, STOKMARKNES, MELBU, STRAUMSJ\u{00d8}EN, B\u{00d8} I VESTER\u{00c5}LEN, B\u{00d8} I VESTER\u{00c5}LEN, STRAUMSJ\u{00d8}EN, ANDENES, BLEIK, ANDENES, RIS\u{00d8}YHAMN, DVERBERG, N\u{00d8}SS, NORDMELA, RIS\u{00d8}YHAMN, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, BEISFJORD, ELVEG\u{00c5}RD, BJERKVIK, BJERKVIK, BOGEN I OFOTEN, LILAND, T\u{00c5}RSTAD, EVENES, BOGEN I OFOTEN, BALLANGEN, KJELDEBOTN, BALLANGEN, KJ\u{00d8}PSVIK, KJ\u{00d8}PSVIK, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, SKONSENG, MO I RANA, DALSGRENDA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, STORFORSHEI, MO I RANA, STORFORSHEI, HEMNESBERGET, HEMNESBERGET, FINNEIDFJORD, BJERKA, BJERKA, KORGEN, BLEIKVASSLIA, KORGEN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, MOSJ\u{00d8}EN, ELSFJORD, TROFORS, TROFORS, HATTFJELLDAL, HATTFJELLDAL, NESNA, NESNA, VIKHOLMEN, HUSBY, SAURA, UTSKARPEN, BRATLAND, ALDRA, STUVLAND, STOKKV\u{00c5}GEN, NORD-SOLV\u{00c6}R, SELV\u{00c6}R, INDRE KVAR\u{00d8}Y, TONNES, KONSVIKOSEN, KONSVIKOSEN, \u{00d8}RESVIK, SLENESET, LOVUND, LUR\u{00d8}Y, LUR\u{00d8}Y, TR\u{00c6}NA, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, SANDNESSJ\u{00d8}EN, L\u{00d8}KTA, D\u{00d8}NNA, D\u{00d8}NNA, VANDVE, BRAS\u{00d8}Y, SANDV\u{00c6}R, HER\u{00d8}Y, HER\u{00d8}Y, HER\u{00d8}Y, AUSTB\u{00d8}, TJ\u{00d8}TTA, TJ\u{00d8}TTA, TRO, VISTHUS, B\u{00c6}R\u{00d8}YV\u{00c5}GEN, LEIRFJORD, LEIRFJORD, SUND\u{00d8}Y, BARDAL, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, BR\u{00d8}NN\u{00d8}YSUND, S\u{00d8}MNA, S\u{00d8}MNA, S\u{00d8}MNA, VELFJORD, VELFJORD, VEVELSTAD, VEVELSTAD, VEGA, VEGA, YLVINGEN, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMSDALEN, TROMSDALEN, KROKELVDALEN, KROKELVDALEN, TOMASJORD, RAMFJORDBOTN, TROMSDALEN, SJURSNES, OLDERVIK, TROMS\u{00d8}, TROMS\u{00d8}, NORDKJOSBOTN, LAKSVATN, J\u{00d8}VIK, OTEREN, NORDKJOSBOTN, STORSTEINNES, MEISTERVIK, MORTENHALS, VIKRAN, STORSTEINNES, LYNGSEIDET, FURUFLATEN, SVENSBY, NORD-LENANGEN, LYNGSEIDET, KVAL\u{00d8}YSLETTA, KVAL\u{00d8}YSLETTA, KVAL\u{00d8}YSLETTA, KVAL\u{00d8}YA, KVAL\u{00d8}YA, KVAL\u{00d8}YA, STRAUMSBUKTA, KVAL\u{00d8}YA, KVAL\u{00d8}YA, SOMMAR\u{00d8}Y, BRENSHOLMEN, SOMMAR\u{00d8}Y, VENGS\u{00d8}Y, TUSS\u{00d8}Y, HANSNES, K\u{00c5}RVIK, STAKKVIK, HANSNES, VANNV\u{00c5}G, VANNAREID, VANNV\u{00c5}G, KARLS\u{00d8}Y, REBBENES, MJ\u{00d8}LVIK, SKIBOTN, SKIBOTN, SAMUELSBERG, SAMUELSBERG, OLDERDALEN, BIRTAVARRE, OLDERDALEN, BIRTAVARRE, STORSLETT, S\u{00d8}RKJOSEN, ROTSUND, S\u{00d8}RKJOSEN, STORSLETT, HAVNNES, BURFJORD, S\u{00d8}RSTRAUMEN, J\u{00d8}KELFJORD, BURFJORD, LONGYEARBYEN, LONGYEARBYEN, NY-\u{00c5}LESUND, HOPEN, SVEAGRUVA, BJ\u{00d8}RN\u{00d8}YA, BARENTSBURG, SKJERV\u{00d8}Y, HAMNEIDET, SEGLVIK, REINFJORD, SPILDRA, ANDSNES, VALANHAMN, SKJERV\u{00d8}Y, AKKARVIK, ARN\u{00d8}YHAMN, NIKKEBY, LAUKSLETTA, \u{00c5}RVIKSAND, UL\u{00d8}YBUKT, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, TROMS\u{00d8}, FINNSNES, ROSSFJORDSTRAUMEN, SILSAND, VANGSVIK, FINNSNES, FINNSNES, FINNSNES, FINNSNES, FINNSNES, S\u{00d8}RREISA, BR\u{00d8}STADBOTN, S\u{00d8}RREISA, BR\u{00d8}STADBOTN, MOEN, KARLSTAD, BARDUFOSS, BARDUFOSS, MOEN, \u{00d8}VERBYGD, \u{00d8}VERBYGD, RUNDHAUG, SJ\u{00d8}VEGAN, SJ\u{00d8}VEGAN, TENNEVOLL, TENNEVOLL, BARDU, BARDU, SILSAND, GIBOSTAD, BOTNHAMN, SKATVIK, GRYLLEFJORD, GRYLLEFJORD, TORSKEN, GIBOSTAD, SKALAND, SKALAND, SENJAHOPEN, SENJAHOPEN, FJORDGARD, HUS\u{00d8}Y I SENJA, STONGLANDSEIDET, STONGLANDSEIDET, FLAKSTADV\u{00c5}G, KALDFARNES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, S\u{00d8}RVIK, LUNDENES, GR\u{00d8}TAV\u{00c6}R, KJ\u{00d8}TTA, SANDS\u{00d8}Y, BJARK\u{00d8}Y, MEL\u{00d8}YV\u{00c6}R, SANDTORG, KONGSVIK, EVENSKJER, EVENSKJER, FJELLDAL, RAMSUND, MYKLEBOSTAD, HOL I TJELDSUND, TOVIK, GROVFJORD, GROVFJORD, RAMSUND, HAMNVIK, HAMNVIK, KR\u{00c5}KR\u{00d8}HAMN, \u{00c5}NSTAD, ENGENES, ENGENES, GRATANGEN, GRATANGEN, BORKENES, BORKENES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, KVIBY, KAUTOKEINO, KAUTOKEINO, MAZE, KVALFJORD, HAKKSTABBEN, KONGSHUS, KORSFJORDEN, TALVIK, LANGFJORDBOTN, \u{00d8}KSFJORD, BERGSFJORD, NUVSV\u{00c5}G, LANGFJORDHAMN, S\u{00d8}R-TVERRFJORD, SANDLAND, LOPPA, SKAVNAKK, HASVIK, HASVIK, BREIVIKBOTN, S\u{00d8}RV\u{00c6}R, HAMMERFEST, HAMMERFEST, HAMMERFEST, HAMMERFEST, NORDRE SEILAND, RYPEFJORD, RYPEFJORD, FORS\u{00d8}L, HAMMERFEST, HAMMERFEST, KVALSUND, KVALSUND, REVSNESHAMN, AKKARFJORD, LANGSTRAND, K\u{00c5}RHAMN, SAND\u{00d8}YBOTN, TUFJORD, ING\u{00d8}Y, HAV\u{00d8}YSUND, HAV\u{00d8}YSUND, M\u{00c5}S\u{00d8}Y, LAKSELV, PORSANGMOEN, INDRE BILLEFJORD, LAKSELV, LAKSELV, RUSSENES, SNEFJORD, KOKELV, B\u{00d8}RSELV, VEIDNESKLUBBEN, SKOGANVARRE, KARASJOK, KARASJOK, LEBESBY, KUNES, HONNINGSV\u{00c5}G, HONNINGSV\u{00c5}G, NORDV\u{00c5}GEN, SKARSV\u{00c5}G, NORDKAPP, GJESV\u{00c6}R, REPV\u{00c5}G, MEHAMN, SKJ\u{00c5}NES, LANGFJORDNES, NERVEI, GAMVIK, DYFJORD, KJ\u{00d8}LLEFJORD, VADS\u{00d8}, VESTRE JAKOBSELV, VESTRE JAKOBSELV, VADS\u{00d8}, VADS\u{00d8}, VARANGERBOTN, SIRMA, VARANGERBOTN, TANA, TANA, KIRKENES, BJ\u{00d8}RNEVATN, HESSENG, BJ\u{00d8}RNEVATN, KIRKENES, HESSENG, KIRKENES, SVANVIK, NEIDEN, BUG\u{00d8}YNES, VARD\u{00d8}, VARD\u{00d8}, KIBERG, BERLEV\u{00c5}G, BERLEV\u{00c5}G, KONGSFJORD, B\u{00c5}TSFJORD, B\u{00c5}TSFJORD").ca

	l = Array(repeating:StringReference(), count: Int(10000))

	p = strSplitByString(&poststeder, &characterArray(", ").ca)

	nr = HentPostnummerListe()

	i = 0.0
	while(i < Double(nr.count)){
		l[Int(nr[Int(i)])] = p[Int(i)]
		i = i + 1.0
	}

	return l
}


func HentPostnummerListe() -> [Double]{
	var n : [Double]

	n = StringToNumberArray(&characterArray("0001, 0010, 0015, 0018, 0021, 0024, 0026, 0028, 0030, 0031, 0032, 0033, 0034, 0037, 0040, 0045, 0046, 0047, 0048, 0050, 0055, 0060, 0081, 0101, 0102, 0103, 0104, 0105, 0106, 0107, 0109, 0110, 0111, 0112, 0113, 0114, 0115, 0116, 0117, 0118, 0119, 0120, 0121, 0122, 0123, 0124, 0125, 0128, 0129, 0130, 0131, 0132, 0133, 0134, 0135, 0136, 0138, 0139, 0140, 0150, 0151, 0152, 0153, 0154, 0155, 0157, 0158, 0159, 0160, 0161, 0162, 0164, 0165, 0166, 0167, 0168, 0169, 0170, 0171, 0172, 0173, 0174, 0175, 0176, 0177, 0178, 0179, 0180, 0181, 0182, 0183, 0184, 0185, 0186, 0187, 0188, 0190, 0191, 0192, 0193, 0194, 0195, 0196, 0198, 0201, 0202, 0203, 0204, 0207, 0208, 0211, 0212, 0213, 0214, 0215, 0216, 0217, 0218, 0230, 0240, 0244, 0247, 0250, 0251, 0252, 0253, 0254, 0255, 0256, 0257, 0258, 0259, 0260, 0262, 0263, 0264, 0265, 0266, 0267, 0268, 0270, 0271, 0272, 0273, 0274, 0275, 0276, 0277, 0278, 0279, 0280, 0281, 0282, 0283, 0284, 0286, 0287, 0301, 0302, 0303, 0304, 0305, 0306, 0307, 0308, 0309, 0311, 0313, 0314, 0315, 0316, 0317, 0318, 0319, 0323, 0330, 0340, 0349, 0350, 0351, 0352, 0353, 0354, 0355, 0356, 0357, 0358, 0359, 0360, 0361, 0362, 0363, 0364, 0365, 0366, 0367, 0368, 0369, 0370, 0371, 0372, 0373, 0374, 0375, 0376, 0377, 0378, 0379, 0380, 0381, 0382, 0383, 0401, 0402, 0403, 0404, 0405, 0406, 0409, 0410, 0411, 0412, 0413, 0415, 0421, 0422, 0423, 0424, 0440, 0441, 0442, 0445, 0450, 0451, 0452, 0454, 0455, 0456, 0457, 0458, 0459, 0460, 0461, 0462, 0463, 0464, 0465, 0467, 0468, 0469, 0470, 0472, 0473, 0474, 0475, 0476, 0477, 0478, 0479, 0480, 0481, 0482, 0483, 0484, 0485, 0486, 0487, 0488, 0489, 0490, 0491, 0492, 0493, 0494, 0495, 0496, 0501, 0502, 0503, 0504, 0505, 0506, 0507, 0508, 0509, 0510, 0511, 0512, 0513, 0515, 0516, 0517, 0518, 0520, 0540, 0550, 0551, 0552, 0553, 0554, 0555, 0556, 0557, 0558, 0559, 0560, 0561, 0562, 0563, 0564, 0565, 0566, 0567, 0568, 0569, 0570, 0571, 0572, 0573, 0574, 0575, 0576, 0577, 0578, 0579, 0580, 0581, 0582, 0583, 0584, 0585, 0586, 0587, 0588, 0589, 0590, 0591, 0592, 0593, 0594, 0595, 0596, 0597, 0598, 0601, 0602, 0603, 0604, 0605, 0606, 0607, 0608, 0609, 0611, 0612, 0613, 0614, 0615, 0616, 0617, 0618, 0619, 0620, 0621, 0622, 0623, 0624, 0626, 0650, 0651, 0652, 0653, 0654, 0655, 0656, 0657, 0658, 0659, 0660, 0661, 0662, 0663, 0664, 0665, 0666, 0667, 0668, 0669, 0670, 0671, 0672, 0673, 0674, 0675, 0676, 0677, 0678, 0679, 0680, 0681, 0682, 0683, 0684, 0685, 0686, 0687, 0688, 0689, 0690, 0691, 0692, 0693, 0694, 0701, 0702, 0705, 0710, 0712, 0750, 0751, 0752, 0753, 0754, 0755, 0756, 0757, 0758, 0760, 0763, 0764, 0765, 0766, 0767, 0768, 0770, 0771, 0772, 0773, 0774, 0775, 0776, 0777, 0778, 0779, 0781, 0782, 0783, 0784, 0785, 0786, 0787, 0788, 0789, 0790, 0791, 0801, 0805, 0806, 0807, 0840, 0850, 0851, 0852, 0853, 0854, 0855, 0856, 0857, 0858, 0860, 0861, 0862, 0863, 0864, 0870, 0871, 0872, 0873, 0874, 0875, 0876, 0877, 0880, 0881, 0882, 0883, 0884, 0890, 0891, 0901, 0902, 0903, 0904, 0905, 0907, 0908, 0913, 0914, 0915, 0950, 0951, 0952, 0953, 0954, 0955, 0956, 0957, 0958, 0959, 0960, 0962, 0963, 0964, 0968, 0969, 0970, 0971, 0972, 0973, 0975, 0976, 0977, 0978, 0979, 0980, 0981, 0982, 0983, 0984, 0985, 0986, 0987, 0988, 1001, 1003, 1005, 1006, 1007, 1008, 1009, 1011, 1051, 1052, 1053, 1054, 1055, 1056, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1069, 1071, 1081, 1083, 1084, 1086, 1087, 1088, 1089, 1101, 1102, 1108, 1109, 1112, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1172, 1176, 1177, 1178, 1179, 1181, 1182, 1184, 1185, 1187, 1188, 1189, 1201, 1203, 1204, 1205, 1207, 1214, 1215, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1262, 1263, 1266, 1270, 1271, 1272, 1273, 1274, 1275, 1278, 1279, 1281, 1283, 1284, 1285, 1286, 1290, 1291, 1294, 1295, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1311, 1312, 1313, 1314, 1316, 1317, 1318, 1319, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1344, 1346, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1371, 1372, 1373, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1501, 1502, 1503, 1504, 1506, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1545, 1550, 1555, 1556, 1560, 1561, 1570, 1580, 1581, 1590, 1591, 1592, 1593, 1594, 1596, 1597, 1598, 1599, 1601, 1602, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1628, 1629, 1630, 1632, 1633, 1634, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1650, 1651, 1653, 1654, 1655, 1657, 1658, 1659, 1661, 1662, 1663, 1664, 1665, 1666, 1667, 1670, 1671, 1672, 1673, 1675, 1676, 1678, 1679, 1680, 1682, 1683, 1684, 1690, 1692, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1730, 1733, 1734, 1735, 1738, 1739, 1740, 1742, 1743, 1745, 1746, 1747, 1751, 1752, 1753, 1754, 1757, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1771, 1772, 1776, 1777, 1778, 1779, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1796, 1798, 1799, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813, 1814, 1815, 1816, 1820, 1821, 1823, 1825, 1827, 1830, 1831, 1832, 1833, 1850, 1851, 1852, 1859, 1860, 1861, 1866, 1867, 1870, 1871, 1875, 1878, 1880, 1890, 1891, 1892, 1893, 1894, 1900, 1901, 1903, 1910, 1911, 1912, 1914, 1916, 1917, 1920, 1921, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1940, 1941, 1950, 1954, 1960, 1961, 1963, 1970, 1971, 2000, 2001, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2040, 2041, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2060, 2061, 2062, 2063, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2076, 2080, 2081, 2090, 2091, 2092, 2093, 2094, 2100, 2101, 2110, 2114, 2116, 2120, 2121, 2123, 2130, 2132, 2133, 2134, 2150, 2151, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2170, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2223, 2224, 2225, 2226, 2227, 2230, 2231, 2232, 2233, 2235, 2240, 2241, 2251, 2256, 2260, 2261, 2264, 2265, 2266, 2270, 2271, 2280, 2283, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2344, 2345, 2346, 2350, 2351, 2353, 2355, 2360, 2361, 2364, 2365, 2372, 2373, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2432, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2446, 2447, 2448, 2450, 2451, 2460, 2461, 2476, 2477, 2478, 2480, 2481, 2484, 2485, 2486, 2487, 2488, 2500, 2501, 2510, 2512, 2513, 2540, 2541, 2542, 2544, 2550, 2551, 2552, 2555, 2560, 2561, 2580, 2581, 2582, 2584, 2601, 2602, 2603, 2604, 2605, 2606, 2607, 2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617, 2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627, 2628, 2629, 2630, 2631, 2632, 2633, 2634, 2635, 2636, 2637, 2638, 2639, 2640, 2641, 2642, 2643, 2644, 2645, 2646, 2647, 2648, 2649, 2651, 2652, 2653, 2654, 2656, 2657, 2658, 2659, 2660, 2661, 2662, 2663, 2664, 2665, 2666, 2667, 2668, 2669, 2670, 2671, 2672, 2673, 2674, 2675, 2676, 2677, 2678, 2679, 2680, 2681, 2682, 2683, 2684, 2685, 2686, 2687, 2688, 2690, 2693, 2694, 2695, 2711, 2712, 2713, 2714, 2715, 2716, 2717, 2718, 2720, 2730, 2740, 2742, 2743, 2750, 2760, 2770, 2801, 2802, 2803, 2804, 2805, 2806, 2807, 2808, 2809, 2810, 2811, 2812, 2815, 2816, 2817, 2818, 2819, 2820, 2821, 2822, 2825, 2827, 2830, 2831, 2832, 2833, 2834, 2835, 2836, 2837, 2838, 2839, 2840, 2841, 2843, 2844, 2845, 2846, 2847, 2848, 2849, 2850, 2851, 2853, 2854, 2857, 2858, 2860, 2861, 2862, 2864, 2866, 2867, 2870, 2879, 2880, 2881, 2882, 2890, 2893, 2900, 2901, 2907, 2909, 2910, 2917, 2918, 2920, 2923, 2929, 2930, 2933, 2936, 2937, 2939, 2940, 2943, 2950, 2952, 2953, 2954, 2959, 2960, 2965, 2966, 2967, 2972, 2973, 2974, 2975, 2977, 2985, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3050, 3051, 3053, 3054, 3055, 3056, 3057, 3058, 3060, 3061, 3063, 3064, 3065, 3066, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3095, 3101, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3131, 3132, 3133, 3134, 3135, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3148, 3150, 3151, 3152, 3153, 3154, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3199, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3251, 3252, 3253, 3254, 3255, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3267, 3268, 3269, 3270, 3271, 3274, 3275, 3276, 3277, 3280, 3281, 3282, 3284, 3285, 3290, 3291, 3292, 3294, 3295, 3296, 3297, 3300, 3301, 3302, 3303, 3320, 3321, 3322, 3330, 3331, 3340, 3341, 3342, 3350, 3351, 3355, 3357, 3358, 3359, 3360, 3361, 3370, 3371, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3420, 3421, 3425, 3426, 3427, 3428, 3430, 3431, 3440, 3441, 3442, 3470, 3471, 3472, 3474, 3475, 3476, 3477, 3478, 3479, 3480, 3481, 3482, 3483, 3484, 3485, 3490, 3501, 3502, 3503, 3504, 3507, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528, 3529, 3530, 3531, 3532, 3533, 3534, 3535, 3536, 3537, 3538, 3539, 3540, 3541, 3543, 3544, 3545, 3550, 3551, 3560, 3561, 3570, 3571, 3575, 3576, 3577, 3579, 3580, 3581, 3588, 3593, 3595, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621, 3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631, 3632, 3634, 3646, 3647, 3648, 3650, 3652, 3656, 3658, 3660, 3661, 3665, 3666, 3671, 3672, 3673, 3674, 3675, 3676, 3677, 3678, 3679, 3680, 3681, 3683, 3684, 3690, 3691, 3692, 3697, 3701, 3702, 3703, 3704, 3705, 3707, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3746, 3747, 3748, 3749, 3750, 3753, 3760, 3766, 3770, 3772, 3780, 3781, 3783, 3785, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3810, 3811, 3812, 3820, 3825, 3830, 3831, 3832, 3833, 3834, 3835, 3836, 3840, 3841, 3844, 3848, 3849, 3850, 3852, 3853, 3854, 3855, 3864, 3870, 3880, 3882, 3883, 3884, 3885, 3886, 3887, 3888, 3890, 3891, 3893, 3895, 3901, 3902, 3903, 3904, 3905, 3906, 3910, 3911, 3912, 3913, 3914, 3915, 3916, 3917, 3918, 3919, 3920, 3921, 3922, 3924, 3925, 3928, 3929, 3930, 3931, 3933, 3936, 3937, 3939, 3940, 3941, 3942, 3943, 3944, 3946, 3947, 3948, 3949, 3950, 3960, 3961, 3962, 3965, 3966, 3967, 3970, 3991, 3993, 3994, 3995, 3996, 3997, 3998, 3999, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4031, 4032, 4033, 4034, 4035, 4036, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071, 4072, 4073, 4076, 4077, 4078, 4079, 4081, 4082, 4083, 4084, 4085, 4086, 4087, 4088, 4089, 4090, 4091, 4092, 4093, 4094, 4095, 4096, 4097, 4098, 4099, 4100, 4102, 4110, 4119, 4120, 4123, 4124, 4126, 4127, 4128, 4129, 4130, 4134, 4137, 4139, 4146, 4148, 4150, 4152, 4153, 4154, 4156, 4158, 4159, 4160, 4161, 4163, 4164, 4167, 4168, 4169, 4170, 4173, 4174, 4180, 4181, 4182, 4187, 4198, 4200, 4201, 4208, 4209, 4230, 4233, 4234, 4235, 4237, 4239, 4240, 4244, 4250, 4260, 4262, 4264, 4265, 4270, 4272, 4274, 4275, 4276, 4280, 4291, 4294, 4295, 4296, 4297, 4298, 4299, 4301, 4302, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4317, 4318, 4319, 4320, 4321, 4322, 4323, 4324, 4325, 4326, 4327, 4328, 4329, 4330, 4332, 4333, 4335, 4336, 4337, 4338, 4339, 4340, 4341, 4342, 4343, 4344, 4345, 4346, 4347, 4348, 4349, 4352, 4353, 4354, 4355, 4356, 4357, 4358, 4360, 4361, 4362, 4363, 4364, 4365, 4367, 4368, 4369, 4370, 4371, 4372, 4373, 4374, 4375, 4376, 4378, 4379, 4380, 4381, 4384, 4385, 4387, 4389, 4390, 4391, 4392, 4393, 4394, 4395, 4396, 4397, 4398, 4399, 4400, 4401, 4402, 4403, 4420, 4432, 4434, 4436, 4438, 4439, 4440, 4441, 4443, 4460, 4462, 4463, 4465, 4473, 4480, 4484, 4485, 4490, 4491, 4492, 4501, 4502, 4503, 4504, 4507, 4508, 4509, 4513, 4514, 4515, 4516, 4517, 4519, 4520, 4521, 4522, 4523, 4524, 4525, 4526, 4528, 4529, 4532, 4534, 4535, 4536, 4540, 4541, 4544, 4550, 4551, 4552, 4553, 4554, 4557, 4558, 4560, 4563, 4575, 4576, 4577, 4579, 4580, 4586, 4588, 4590, 4595, 4596, 4597, 4604, 4605, 4606, 4608, 4609, 4610, 4611, 4612, 4613, 4614, 4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624, 4625, 4626, 4628, 4629, 4630, 4631, 4632, 4633, 4634, 4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644, 4645, 4646, 4647, 4649, 4656, 4657, 4658, 4661, 4662, 4663, 4664, 4665, 4666, 4670, 4671, 4672, 4673, 4674, 4675, 4676, 4677, 4678, 4679, 4681, 4682, 4683, 4684, 4685, 4686, 4687, 4688, 4689, 4691, 4693, 4694, 4695, 4696, 4697, 4698, 4699, 4700, 4701, 4702, 4703, 4705, 4706, 4707, 4708, 4715, 4720, 4721, 4724, 4725, 4730, 4733, 4734, 4735, 4737, 4741, 4742, 4744, 4745, 4746, 4747, 4748, 4749, 4754, 4755, 4756, 4760, 4766, 4768, 4770, 4780, 4790, 4791, 4792, 4793, 4794, 4795, 4801, 4802, 4803, 4804, 4808, 4809, 4810, 4812, 4815, 4816, 4817, 4818, 4820, 4821, 4822, 4823, 4824, 4825, 4827, 4828, 4830, 4832, 4834, 4836, 4838, 4839, 4841, 4842, 4843, 4844, 4846, 4847, 4848, 4849, 4851, 4852, 4853, 4854, 4855, 4856, 4857, 4858, 4859, 4862, 4863, 4864, 4865, 4868, 4869, 4870, 4876, 4877, 4878, 4879, 4884, 4885, 4886, 4887, 4888, 4889, 4891, 4892, 4893, 4894, 4896, 4898, 4900, 4901, 4902, 4909, 4910, 4912, 4915, 4916, 4920, 4921, 4934, 4950, 4951, 4952, 4953, 4955, 4956, 4957, 4971, 4972, 4973, 4974, 4980, 4985, 4990, 4993, 4994, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5041, 5042, 5043, 5045, 5052, 5053, 5054, 5055, 5056, 5057, 5058, 5059, 5063, 5067, 5068, 5072, 5073, 5075, 5081, 5082, 5089, 5093, 5094, 5096, 5097, 5098, 5099, 5101, 5104, 5105, 5106, 5107, 5108, 5109, 5111, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5121, 5122, 5124, 5130, 5131, 5132, 5134, 5135, 5136, 5137, 5141, 5142, 5143, 5144, 5145, 5146, 5147, 5148, 5151, 5152, 5153, 5154, 5155, 5160, 5161, 5162, 5163, 5164, 5165, 5170, 5171, 5172, 5173, 5174, 5176, 5177, 5178, 5179, 5183, 5184, 5200, 5201, 5202, 5203, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 5218, 5221, 5222, 5223, 5224, 5225, 5226, 5227, 5228, 5229, 5230, 5231, 5232, 5235, 5236, 5237, 5238, 5239, 5243, 5244, 5251, 5252, 5253, 5254, 5257, 5258, 5259, 5260, 5261, 5262, 5263, 5264, 5265, 5267, 5268, 5281, 5282, 5283, 5284, 5285, 5286, 5291, 5293, 5299, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5314, 5315, 5318, 5319, 5321, 5322, 5323, 5325, 5326, 5327, 5329, 5331, 5333, 5334, 5335, 5336, 5337, 5341, 5342, 5343, 5345, 5346, 5347, 5350, 5353, 5354, 5355, 5357, 5358, 5360, 5363, 5365, 5366, 5371, 5374, 5378, 5379, 5380, 5381, 5382, 5384, 5385, 5387, 5388, 5392, 5393, 5394, 5396, 5397, 5398, 5399, 5401, 5402, 5403, 5404, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5423, 5427, 5428, 5430, 5437, 5440, 5443, 5444, 5445, 5447, 5449, 5450, 5451, 5452, 5453, 5454, 5455, 5457, 5458, 5459, 5460, 5462, 5463, 5464, 5465, 5470, 5472, 5473, 5474, 5475, 5476, 5480, 5484, 5486, 5498, 5499, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5511, 5512, 5514, 5515, 5516, 5517, 5518, 5519, 5521, 5522, 5523, 5525, 5527, 5528, 5529, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5541, 5542, 5544, 5545, 5546, 5547, 5548, 5549, 5550, 5551, 5554, 5555, 5556, 5559, 5560, 5561, 5562, 5563, 5565, 5566, 5567, 5568, 5569, 5570, 5574, 5575, 5576, 5578, 5580, 5582, 5583, 5584, 5585, 5586, 5588, 5589, 5590, 5591, 5593, 5594, 5595, 5596, 5598, 5600, 5601, 5602, 5604, 5605, 5610, 5612, 5614, 5620, 5626, 5627, 5628, 5629, 5630, 5631, 5632, 5633, 5635, 5636, 5637, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648, 5649, 5650, 5651, 5652, 5653, 5680, 5683, 5685, 5687, 5690, 5693, 5694, 5695, 5696, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5718, 5719, 5720, 5721, 5722, 5723, 5724, 5725, 5726, 5727, 5728, 5729, 5730, 5731, 5732, 5733, 5734, 5736, 5741, 5742, 5743, 5745, 5746, 5747, 5748, 5750, 5751, 5752, 5760, 5763, 5770, 5773, 5775, 5776, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5833, 5834, 5835, 5836, 5837, 5838, 5841, 5843, 5844, 5845, 5847, 5848, 5849, 5851, 5852, 5853, 5854, 5855, 5857, 5858, 5859, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5872, 5873, 5876, 5877, 5878, 5879, 5881, 5884, 5886, 5887, 5888, 5889, 5892, 5893, 5895, 5896, 5899, 5902, 5903, 5904, 5906, 5907, 5908, 5911, 5912, 5913, 5914, 5915, 5916, 5917, 5918, 5919, 5931, 5935, 5936, 5937, 5938, 5939, 5941, 5943, 5947, 5948, 5951, 5952, 5953, 5954, 5955, 5956, 5957, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5970, 5977, 5978, 5979, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5991, 5993, 5994, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6028, 6030, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6044, 6045, 6046, 6047, 6048, 6050, 6051, 6052, 6054, 6055, 6057, 6058, 6059, 6060, 6062, 6063, 6064, 6065, 6067, 6068, 6069, 6070, 6075, 6076, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6094, 6095, 6096, 6098, 6099, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6110, 6120, 6133, 6134, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6146, 6147, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6160, 6161, 6165, 6166, 6170, 6171, 6174, 6183, 6184, 6190, 6196, 6200, 6201, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6222, 6223, 6224, 6230, 6238, 6239, 6240, 6249, 6250, 6255, 6259, 6260, 6263, 6264, 6265, 6270, 6272, 6280, 6281, 6282, 6283, 6285, 6290, 6291, 6292, 6293, 6294, 6300, 6301, 6310, 6315, 6320, 6330, 6331, 6339, 6350, 6360, 6361, 6363, 6364, 6365, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6401, 6402, 6403, 6404, 6405, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6418, 6419, 6421, 6422, 6423, 6425, 6429, 6430, 6431, 6433, 6434, 6435, 6436, 6440, 6443, 6444, 6445, 6446, 6447, 6450, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6460, 6461, 6462, 6470, 6471, 6472, 6475, 6476, 6480, 6481, 6483, 6484, 6485, 6486, 6487, 6488, 6490, 6493, 6494, 6499, 6501, 6502, 6503, 6504, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6514, 6515, 6516, 6517, 6518, 6520, 6521, 6522, 6523, 6524, 6525, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6538, 6539, 6546, 6547, 6548, 6549, 6570, 6571, 6590, 6591, 6600, 6601, 6610, 6611, 6612, 6613, 6614, 6620, 6622, 6623, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6650, 6652, 6653, 6655, 6656, 6657, 6658, 6659, 6670, 6671, 6674, 6680, 6683, 6686, 6687, 6688, 6689, 6690, 6693, 6694, 6697, 6698, 6699, 6700, 6701, 6702, 6703, 6704, 6707, 6708, 6710, 6711, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6721, 6723, 6726, 6727, 6728, 6729, 6730, 6734, 6737, 6740, 6741, 6750, 6751, 6761, 6763, 6770, 6771, 6772, 6773, 6774, 6776, 6777, 6778, 6779, 6781, 6782, 6783, 6784, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799, 6800, 6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6826, 6827, 6828, 6829, 6830, 6831, 6841, 6843, 6844, 6845, 6847, 6848, 6849, 6851, 6852, 6853, 6854, 6855, 6856, 6858, 6859, 6861, 6863, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6881, 6882, 6884, 6885, 6886, 6887, 6888, 6891, 6893, 6894, 6895, 6896, 6898, 6899, 6900, 6901, 6902, 6903, 6905, 6906, 6907, 6908, 6909, 6910, 6912, 6913, 6914, 6915, 6916, 6917, 6918, 6919, 6921, 6924, 6926, 6927, 6928, 6929, 6940, 6941, 6942, 6944, 6946, 6947, 6951, 6953, 6957, 6958, 6959, 6961, 6963, 6964, 6966, 6967, 6968, 6969, 6971, 6973, 6975, 6976, 6977, 6978, 6980, 6982, 6983, 6984, 6985, 6986, 6987, 6988, 6991, 6993, 6995, 6996, 6997, 7003, 7004, 7005, 7006, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050, 7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7066, 7067, 7068, 7069, 7070, 7071, 7072, 7074, 7075, 7078, 7079, 7080, 7081, 7082, 7083, 7088, 7089, 7091, 7092, 7093, 7097, 7098, 7099, 7100, 7101, 7105, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7119, 7120, 7121, 7125, 7126, 7127, 7129, 7130, 7140, 7142, 7150, 7151, 7152, 7153, 7156, 7159, 7160, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7174, 7175, 7176, 7177, 7178, 7180, 7181, 7190, 7194, 7200, 7201, 7203, 7206, 7211, 7212, 7213, 7221, 7223, 7224, 7227, 7228, 7231, 7232, 7234, 7235, 7236, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7250, 7252, 7255, 7256, 7257, 7259, 7260, 7261, 7263, 7264, 7266, 7267, 7268, 7270, 7273, 7274, 7280, 7282, 7284, 7285, 7286, 7287, 7288, 7289, 7290, 7291, 7295, 7298, 7300, 7301, 7302, 7310, 7315, 7316, 7318, 7319, 7320, 7321, 7327, 7329, 7331, 7332, 7333, 7334, 7335, 7336, 7338, 7340, 7341, 7342, 7343, 7345, 7350, 7351, 7353, 7354, 7355, 7356, 7357, 7358, 7361, 7370, 7372, 7374, 7380, 7383, 7384, 7386, 7387, 7388, 7391, 7392, 7393, 7397, 7398, 7399, 7400, 7401, 7402, 7403, 7404, 7405, 7406, 7407, 7408, 7409, 7410, 7411, 7412, 7413, 7414, 7415, 7416, 7417, 7418, 7419, 7420, 7421, 7422, 7424, 7425, 7426, 7427, 7428, 7429, 7430, 7431, 7432, 7433, 7434, 7435, 7436, 7437, 7438, 7439, 7440, 7441, 7442, 7443, 7444, 7445, 7446, 7447, 7448, 7449, 7450, 7451, 7452, 7453, 7454, 7455, 7456, 7457, 7458, 7459, 7462, 7463, 7464, 7465, 7466, 7467, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478, 7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7517, 7519, 7520, 7525, 7529, 7530, 7531, 7533, 7540, 7541, 7549, 7550, 7551, 7560, 7562, 7563, 7566, 7570, 7580, 7581, 7583, 7584, 7590, 7591, 7596, 7600, 7601, 7602, 7603, 7604, 7605, 7606, 7607, 7608, 7609, 7610, 7619, 7620, 7622, 7623, 7624, 7629, 7630, 7631, 7632, 7633, 7634, 7650, 7651, 7652, 7653, 7654, 7655, 7656, 7657, 7658, 7660, 7661, 7670, 7671, 7672, 7690, 7691, 7701, 7702, 7703, 7704, 7705, 7707, 7708, 7709, 7710, 7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7724, 7725, 7726, 7729, 7730, 7732, 7733, 7734, 7735, 7736, 7737, 7738, 7739, 7740, 7741, 7742, 7744, 7745, 7746, 7748, 7750, 7751, 7760, 7761, 7770, 7771, 7777, 7790, 7791, 7795, 7796, 7797, 7800, 7801, 7802, 7803, 7804, 7805, 7808, 7810, 7817, 7818, 7819, 7820, 7821, 7822, 7823, 7856, 7860, 7863, 7864, 7869, 7870, 7871, 7873, 7874, 7876, 7877, 7878, 7881, 7882, 7884, 7885, 7890, 7891, 7892, 7893, 7896, 7897, 7898, 7900, 7901, 7902, 7940, 7941, 7944, 7950, 7960, 7970, 7971, 7973, 7979, 7980, 7981, 7982, 7983, 7985, 7986, 7990, 7993, 7994, 7995, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8019, 8020, 8021, 8022, 8023, 8026, 8027, 8028, 8029, 8030, 8031, 8037, 8038, 8041, 8047, 8048, 8049, 8050, 8056, 8057, 8058, 8062, 8063, 8064, 8065, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8079, 8084, 8086, 8087, 8088, 8089, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8102, 8103, 8108, 8110, 8114, 8118, 8120, 8128, 8130, 8134, 8135, 8136, 8138, 8140, 8145, 8146, 8149, 8150, 8151, 8157, 8158, 8159, 8160, 8161, 8168, 8170, 8178, 8179, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8193, 8195, 8196, 8197, 8198, 8200, 8201, 8202, 8203, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8214, 8215, 8218, 8219, 8220, 8226, 8230, 8231, 8232, 8233, 8250, 8251, 8255, 8256, 8260, 8261, 8264, 8266, 8270, 8271, 8273, 8274, 8275, 8276, 8278, 8281, 8283, 8285, 8286, 8287, 8288, 8289, 8290, 8294, 8297, 8298, 8300, 8301, 8305, 8309, 8310, 8311, 8312, 8313, 8314, 8315, 8316, 8317, 8320, 8322, 8323, 8324, 8325, 8326, 8328, 8340, 8352, 8357, 8360, 8361, 8370, 8372, 8373, 8374, 8376, 8377, 8378, 8380, 8382, 8384, 8387, 8388, 8390, 8392, 8393, 8398, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8419, 8426, 8428, 8430, 8432, 8438, 8439, 8445, 8447, 8450, 8455, 8459, 8465, 8469, 8470, 8475, 8480, 8481, 8483, 8484, 8485, 8488, 8489, 8493, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8512, 8513, 8514, 8515, 8516, 8517, 8518, 8520, 8522, 8523, 8530, 8531, 8533, 8534, 8535, 8536, 8539, 8540, 8543, 8546, 8590, 8591, 8601, 8602, 8603, 8604, 8607, 8608, 8609, 8610, 8613, 8614, 8615, 8616, 8617, 8618, 8619, 8622, 8624, 8626, 8630, 8634, 8638, 8640, 8641, 8642, 8643, 8644, 8646, 8647, 8648, 8651, 8652, 8654, 8655, 8656, 8657, 8658, 8659, 8660, 8661, 8663, 8664, 8665, 8666, 8672, 8680, 8681, 8690, 8691, 8700, 8701, 8720, 8723, 8724, 8725, 8730, 8732, 8733, 8735, 8740, 8742, 8743, 8750, 8752, 8753, 8754, 8762, 8764, 8766, 8767, 8770, 8800, 8801, 8802, 8803, 8804, 8805, 8809, 8813, 8820, 8827, 8830, 8842, 8844, 8850, 8851, 8852, 8854, 8860, 8861, 8865, 8870, 8880, 8890, 8891, 8892, 8897, 8900, 8901, 8902, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8920, 8921, 8922, 8960, 8961, 8976, 8977, 8980, 8981, 8985, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9027, 9029, 9030, 9034, 9037, 9038, 9040, 9042, 9043, 9046, 9049, 9050, 9055, 9056, 9057, 9059, 9060, 9062, 9064, 9068, 9069, 9100, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9110, 9118, 9119, 9120, 9128, 9130, 9131, 9132, 9134, 9135, 9136, 9137, 9138, 9140, 9141, 9142, 9143, 9144, 9145, 9146, 9147, 9148, 9149, 9151, 9152, 9153, 9155, 9156, 9159, 9161, 9162, 9163, 9169, 9170, 9171, 9173, 9174, 9175, 9176, 9178, 9180, 9181, 9182, 9184, 9185, 9186, 9187, 9189, 9190, 9192, 9193, 9194, 9195, 9197, 9240, 9251, 9252, 9253, 9254, 9255, 9256, 9257, 9258, 9259, 9260, 9261, 9262, 9263, 9265, 9266, 9267, 9268, 9269, 9270, 9271, 9272, 9273, 9274, 9275, 9276, 9277, 9278, 9279, 9280, 9281, 9282, 9283, 9284, 9285, 9286, 9287, 9288, 9290, 9291, 9292, 9293, 9294, 9296, 9298, 9299, 9300, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9315, 9316, 9321, 9322, 9325, 9326, 9329, 9334, 9335, 9336, 9350, 9355, 9357, 9358, 9360, 9365, 9370, 9372, 9373, 9376, 9379, 9380, 9381, 9382, 9384, 9385, 9386, 9387, 9388, 9389, 9391, 9392, 9393, 9395, 9402, 9403, 9404, 9405, 9406, 9407, 9408, 9409, 9411, 9414, 9415, 9416, 9419, 9420, 9423, 9424, 9425, 9426, 9427, 9430, 9436, 9439, 9440, 9441, 9442, 9443, 9444, 9445, 9446, 9447, 9448, 9450, 9451, 9453, 9454, 9455, 9456, 9470, 9471, 9475, 9476, 9479, 9480, 9481, 9482, 9483, 9484, 9485, 9486, 9487, 9488, 9489, 9496, 9497, 9498, 9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512, 9513, 9514, 9515, 9516, 9517, 9518, 9519, 9520, 9521, 9525, 9531, 9532, 9533, 9536, 9540, 9545, 9550, 9580, 9582, 9583, 9584, 9585, 9586, 9587, 9590, 9591, 9593, 9595, 9600, 9601, 9602, 9603, 9609, 9610, 9611, 9612, 9615, 9616, 9620, 9621, 9624, 9650, 9651, 9657, 9664, 9670, 9672, 9690, 9691, 9692, 9700, 9709, 9710, 9711, 9712, 9713, 9714, 9715, 9716, 9717, 9722, 9730, 9735, 9740, 9742, 9750, 9751, 9760, 9763, 9764, 9765, 9768, 9770, 9771, 9772, 9773, 9775, 9782, 9790, 9800, 9802, 9810, 9811, 9815, 9820, 9826, 9840, 9845, 9846, 9900, 9910, 9912, 9914, 9915, 9916, 9917, 9925, 9930, 9935, 9950, 9951, 9960, 9980, 9981, 9982, 9990, 9991").ca)

	return n
}


func HentPoststed(_ nrString : inout [Character], _ feilmelding : inout Success) -> [Character]{
	var nr : Double
	var respons : [Character]
	var poststedListe : [StringReference]

	nr = CreateNumberFromDecimalString(&nrString)
	respons = characterArray("").ca

	if(ErGyldigPostnummer(&nrString)){
		feilmelding.success = true
		poststedListe = HentPoststedListe()
		respons = poststedListe[Int(nr)].stringx
	}else{
		feilmelding.success = false
		feilmelding.feilmelding = characterArray("Postnummer er ikke gyldig.").ca
	}

	return respons
}


func ErGyldigPostnummer(_ nrString : inout [Character]) -> Bool{
	var nr : Double
	var gyldigePostnummer : [Bool]
	var erGyldig : Bool

	nr = CreateNumberFromDecimalString(&nrString)
	gyldigePostnummer = GyldigPostnummertabell()

	if(nr > 0.0 && nr < 10000.0 && IsInteger(nr) && Double(nrString.count) == 4.0){
		erGyldig = gyldigePostnummer[Int(nr)]
	}else{
		erGyldig = false
	}

	return erGyldig
}


func GyldigPostnummertabell() -> [Bool]{
	var i, maxnummer : Double
	var postnummerliste : [Double]
	var rev : [Bool]

	postnummerliste = HentPostnummerListe()
	maxnummer = 0.0

	i = 0.0
	while(i < Double(postnummerliste.count)){
		maxnummer = max(maxnummer, postnummerliste[Int(i)])
		i = i + 1.0
	}

	rev = Array(repeating:Bool(), count: Int(maxnummer + 1.0))

	i = 0.0
	while(i < maxnummer){
		rev[Int(i)] = false
		i = i + 1.0
	}

	i = 0.0
	while(i < Double(postnummerliste.count)){
		rev[Int(postnummerliste[Int(i)])] = true
		i = i + 1.0
	}

	return rev
}


func Loess(_ xs : inout [Double], _ ys : inout [Double], _ bandwidth : Double, _ robustnessIters : Double, _ accuracy : Double, _ resultXs : inout NumberArrayReference, _ errorMessage : inout StringReference) -> Bool{
	var bandwidth = bandwidth;
	var robustnessIters = robustnessIters;
	var accuracy = accuracy;
	var weights : [Double]

	weights = Array(repeating:Double(), count: Int(Double(xs.count)))
	arraysFillNumberArray(&weights, 1.0)

	return Lowess(&xs, &ys, &weights, bandwidth, robustnessIters, accuracy, &resultXs, &errorMessage)
}


func Lowess(_ xs : inout [Double], _ ys : inout [Double], _ weights : inout [Double], _ bandwidth : Double, _ robustnessIters : Double, _ accuracy : Double, _ resultXs : inout NumberArrayReference, _ errorMessage : inout StringReference) -> Bool{
	var bandwidth = bandwidth;
	var robustnessIters = robustnessIters;
	var accuracy = accuracy;
	var res, residuals, sortedResiduals, robustnessWeights, indexes : [Double]
	var n, i, k : Double
	var x, sumWeights, sumX, sumXSquared, sumY, sumXY, denom : Double
	var xk, yk, dist, w, xkw : Double
	var meanX, meanY, meanXY, meanXSquared : Double
	var alpha, beta : Double
	var arg, iter, medianResidual : Double
	var bandwidthInterval : [Double]
	var ileft, iright, edge : Double
	var left, right, nextRight, nextLeft, bandwidthInPoints : Double
	var success, done : Bool

	/* Sort arrays*/
	indexes = QuickSortNumbersWithIndexes(&xs)
	RearrangeArray(&ys, &indexes)

	if(Double(xs.count) == Double(ys.count) && Double(xs.count) != 0.0){
		n = Double(xs.count)

		if(n == 1.0 || n == 2.0){
			if(n == 1.0){
				res = Array(repeating:Double(), count: Int(1))
				res[Int(0)] = ys[Int(0)]
			}else{
				res = Array(repeating:Double(), count: Int(2))
				res[Int(0)] = ys[Int(0)]
				res[Int(1)] = ys[Int(1)]
			}

			resultXs.numberArray = res
			success = true
		}else{
			bandwidthInPoints = Truncate(bandwidth*n)

			if(bandwidthInPoints >= 2.0){
				res = Array(repeating:Double(), count: Int(n))
				residuals = Array(repeating:Double(), count: Int(n))

				robustnessWeights = Array(repeating:Double(), count: Int(n))
				arraysFillNumberArray(&robustnessWeights, 1.0)

				done = false
				iter = 0.0
				while(iter <= robustnessIters && !done){
					bandwidthInterval = Array(repeating:Double(), count: Int(2))
					bandwidthInterval[Int(0)] = 0.0
					bandwidthInterval[Int(1)] = bandwidthInPoints - 1.0

					i = 0.0
					while(i < n){
						x = xs[Int(i)]

						if(i > 0.0){
							left = bandwidthInterval[Int(0)]
							right = bandwidthInterval[Int(1)]

							nextRight = FindNextNonZeroElement(&weights, right)
							nextLeft = left
							while(nextRight < Double(xs.count) && xs[Int(nextRight)] - xs[Int(i)] < xs[Int(i)] - xs[Int(nextLeft)]){
								nextLeft = FindNextNonZeroElement(&weights, bandwidthInterval[Int(0)])
								bandwidthInterval[Int(0)] = nextLeft
								bandwidthInterval[Int(1)] = nextRight
								nextRight = FindNextNonZeroElement(&weights, nextRight)
							}
						}

						ileft = bandwidthInterval[Int(0)]
						iright = bandwidthInterval[Int(1)]

						if(xs[Int(i)] - xs[Int(ileft)] > xs[Int(iright)] - xs[Int(i)]){
							edge = ileft
						}else{
							edge = iright
						}

						sumWeights = 0.0
						sumX = 0.0
						sumXSquared = 0.0
						sumY = 0.0
						sumXY = 0.0
						denom = abs(1.0/(xs[Int(edge)] - x))
						k = ileft
						while(k <= iright){
							xk = xs[Int(k)]
							yk = ys[Int(k)]

							if(k < i){
								dist = x - xk
							}else{
								dist = xk - x
							}

							w = Tricube(dist*denom)*robustnessWeights[Int(k)]*weights[Int(k)]
							xkw = xk*w
							sumWeights = sumWeights + w
							sumX = sumX + xkw
							sumXSquared = sumXSquared + xk*xkw
							sumY = sumY + yk*w
							sumXY = sumXY + yk*xkw
							k = k + 1.0
						}

						meanX = sumX/sumWeights
						meanY = sumY/sumWeights
						meanXY = sumXY/sumWeights
						meanXSquared = sumXSquared/sumWeights

						if(sqrt(abs(meanXSquared - meanX*meanX)) < accuracy){
							beta = 0.0
						}else{
							beta = (meanXY - meanX*meanY)/(meanXSquared - meanX*meanX)
						}

						alpha = meanY - beta*meanX

						res[Int(i)] = beta*x + alpha

						residuals[Int(i)] = abs(ys[Int(i)] - res[Int(i)])
						i = i + 1.0
					}

					if(iter == robustnessIters){
						done = true
					}

					if(!done){
						sortedResiduals = arraysCopyNumberArray(&residuals)
						QuickSortNumbers(&sortedResiduals)

						medianResidual = sortedResiduals[Int(n/2.0)]

						if(abs(medianResidual) < accuracy){
							done = true
						}

						if(!done){
							i = 0.0
							while(i < n){
								arg = residuals[Int(i)]/(6.0*medianResidual)
								if(arg >= 1.0){
									robustnessWeights[Int(i)] = 0.0
								}else{
									w = 1.0 - arg*arg
									robustnessWeights[Int(i)] = w*w
								}
								i = i + 1.0
							}
						}
					}
					iter = iter + 1.0
				}

				resultXs.numberArray = res
				success = true
			}else{
				success = false
				errorMessage.stringx = characterArray("There must be at least two points.").ca
			}
		}
	}else{
		success = false
		errorMessage.stringx = characterArray("There must be equal number of points, and over zero.").ca
	}

	return success
}


func RearrangeArray(_ asx : inout [Double], _ indexes : inout [Double]) -> Void{
	var bs : [Double]
	var i : Double

	bs = Array(repeating:Double(), count: Int(Double(asx.count)))

	AssignNumberArray(&bs, &asx)

	i = 0.0
	while(i < Double(indexes.count)){
		asx[Int(i)] = bs[Int(indexes[Int(i)])]
		i = i + 1.0
	}

	delete(bs)
}


func AssignNumberArray(_ asx : inout [Double], _ bs : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < min(Double(asx.count), Double(bs.count))){
		asx[Int(i)] = bs[Int(i)]
		i = i + 1.0
	}
}


func FindNextNonZeroElement(_ array : inout [Double], _ offset : Double) -> Double{
	var offset = offset;
	var position : Double
	var done : Bool

	done = false
	position = offset + 1.0
	while(position < Double(array.count) && !done){
		if(array[Int(position)] != 0.0){
			done = true
		}
		position = position + 1.0
	}

	return position
}


func Tricube(_ x : Double) -> Double{
	var x = x;
	var ax, result : Double

	ax = abs(x)

	if(ax >= 1.0){
		result = 0.0
	}else{
		result = 1.0 - ax*ax*ax
		result = result*result*result
	}

	return result
}


func CropLineWithinBoundary(_ x1Ref : inout NumberReference, _ y1Ref : inout NumberReference, _ x2Ref : inout NumberReference, _ y2Ref : inout NumberReference, _ xMin : Double, _ xMax : Double, _ yMin : Double, _ yMax : Double) -> Bool{
	var xMin = xMin;
	var xMax = xMax;
	var yMin = yMin;
	var yMax = yMax;
	var x1, y1, x2, y2 : Double
	var success, p1In, p2In : Bool
	var dx, dy, f1, f2, f3, f4, f : Double

	x1 = x1Ref.numberValue
	y1 = y1Ref.numberValue
	x2 = x2Ref.numberValue
	y2 = y2Ref.numberValue

	p1In = x1 >= xMin && x1 <= xMax && y1 >= yMin && y1 <= yMax
	p2In = x2 >= xMin && x2 <= xMax && y2 >= yMin && y2 <= yMax

	if(p1In && p2In){
		success = true
	}else if(!p1In && p2In){
		dx = x1 - x2
		dy = y1 - y2

		if(dx != 0.0){
			f1 = (xMin - x2)/dx
			f2 = (xMax - x2)/dx
		}else{
			f1 = 1.0
			f2 = 1.0
		}
		if(dy != 0.0){
			f3 = (yMin - y2)/dy
			f4 = (yMax - y2)/dy
		}else{
			f3 = 1.0
			f4 = 1.0
		}

		if(f1 < 0.0){
			f1 = 1.0
		}
		if(f2 < 0.0){
			f2 = 1.0
		}
		if(f3 < 0.0){
			f3 = 1.0
		}
		if(f4 < 0.0){
			f4 = 1.0
		}

		f = min(f1, min(f2, min(f3, f4)))

		x1 = x2 + f*dx
		y1 = y2 + f*dy

		success = true
	}else if(p1In && !p2In){
		dx = x2 - x1
		dy = y2 - y1

		if(dx != 0.0){
			f1 = (xMin - x1)/dx
			f2 = (xMax - x1)/dx
		}else{
			f1 = 1.0
			f2 = 1.0
		}
		if(dy != 0.0){
			f3 = (yMin - y1)/dy
			f4 = (yMax - y1)/dy
		}else{
			f3 = 1.0
			f4 = 1.0
		}

		if(f1 < 0.0){
			f1 = 1.0
		}
		if(f2 < 0.0){
			f2 = 1.0
		}
		if(f3 < 0.0){
			f3 = 1.0
		}
		if(f4 < 0.0){
			f4 = 1.0
		}

		f = min(f1, min(f2, min(f3, f4)))

		x2 = x1 + f*dx
		y2 = y1 + f*dy

		success = true
	}else{
		success = false
	}

	x1Ref.numberValue = x1
	y1Ref.numberValue = y1
	x2Ref.numberValue = x2
	y2Ref.numberValue = y2

	return success
}


func IncrementFromCoordinates(_ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double) -> Double{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	return (x2 - x1)/(y2 - y1)
}


func InterceptFromCoordinates(_ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double) -> Double{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var a, b : Double

	a = IncrementFromCoordinates(x1, y1, x2, y2)
	b = y1 - a*x1

	return b
}


func Get8HighContrastColors() -> [RGBA]{
	var colors : [RGBA]
	colors = Array(repeating:RGBA(), count: Int(8))
	colors[Int(0)] = CreateRGBColor(3.0/256.0, 146.0/256.0, 206.0/256.0).ref
	colors[Int(1)] = CreateRGBColor(253.0/256.0, 83.0/256.0, 8.0/256.0).ref
	colors[Int(2)] = CreateRGBColor(102.0/256.0, 176.0/256.0, 50.0/256.0).ref
	colors[Int(3)] = CreateRGBColor(208.0/256.0, 234.0/256.0, 43.0/256.0).ref
	colors[Int(4)] = CreateRGBColor(167.0/256.0, 25.0/256.0, 75.0/256.0).ref
	colors[Int(5)] = CreateRGBColor(254.0/256.0, 254.0/256.0, 51.0/256.0).ref
	colors[Int(6)] = CreateRGBColor(134.0/256.0, 1.0/256.0, 175.0/256.0).ref
	colors[Int(7)] = CreateRGBColor(251.0/256.0, 153.0/256.0, 2.0/256.0).ref
	return colors
}


func DrawFilledRectangleWithBorder(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ w : Double, _ h : Double, _ borderColor : inout RGBA, _ fillColor : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var w = w;
	var h = h;
	if(h > 0.0 && w > 0.0){
		DrawFilledRectangle(&image, x, y, w, h, &fillColor)
		DrawRectangle1px(&image, x, y, w, h, &borderColor)
	}
}


func CreateRGBABitmapImageReference() -> RGBABitmapImageReferenceReferenceClass{
	var reference : RGBABitmapImageReference

	reference = RGBABitmapImageReference()
	reference.image = RGBABitmapImage()
	reference.image.x = Array(repeating:RGBABitmap(), count: Int(0))

	var returnReference = RGBABitmapImageReferenceReferenceClass()
	returnReference.ref = reference
	return returnReference
}


func RectanglesOverlap(_ r1 : inout Rectangle, _ r2 : inout Rectangle) -> Bool{
	var overlap : Bool

	overlap = false

	overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2)
	overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2)
	overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2)
	overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2)

	return overlap
}


func CreateRectangle(_ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double) -> RectangleReferenceClass{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var r : Rectangle
	r = Rectangle()
	r.x1 = x1
	r.y1 = y1
	r.x2 = x2
	r.y2 = y2
	var returnReference = RectangleReferenceClass()
	returnReference.ref = r
	return returnReference
}


func CopyRectangleValues(_ rd : inout Rectangle, _ rs : inout Rectangle) -> Void{
	rd.x1 = rs.x1
	rd.y1 = rs.y1
	rd.x2 = rs.x2
	rd.y2 = rs.y2
}


func DrawXLabelsForPriority(_ p : Double, _ xMin : Double, _ oy : Double, _ xMax : Double, _ xPixelMin : Double, _ xPixelMax : Double, _ nextRectangle : inout NumberReference, _ gridLabelColor : inout RGBA, _ canvas : inout RGBABitmapImage, _ xGridPositions : inout [Double], _ xLabels : inout StringArrayReference, _ xLabelPriorities : inout NumberArrayReference, _ occupied : inout [Rectangle], _ textOnBottom : Bool) -> Void{
	var p = p;
	var xMin = xMin;
	var oy = oy;
	var xMax = xMax;
	var xPixelMin = xPixelMin;
	var xPixelMax = xPixelMax;
	var textOnBottom = textOnBottom;
	var overlap, currentOverlaps : Bool
	var i, j, x, px, padding : Double
	var text : [Character]
	var r : Rectangle

	r = Rectangle()
	padding = 10.0

	overlap = false
	i = 0.0
	while(i < Double(xLabels.stringArray.count)){
		if(xLabelPriorities.numberArray[Int(i)] == p){

			x = xGridPositions[Int(i)]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
			text = xLabels.stringArray[Int(i)].stringx

			r.x1 = floor(px - GetTextWidth(&text)/2.0)
			if(textOnBottom){
				r.y1 = floor(oy + 5.0)
			}else{
				r.y1 = floor(oy - 20.0)
			}
			r.x2 = r.x1 + GetTextWidth(&text)
			r.y2 = r.y1 + GetTextHeight(&text)

			/* Add padding*/
			r.x1 = r.x1 - padding
			r.y1 = r.y1 - padding
			r.x2 = r.x2 + padding
			r.y2 = r.y2 + padding

			currentOverlaps = false

			j = 0.0
			while(j < nextRectangle.numberValue){
				currentOverlaps = currentOverlaps || RectanglesOverlap(&r, &occupied[Int(j)])
				j = j + 1.0
			}

			if(!currentOverlaps && p == 1.0){
				DrawText(&canvas, r.x1 + padding, r.y1 + padding, &text, &gridLabelColor)

				CopyRectangleValues(&occupied[Int(nextRectangle.numberValue)], &r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			}

			overlap = overlap || currentOverlaps
		}
		i = i + 1.0
	}
	if(!overlap && p != 1.0){
		i = 0.0
		while(i < Double(xGridPositions.count)){
			x = xGridPositions[Int(i)]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

			if(xLabelPriorities.numberArray[Int(i)] == p){
				text = xLabels.stringArray[Int(i)].stringx

				r.x1 = floor(px - GetTextWidth(&text)/2.0)
				if(textOnBottom){
					r.y1 = floor(oy + 5.0)
				}else{
					r.y1 = floor(oy - 20.0)
				}
				r.x2 = r.x1 + GetTextWidth(&text)
				r.y2 = r.y1 + GetTextHeight(&text)

				DrawText(&canvas, r.x1, r.y1, &text, &gridLabelColor)

				CopyRectangleValues(&occupied[Int(nextRectangle.numberValue)], &r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			}
			i = i + 1.0
		}
	}
}


func DrawYLabelsForPriority(_ p : Double, _ yMin : Double, _ ox : Double, _ yMax : Double, _ yPixelMin : Double, _ yPixelMax : Double, _ nextRectangle : inout NumberReference, _ gridLabelColor : inout RGBA, _ canvas : inout RGBABitmapImage, _ yGridPositions : inout [Double], _ yLabels : inout StringArrayReference, _ yLabelPriorities : inout NumberArrayReference, _ occupied : inout [Rectangle], _ textOnLeft : Bool) -> Void{
	var p = p;
	var yMin = yMin;
	var ox = ox;
	var yMax = yMax;
	var yPixelMin = yPixelMin;
	var yPixelMax = yPixelMax;
	var textOnLeft = textOnLeft;
	var overlap, currentOverlaps : Bool
	var i, j, y, py, padding : Double
	var text : [Character]
	var r : Rectangle

	r = Rectangle()
	padding = 10.0

	overlap = false
	i = 0.0
	while(i < Double(yLabels.stringArray.count)){
		if(yLabelPriorities.numberArray[Int(i)] == p){

			y = yGridPositions[Int(i)]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
			text = yLabels.stringArray[Int(i)].stringx

			if(textOnLeft){
				r.x1 = floor(ox - GetTextWidth(&text) - 10.0)
			}else{
				r.x1 = floor(ox + 10.0)
			}
			r.y1 = floor(py - 6.0)
			r.x2 = r.x1 + GetTextWidth(&text)
			r.y2 = r.y1 + GetTextHeight(&text)

			/* Add padding*/
			r.x1 = r.x1 - padding
			r.y1 = r.y1 - padding
			r.x2 = r.x2 + padding
			r.y2 = r.y2 + padding

			currentOverlaps = false

			j = 0.0
			while(j < nextRectangle.numberValue){
				currentOverlaps = currentOverlaps || RectanglesOverlap(&r, &occupied[Int(j)])
				j = j + 1.0
			}

			/* Draw labels with priority 1 if they do not overlap anything else.*/
			if(!currentOverlaps && p == 1.0){
				DrawText(&canvas, r.x1 + padding, r.y1 + padding, &text, &gridLabelColor)

				CopyRectangleValues(&occupied[Int(nextRectangle.numberValue)], &r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			}

			overlap = overlap || currentOverlaps
		}
		i = i + 1.0
	}
	if(!overlap && p != 1.0){
		i = 0.0
		while(i < Double(yGridPositions.count)){
			y = yGridPositions[Int(i)]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

			if(yLabelPriorities.numberArray[Int(i)] == p){
				text = yLabels.stringArray[Int(i)].stringx

				if(textOnLeft){
					r.x1 = floor(ox - GetTextWidth(&text) - 10.0)
				}else{
					r.x1 = floor(ox + 10.0)
				}
				r.y1 = floor(py - 6.0)
				r.x2 = r.x1 + GetTextWidth(&text)
				r.y2 = r.y1 + GetTextHeight(&text)

				DrawText(&canvas, r.x1, r.y1, &text, &gridLabelColor)

				CopyRectangleValues(&occupied[Int(nextRectangle.numberValue)], &r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			}
			i = i + 1.0
		}
	}
}


func ComputeGridLinePositions(_ cMin : Double, _ cMax : Double, _ labels : inout StringArrayReference, _ priorities : inout NumberArrayReference) -> [Double]{
	var cMin = cMin;
	var cMax = cMax;
	var positions : [Double]
	var cLength, p, pMin, pMax, pInterval, pNum, i, num, rem, priority, mode : Double

	cLength = cMax - cMin

	p = floor(log10(cLength))
	pInterval = pow(10.0, p)
	/* gives 10-1 lines for 100-10 diff*/
	pMin = ceil(cMin/pInterval)*pInterval
	pMax = floor(cMax/pInterval)*pInterval
	pNum = Roundx((pMax - pMin)/pInterval + 1.0)

	mode = 1.0

	if(pNum <= 3.0){
		p = floor(log10(cLength) - 1.0)
		/* gives 100-10 lines for 100-10 diff*/
		pInterval = pow(10.0, p)
		pMin = ceil(cMin/pInterval)*pInterval
		pMax = floor(cMax/pInterval)*pInterval
		pNum = Roundx((pMax - pMin)/pInterval + 1.0)

		mode = 4.0
	}else if(pNum <= 6.0){
		p = floor(log10(cLength))
		pInterval = pow(10.0, p)/4.0
		/* gives 40-5 lines for 100-10 diff*/
		pMin = ceil(cMin/pInterval)*pInterval
		pMax = floor(cMax/pInterval)*pInterval
		pNum = Roundx((pMax - pMin)/pInterval + 1.0)

		mode = 3.0
	}else if(pNum <= 10.0){
		p = floor(log10(cLength))
		pInterval = pow(10.0, p)/2.0
		/* gives 20-3 lines for 100-10 diff*/
		pMin = ceil(cMin/pInterval)*pInterval
		pMax = floor(cMax/pInterval)*pInterval
		pNum = Roundx((pMax - pMin)/pInterval + 1.0)

		mode = 2.0
	}

	positions = Array(repeating:Double(), count: Int(pNum))
	labels.stringArray = Array(repeating:StringReference(), count: Int(pNum))
	priorities.numberArray = Array(repeating:Double(), count: Int(pNum))

	i = 0.0
	while(i < pNum){
		num = pMin + pInterval*i
		positions[Int(i)] = num

		/* Always print priority 1 labels. Only draw priority 2 if they can all be drawn. Then, only draw priority 3 if they can all be drawn.*/
		priority = 1.0

		/* Prioritize x.25, x.5 and x.75 lower.*/
		if(mode == 2.0 || mode == 3.0){
			rem = abs(round(num/pow(10.0, p - 2.0))).truncatingRemainder(dividingBy:100.0)

			priority = 1.0
			if(rem == 50.0){
				priority = 2.0
			}else if(rem == 25.0 || rem == 75.0){
				priority = 3.0
			}
		}

		/* Prioritize x.1-x.4 and x.6-x.9 lower*/
		if(mode == 4.0){
			rem = abs(Roundx(num/pow(10.0, p))).truncatingRemainder(dividingBy:10.0)

			priority = 1.0
			if(rem == 1.0 || rem == 2.0 || rem == 3.0 || rem == 4.0 || rem == 6.0 || rem == 7.0 || rem == 8.0 || rem == 9.0){
				priority = 2.0
			}
		}

		/* 0 has lowest priority.*/
		if(EpsilonCompare(num, 0.0, pow(10.0, p - 5.0))){
			priority = 3.0
		}

		priorities.numberArray[Int(i)] = priority

		/* The label itself.*/
		labels.stringArray[Int(i)] = StringReference()
		if(p < 0.0){
			if(mode == 2.0 || mode == 3.0){
				num = RoundToDigits(num, -(p - 1.0))
			}else{
				num = RoundToDigits(num, -p)
			}
		}
		labels.stringArray[Int(i)].stringx = CreateStringDecimalFromNumber(num)
		i = i + 1.0
	}

	return positions
}


func MapYCoordinate(_ y : Double, _ yMin : Double, _ yMax : Double, _ yPixelMin : Double, _ yPixelMax : Double) -> Double{
	var y = y;
	var yMin = yMin;
	var yMax = yMax;
	var yPixelMin = yPixelMin;
	var yPixelMax = yPixelMax;
	var yLength, yPixelLength : Double

	yLength = yMax - yMin
	yPixelLength = yPixelMax - yPixelMin

	y = y - yMin
	y = y*yPixelLength/yLength
	y = yPixelLength - y
	y = y + yPixelMin
	return y
}


func MapXCoordinate(_ x : Double, _ xMin : Double, _ xMax : Double, _ xPixelMin : Double, _ xPixelMax : Double) -> Double{
	var x = x;
	var xMin = xMin;
	var xMax = xMax;
	var xPixelMin = xPixelMin;
	var xPixelMax = xPixelMax;
	var xLength, xPixelLength : Double

	xLength = xMax - xMin
	xPixelLength = xPixelMax - xPixelMin

	x = x - xMin
	x = x*xPixelLength/xLength
	x = x + xPixelMin
	return x
}


func MapXCoordinateAutoSettings(_ x : Double, _ image : inout RGBABitmapImage, _ xs : inout [Double]) -> Double{
	var x = x;
	return MapXCoordinate(x, GetMinimum(&xs), GetMaximum(&xs), GetDefaultPaddingPercentage()*ImageWidth(&image), (1.0 - GetDefaultPaddingPercentage())*ImageWidth(&image))
}


func MapYCoordinateAutoSettings(_ y : Double, _ image : inout RGBABitmapImage, _ ys : inout [Double]) -> Double{
	var y = y;
	return MapYCoordinate(y, GetMinimum(&ys), GetMaximum(&ys), GetDefaultPaddingPercentage()*ImageHeight(&image), (1.0 - GetDefaultPaddingPercentage())*ImageHeight(&image))
}


func MapXCoordinateBasedOnSettings(_ x : Double, _ settings : inout ScatterPlotSettings) -> Double{
	var x = x;
	var xMin, xMax, xPadding, xPixelMin, xPixelMax : Double
	var boundaries : Rectangle

	boundaries = Rectangle()
	ComputeBoundariesBasedOnSettings(&settings, &boundaries)
	xMin = boundaries.x1
	xMax = boundaries.x2

	if(settings.autoPadding){
		xPadding = floor(GetDefaultPaddingPercentage()*settings.width)
	}else{
		xPadding = settings.xPadding
	}

	xPixelMin = xPadding
	xPixelMax = settings.width - xPadding

	return MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
}


func MapYCoordinateBasedOnSettings(_ y : Double, _ settings : inout ScatterPlotSettings) -> Double{
	var y = y;
	var yMin, yMax, yPadding, yPixelMin, yPixelMax : Double
	var boundaries : Rectangle

	boundaries = Rectangle()
	ComputeBoundariesBasedOnSettings(&settings, &boundaries)
	yMin = boundaries.y1
	yMax = boundaries.y2

	if(settings.autoPadding){
		yPadding = floor(GetDefaultPaddingPercentage()*settings.height)
	}else{
		yPadding = settings.yPadding
	}

	yPixelMin = yPadding
	yPixelMax = settings.height - yPadding

	return MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
}


func GetDefaultPaddingPercentage() -> Double{
	return 0.10
}


func DrawText(_ canvas : inout RGBABitmapImage, _ x : Double, _ y : Double, _ text : inout [Character], _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var i, charWidth, spacing : Double

	charWidth = 8.0
	spacing = 2.0

	i = 0.0
	while(i < Double(text.count)){
		DrawAsciiCharacter(&canvas, x + i*(charWidth + spacing), y, text[Int(i)], &color)
		i = i + 1.0
	}
}


func DrawTextUpwards(_ canvas : inout RGBABitmapImage, _ x : Double, _ y : Double, _ text : inout [Character], _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var buffer, rotated : RGBABitmapImage

	buffer = CreateImage(GetTextWidth(&text), GetTextHeight(&text), &GetTransparent().ref).ref
	DrawText(&buffer, 0.0, 0.0, &text, &color)
	rotated = RotateAntiClockwise90Degrees(&buffer).ref
	DrawImageOnImage(&canvas, &rotated, x, y)
	DeleteImage(&buffer)
	DeleteImage(&rotated)
}


func GetDefaultScatterPlotSettings() -> ScatterPlotSettingsReferenceClass{
	var settings : ScatterPlotSettings

	settings = ScatterPlotSettings()

	settings.autoBoundaries = true
	settings.xMax = 0.0
	settings.xMin = 0.0
	settings.yMax = 0.0
	settings.yMin = 0.0
	settings.autoPadding = true
	settings.xPadding = 0.0
	settings.yPadding = 0.0
	settings.title = characterArray("").ca
	settings.xLabel = characterArray("").ca
	settings.yLabel = characterArray("").ca
	settings.scatterPlotSeries = Array(repeating:ScatterPlotSeries(), count: Int(0))
	settings.showGrid = true
	settings.gridColor = GetGray(0.1).ref
	settings.xAxisAuto = true
	settings.xAxisTop = false
	settings.xAxisBottom = false
	settings.yAxisAuto = true
	settings.yAxisLeft = false
	settings.yAxisRight = false

	var returnReference = ScatterPlotSettingsReferenceClass()
	returnReference.ref = settings
	return returnReference
}


func GetDefaultScatterPlotSeriesSettings() -> ScatterPlotSeriesReferenceClass{
	var series : ScatterPlotSeries

	series = ScatterPlotSeries()

	series.linearInterpolation = true
	series.pointType = characterArray("pixels").ca
	series.lineType = characterArray("solid").ca
	series.lineThickness = 1.0
	series.xs = Array(repeating:Double(), count: Int(0))
	series.ys = Array(repeating:Double(), count: Int(0))
	series.color = GetBlack().ref

	var returnReference = ScatterPlotSeriesReferenceClass()
	returnReference.ref = series
	return returnReference
}


func DrawScatterPlot(_ canvasReference : inout RGBABitmapImageReference, _ width : Double, _ height : Double, _ xs : inout [Double], _ ys : inout [Double], _ errorMessage : inout StringReference) -> Bool{
	var width = width;
	var height = height;
	var settings : ScatterPlotSettings
	var success : Bool

	settings = GetDefaultScatterPlotSettings().ref

	settings.width = width
	settings.height = height
	settings.scatterPlotSeries = Array(repeating:ScatterPlotSeries(), count: Int(1))
	settings.scatterPlotSeries[Int(0)] = GetDefaultScatterPlotSeriesSettings().ref
	delete(settings.scatterPlotSeries[Int(0)].xs)
	settings.scatterPlotSeries[Int(0)].xs = xs
	delete(settings.scatterPlotSeries[Int(0)].ys)
	settings.scatterPlotSeries[Int(0)].ys = ys

	success = DrawScatterPlotFromSettings(&canvasReference, &settings, &errorMessage)

	return success
}


func DrawScatterPlotFromSettings(_ canvasReference : inout RGBABitmapImageReference, _ settings : inout ScatterPlotSettings, _ errorMessage : inout StringReference) -> Bool{
	var xMin, xMax, yMin, yMax, xLength, yLength, i, x, y, xPrev, yPrev, px, py, pxPrev, pyPrev, originX, originY, p, l, plot : Double
	var boundaries : Rectangle
	var xPadding, yPadding, originXPixels, originYPixels : Double
	var xPixelMin, yPixelMin, xPixelMax, yPixelMax, xLengthPixels, yLengthPixels, axisLabelPadding : Double
	var nextRectangle, x1Ref, y1Ref, x2Ref, y2Ref, patternOffset : NumberReference
	var prevSet, success : Bool
	var gridLabelColor : RGBA
	var canvas : RGBABitmapImage
	var xs, ys : [Double]
	var linearInterpolation : Bool
	var sp : ScatterPlotSeries
	var xGridPositions, yGridPositions : [Double]
	var xLabels, yLabels : StringArrayReference
	var xLabelPriorities, yLabelPriorities : NumberArrayReference
	var occupied : [Rectangle]
	var linePattern : [Bool]
	var originXInside, originYInside, textOnLeft, textOnBottom : Bool
	var originTextX, originTextY, originTextXPixels, originTextYPixels, side, yaxis : Double

	canvas = CreateImage(settings.width, settings.height, &GetWhite().ref).ref
	patternOffset = CreateNumberReference(0.0).ref

	success = ScatterPlotFromSettingsValid(&settings, &errorMessage)

	if(success){

		boundaries = Rectangle()
		ComputeBoundariesBasedOnSettings(&settings, &boundaries)
		xMin = boundaries.x1
		yMin = boundaries.y1
		xMax = boundaries.x2
		yMax = boundaries.y2

		/* If zero, set to defaults.*/
		if(xMin - xMax == 0.0){
			xMin = 0.0
			xMax = 10.0
		}

		if(yMin - yMax == 0.0){
			yMin = 0.0
			yMax = 10.0
		}

		xLength = xMax - xMin
		yLength = yMax - yMin

		if(settings.autoPadding){
			xPadding = floor(GetDefaultPaddingPercentage()*settings.width)
			yPadding = floor(GetDefaultPaddingPercentage()*settings.height)
		}else{
			xPadding = settings.xPadding
			yPadding = settings.yPadding
		}

		/* Draw title*/
		DrawText(&canvas, floor(settings.width/2.0 - GetTextWidth(&settings.title)/2.0), floor(yPadding/3.0), &settings.title, &GetBlack().ref)

		/* Draw grid*/
		xPixelMin = xPadding
		yPixelMin = yPadding
		xPixelMax = settings.width - xPadding
		yPixelMax = settings.height - yPadding
		xLengthPixels = xPixelMax - xPixelMin
		yLengthPixels = yPixelMax - yPixelMin
		DrawRectangle1px(&canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, &settings.gridColor)

		gridLabelColor = GetGray(0.5).ref

		xLabels = StringArrayReference()
		xLabelPriorities = NumberArrayReference()
		yLabels = StringArrayReference()
		yLabelPriorities = NumberArrayReference()
		xGridPositions = ComputeGridLinePositions(xMin, xMax, &xLabels, &xLabelPriorities)
		yGridPositions = ComputeGridLinePositions(yMin, yMax, &yLabels, &yLabelPriorities)

		if(settings.showGrid){
			/* X-grid*/
			i = 0.0
			while(i < Double(xGridPositions.count)){
				x = xGridPositions[Int(i)]
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
				DrawLine1px(&canvas, px, yPixelMin, px, yPixelMax, &settings.gridColor)
				i = i + 1.0
			}

			/* Y-grid*/
			i = 0.0
			while(i < Double(yGridPositions.count)){
				y = yGridPositions[Int(i)]
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				DrawLine1px(&canvas, xPixelMin, py, xPixelMax, py, &settings.gridColor)
				i = i + 1.0
			}
		}

		/* Compute origin information.*/
		originYInside = yMin < 0.0 && yMax > 0.0
		originY = 0.0
		if(settings.xAxisAuto){
			if(originYInside){
				originY = 0.0
			}else{
				originY = yMin
			}
		}else{
if(settings.xAxisTop){
				originY = yMax
			}
			if(settings.xAxisBottom){
				originY = yMin
			}
		}
		originYPixels = MapYCoordinate(originY, yMin, yMax, yPixelMin, yPixelMax)

		originXInside = xMin < 0.0 && xMax > 0.0
		originX = 0.0
		if(settings.yAxisAuto){
			if(originXInside){
				originX = 0.0
			}else{
				originX = xMin
			}
		}else{
if(settings.yAxisLeft){
				originX = xMin
			}
			if(settings.yAxisRight){
				originX = xMax
			}
		}
		originXPixels = MapXCoordinate(originX, xMin, xMax, xPixelMin, xPixelMax)

		if(originYInside){
			originTextY = 0.0
		}else{
			originTextY = yMin + yLength/2.0
		}
		originTextYPixels = MapYCoordinate(originTextY, yMin, yMax, yPixelMin, yPixelMax)

		if(originXInside){
			originTextX = 0.0
		}else{
			originTextX = xMin + xLength/2.0
		}
		originTextXPixels = MapXCoordinate(originTextX, xMin, xMax, xPixelMin, xPixelMax)

		/* Labels*/
		occupied = Array(repeating:Rectangle(), count: Int(Double(xLabels.stringArray.count) + Double(yLabels.stringArray.count)))
		i = 0.0
		while(i < Double(occupied.count)){
			occupied[Int(i)] = CreateRectangle(0.0, 0.0, 0.0, 0.0).ref
			i = i + 1.0
		}
		nextRectangle = CreateNumberReference(0.0).ref

		/* x labels*/
		i = 1.0
		while(i <= 5.0){
			textOnBottom = true
			if(!settings.xAxisAuto && settings.xAxisTop){
				textOnBottom = false
			}
			DrawXLabelsForPriority(i, xMin, originYPixels, xMax, xPixelMin, xPixelMax, &nextRectangle, &gridLabelColor, &canvas, &xGridPositions, &xLabels, &xLabelPriorities, &occupied, textOnBottom)
			i = i + 1.0
		}

		/* y labels*/
		i = 1.0
		while(i <= 5.0){
			textOnLeft = true
			if(!settings.yAxisAuto && settings.yAxisRight){
				textOnLeft = false
			}
			DrawYLabelsForPriority(i, yMin, originXPixels, yMax, yPixelMin, yPixelMax, &nextRectangle, &gridLabelColor, &canvas, &yGridPositions, &yLabels, &yLabelPriorities, &occupied, textOnLeft)
			i = i + 1.0
		}

		/* Draw origin line axis titles.*/
		axisLabelPadding = 20.0

		/* x origin line*/
		if(originYInside){
			DrawLine1px(&canvas, Roundx(xPixelMin), Roundx(originYPixels), Roundx(xPixelMax), Roundx(originYPixels), &GetBlack().ref)
		}

		/* y origin line*/
		if(originXInside){
			DrawLine1px(&canvas, Roundx(originXPixels), Roundx(yPixelMin), Roundx(originXPixels), Roundx(yPixelMax), &GetBlack().ref)
		}

		/* Draw origin axis titles.*/
		DrawTextUpwards(&canvas, 10.0, floor(originTextYPixels - GetTextWidth(&settings.yLabel)/2.0), &settings.yLabel, &GetBlack().ref)
		DrawText(&canvas, floor(originTextXPixels - GetTextWidth(&settings.xLabel)/2.0), yPixelMax + axisLabelPadding, &settings.xLabel, &GetBlack().ref)

		/* X-grid-markers*/
		i = 0.0
		while(i < Double(xGridPositions.count)){
			x = xGridPositions[Int(i)]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
			p = xLabelPriorities.numberArray[Int(i)]
			l = 1.0
			if(p == 1.0){
				l = 8.0
			}else if(p == 2.0){
				l = 3.0
			}
			side = -1.0
			if(!settings.xAxisAuto && settings.xAxisTop){
				side = 1.0
			}
			DrawLine1px(&canvas, px, originYPixels, px, originYPixels + side*l, &GetBlack().ref)
			i = i + 1.0
		}

		/* Y-grid-markers*/
		i = 0.0
		while(i < Double(yGridPositions.count)){
			y = yGridPositions[Int(i)]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
			p = yLabelPriorities.numberArray[Int(i)]
			l = 1.0
			if(p == 1.0){
				l = 8.0
			}else if(p == 2.0){
				l = 3.0
			}
			side = 1.0
			if(!settings.yAxisAuto && settings.yAxisRight){
				side = -1.0
			}
			DrawLine1px(&canvas, originXPixels, py, originXPixels + side*l, py, &GetBlack().ref)
			i = i + 1.0
		}

		/* Draw points*/
		plot = 0.0
		while(plot < Double(settings.scatterPlotSeries.count)){
			sp = settings.scatterPlotSeries[Int(plot)]

			xs = sp.xs
			ys = sp.ys
			linearInterpolation = sp.linearInterpolation

			x1Ref = NumberReference()
			y1Ref = NumberReference()
			x2Ref = NumberReference()
			y2Ref = NumberReference()
			if(linearInterpolation){
				prevSet = false
				xPrev = 0.0
				yPrev = 0.0
				i = 0.0
				while(i < Double(xs.count)){
					x = xs[Int(i)]
					y = ys[Int(i)]

					if(prevSet){
						x1Ref.numberValue = xPrev
						y1Ref.numberValue = yPrev
						x2Ref.numberValue = x
						y2Ref.numberValue = y

						success = CropLineWithinBoundary(&x1Ref, &y1Ref, &x2Ref, &y2Ref, xMin, xMax, yMin, yMax)

						if(success){
							pxPrev = floor(MapXCoordinate(x1Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
							pyPrev = floor(MapYCoordinate(y1Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))
							px = floor(MapXCoordinate(x2Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
							py = floor(MapYCoordinate(y2Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))

							if(arraysStringsEqual(&sp.lineType, &characterArray("solid").ca) && sp.lineThickness == 1.0){
								DrawLine1px(&canvas, pxPrev, pyPrev, px, py, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("solid").ca)){
								DrawLine(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("dashed").ca)){
								linePattern = GetLinePattern1()
								DrawLineBresenhamsAlgorithmThickPatterned(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &linePattern, &patternOffset, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("dotted").ca)){
								linePattern = GetLinePattern2()
								DrawLineBresenhamsAlgorithmThickPatterned(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &linePattern, &patternOffset, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("dotdash").ca)){
								linePattern = GetLinePattern3()
								DrawLineBresenhamsAlgorithmThickPatterned(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &linePattern, &patternOffset, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("longdash").ca)){
								linePattern = GetLinePattern4()
								DrawLineBresenhamsAlgorithmThickPatterned(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &linePattern, &patternOffset, &sp.color)
							}else if(arraysStringsEqual(&sp.lineType, &characterArray("twodash").ca)){
								linePattern = GetLinePattern5()
								DrawLineBresenhamsAlgorithmThickPatterned(&canvas, pxPrev, pyPrev, px, py, sp.lineThickness, &linePattern, &patternOffset, &sp.color)
							}
						}
					}

					prevSet = true
					xPrev = x
					yPrev = y
					i = i + 1.0
				}
			}else{
				i = 0.0
				while(i < Double(xs.count)){
					x = xs[Int(i)]
					y = ys[Int(i)]

					if(x > xMin && x < xMax && y > yMin && y < yMax){

						x = floor(MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax))
						y = floor(MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax))

						if(arraysStringsEqual(&sp.pointType, &characterArray("crosses").ca)){
							DrawPixel(&canvas, x, y, &sp.color)
							DrawPixel(&canvas, x + 1.0, y, &sp.color)
							DrawPixel(&canvas, x + 2.0, y, &sp.color)
							DrawPixel(&canvas, x - 1.0, y, &sp.color)
							DrawPixel(&canvas, x - 2.0, y, &sp.color)
							DrawPixel(&canvas, x, y + 1.0, &sp.color)
							DrawPixel(&canvas, x, y + 2.0, &sp.color)
							DrawPixel(&canvas, x, y - 1.0, &sp.color)
							DrawPixel(&canvas, x, y - 2.0, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("circles").ca)){
							DrawCircle(&canvas, x, y, 3.0, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("dots").ca)){
							DrawFilledCircle(&canvas, x, y, 3.0, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("triangles").ca)){
							DrawTriangle(&canvas, x, y, 3.0, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("filled triangles").ca)){
							DrawFilledTriangle(&canvas, x, y, 3.0, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("pixels").ca)){
							DrawPixel(&canvas, x, y, &sp.color)
						}else if(arraysStringsEqual(&sp.pointType, &characterArray("dotlinetoxaxis").ca)){
							DrawFilledCircle(&canvas, x, y, 3.0, &sp.color)
							yaxis = floor(MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax))
							yaxis = min(max(yaxis, yPixelMin), yPixelMax)
							DrawLine(&canvas, x, y, x, yaxis, sp.lineThickness, &sp.color)
						}
					}
					i = i + 1.0
				}
			}
			plot = plot + 1.0
		}

		canvasReference.image = canvas
	}

	return success
}


func ComputeBoundariesBasedOnSettings(_ settings : inout ScatterPlotSettings, _ boundaries : inout Rectangle) -> Void{
	var sp : ScatterPlotSeries
	var plot, xMin, xMax, yMin, yMax : Double

	if(Double(settings.scatterPlotSeries.count) >= 1.0){
		xMin = GetMinimum(&settings.scatterPlotSeries[Int(0)].xs)*1.05
		xMax = GetMaximum(&settings.scatterPlotSeries[Int(0)].xs)*1.05
		yMin = GetMinimum(&settings.scatterPlotSeries[Int(0)].ys)*1.05
		yMax = GetMaximum(&settings.scatterPlotSeries[Int(0)].ys)*1.05
	}else{
		xMin = -10.0
		xMax = 10.0
		yMin = -10.0
		yMax = 10.0
	}

	if(!settings.autoBoundaries){
		xMin = settings.xMin
		xMax = settings.xMax
		yMin = settings.yMin
		yMax = settings.yMax
	}else{
		plot = 1.0
		while(plot < Double(settings.scatterPlotSeries.count)){
			sp = settings.scatterPlotSeries[Int(plot)]

			xMin = min(xMin, GetMinimum(&sp.xs))
			xMax = max(xMax, GetMaximum(&sp.xs))
			yMin = min(yMin, GetMinimum(&sp.ys))
			yMax = max(yMax, GetMaximum(&sp.ys))
			plot = plot + 1.0
		}
	}

	boundaries.x1 = xMin
	boundaries.y1 = yMin
	boundaries.x2 = xMax
	boundaries.y2 = yMax
}


func ScatterPlotFromSettingsValid(_ settings : inout ScatterPlotSettings, _ errorMessage : inout StringReference) -> Bool{
	var success, found : Bool
	var series : ScatterPlotSeries
	var i : Double

	success = true

	/* Check axis placement.*/
	if(!settings.xAxisAuto){
		if(settings.xAxisTop && settings.xAxisBottom){
			success = false
			errorMessage.stringx = characterArray("x-axis not automatic and configured to be both on top and on bottom.").ca
		}
		if(!settings.xAxisTop && !settings.xAxisBottom){
			success = false
			errorMessage.stringx = characterArray("x-axis not automatic and configured to be neither on top nor on bottom.").ca
		}
	}

	if(!settings.yAxisAuto){
		if(settings.yAxisLeft && settings.yAxisRight){
			success = false
			errorMessage.stringx = characterArray("y-axis not automatic and configured to be both on top and on bottom.").ca
		}
		if(!settings.yAxisLeft && !settings.yAxisRight){
			success = false
			errorMessage.stringx = characterArray("y-axis not automatic and configured to be neither on top nor on bottom.").ca
		}
	}

	/* Check series lengths.*/
	i = 0.0
	while(i < Double(settings.scatterPlotSeries.count)){
		series = settings.scatterPlotSeries[Int(i)]
		if(Double(series.xs.count) != Double(series.ys.count)){
			success = false
			errorMessage.stringx = characterArray("x and y series must be of the same length.").ca
		}
		if(Double(series.xs.count) == 0.0){
			success = false
			errorMessage.stringx = characterArray("There must be data in the series to be plotted.").ca
		}
		if(series.linearInterpolation && Double(series.xs.count) == 1.0){
			success = false
			errorMessage.stringx = characterArray("Linear interpolation requires at least two data points to be plotted.").ca
		}
		i = i + 1.0
	}

	/* Check bounds.*/
	if(!settings.autoBoundaries){
		if(settings.xMin >= settings.xMax){
			success = false
			errorMessage.stringx = characterArray("x min is higher than or equal to x max.").ca
		}
		if(settings.yMin >= settings.yMax){
			success = false
			errorMessage.stringx = characterArray("y min is higher than or equal to y max.").ca
		}
	}

	/* Check padding.*/
	if(!settings.autoPadding){
		if(2.0*settings.xPadding >= settings.width){
			success = false
			errorMessage.stringx = characterArray("The x padding is more then the width.").ca
		}
		if(2.0*settings.yPadding >= settings.height){
			success = false
			errorMessage.stringx = characterArray("The y padding is more then the height.").ca
		}
	}

	/* Check width and height.*/
	if(settings.width < 0.0){
		success = false
		errorMessage.stringx = characterArray("The width is less than 0.").ca
	}
	if(settings.height < 0.0){
		success = false
		errorMessage.stringx = characterArray("The height is less than 0.").ca
	}

	/* Check point types.*/
	i = 0.0
	while(i < Double(settings.scatterPlotSeries.count)){
		series = settings.scatterPlotSeries[Int(i)]

		if(series.lineThickness < 0.0){
			success = false
			errorMessage.stringx = characterArray("The line thickness is less than 0.").ca
		}

		if(!series.linearInterpolation){
			/* Point type.*/
			found = false
			if(arraysStringsEqual(&series.pointType, &characterArray("crosses").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("circles").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("dots").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("triangles").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("filled triangles").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("pixels").ca)){
				found = true
			}else if(arraysStringsEqual(&series.pointType, &characterArray("dotlinetoxaxis").ca)){
				found = true
			}
			if(!found){
				success = false
				errorMessage.stringx = characterArray("The point type is unknown.").ca
			}
		}else{
			/* Line type.*/
			found = false
			if(arraysStringsEqual(&series.lineType, &characterArray("solid").ca)){
				found = true
			}else if(arraysStringsEqual(&series.lineType, &characterArray("dashed").ca)){
				found = true
			}else if(arraysStringsEqual(&series.lineType, &characterArray("dotted").ca)){
				found = true
			}else if(arraysStringsEqual(&series.lineType, &characterArray("dotdash").ca)){
				found = true
			}else if(arraysStringsEqual(&series.lineType, &characterArray("longdash").ca)){
				found = true
			}else if(arraysStringsEqual(&series.lineType, &characterArray("twodash").ca)){
				found = true
			}

			if(!found){
				success = false
				errorMessage.stringx = characterArray("The line type is unknown.").ca
			}
		}
		i = i + 1.0
	}

	return success
}


func GetDefaultBarPlotSettings() -> BarPlotSettingsReferenceClass{
	var settings : BarPlotSettings

	settings = BarPlotSettings()

	settings.width = 800.0
	settings.height = 600.0
	settings.autoBoundaries = true
	settings.yMax = 0.0
	settings.yMin = 0.0
	settings.autoPadding = true
	settings.xPadding = 0.0
	settings.yPadding = 0.0
	settings.title = characterArray("").ca
	settings.yLabel = characterArray("").ca
	settings.barPlotSeries = Array(repeating:BarPlotSeries(), count: Int(0))
	settings.showGrid = true
	settings.gridColor = GetGray(0.1).ref
	settings.autoColor = true
	settings.grayscaleAutoColor = false
	settings.autoSpacing = true
	settings.groupSeparation = 0.0
	settings.barSeparation = 0.0
	settings.autoLabels = true
	settings.xLabels = Array(repeating:StringReference(), count: Int(0))
	/*settings.autoLabels = false;
        settings.xLabels = new StringReference [5];
        settings.xLabels[0] = CreateStringReference("may 20".toCharArray());
        settings.xLabels[1] = CreateStringReference("jun 20".toCharArray());
        settings.xLabels[2] = CreateStringReference("jul 20".toCharArray());
        settings.xLabels[3] = CreateStringReference("aug 20".toCharArray());
        settings.xLabels[4] = CreateStringReference("sep 20".toCharArray());*/
	settings.barBorder = false

	var returnReference = BarPlotSettingsReferenceClass()
	returnReference.ref = settings
	return returnReference
}


func GetDefaultBarPlotSeriesSettings() -> BarPlotSeriesReferenceClass{
	var series : BarPlotSeries

	series = BarPlotSeries()

	series.ys = Array(repeating:Double(), count: Int(0))
	series.color = GetBlack().ref

	var returnReference = BarPlotSeriesReferenceClass()
	returnReference.ref = series
	return returnReference
}


func DrawBarPlotNoErrorCheck(_ width : Double, _ height : Double, _ ys : inout [Double]) -> RGBABitmapImageReferenceClass{
	var width = width;
	var height = height;
	var errorMessage : StringReference
	var success : Bool
	var canvasReference : RGBABitmapImageReference

	errorMessage = StringReference()
	canvasReference = CreateRGBABitmapImageReference().ref

	success = DrawBarPlot(&canvasReference, width, height, &ys, &errorMessage)

	FreeStringReference(&errorMessage)

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = canvasReference.image
	return returnReference
}


func DrawBarPlot(_ canvasReference : inout RGBABitmapImageReference, _ width : Double, _ height : Double, _ ys : inout [Double], _ errorMessage : inout StringReference) -> Bool{
	var width = width;
	var height = height;
	var settings : BarPlotSettings
	var success : Bool

	errorMessage = StringReference()
	settings = GetDefaultBarPlotSettings().ref

	settings.barPlotSeries = Array(repeating:BarPlotSeries(), count: Int(1))
	settings.barPlotSeries[Int(0)] = GetDefaultBarPlotSeriesSettings().ref
	delete(settings.barPlotSeries[Int(0)].ys)
	settings.barPlotSeries[Int(0)].ys = ys
	settings.width = width
	settings.height = height

	success = DrawBarPlotFromSettings(&canvasReference, &settings, &errorMessage)

	return success
}


func DrawBarPlotFromSettings(_ canvasReference : inout RGBABitmapImageReference, _ settings : inout BarPlotSettings, _ errorMessage : inout StringReference) -> Bool{
	var xPadding, yPadding : Double
	var xPixelMin, yPixelMin, yPixelMax, xPixelMax : Double
	var xLengthPixels, yLengthPixels : Double
	var s, n, y, x, w, h, yMin, yMax, b, i, py, yValue : Double
	var colors : [RGBA]
	var ys, yGridPositions : [Double]
	var yTop, yBottom, ss, bs : Double
	var groupSeparation, barSeparation, barWidth, textwidth : Double
	var yLabels : StringArrayReference
	var yLabelPriorities : NumberArrayReference
	var occupied : [Rectangle]
	var nextRectangle : NumberReference
	var gridLabelColor, barColor : RGBA
	var label : [Character]
	var success : Bool
	var canvas : RGBABitmapImage

	success = BarPlotSettingsIsValid(&settings, &errorMessage)

	if(success){
		canvas = CreateImage(settings.width, settings.height, &GetWhite().ref).ref

		ss = Double(settings.barPlotSeries.count)
		gridLabelColor = GetGray(0.5).ref

		/* padding*/
		if(settings.autoPadding){
			xPadding = floor(GetDefaultPaddingPercentage()*ImageWidth(&canvas))
			yPadding = floor(GetDefaultPaddingPercentage()*ImageHeight(&canvas))
		}else{
			xPadding = settings.xPadding
			yPadding = settings.yPadding
		}

		/* Draw title*/
		DrawText(&canvas, floor(ImageWidth(&canvas)/2.0 - GetTextWidth(&settings.title)/2.0), floor(yPadding/3.0), &settings.title, &GetBlack().ref)
		DrawTextUpwards(&canvas, 10.0, floor(ImageHeight(&canvas)/2.0 - GetTextWidth(&settings.yLabel)/2.0), &settings.yLabel, &GetBlack().ref)

		/* min and max*/
		if(settings.autoBoundaries){
			if(ss >= 1.0){
				yMax = GetMaximum(&settings.barPlotSeries[Int(0)].ys)*1.05
				yMin = min(0.0, GetMinimum(&settings.barPlotSeries[Int(0)].ys))*1.05

				s = 0.0
				while(s < ss){
					yMax = max(yMax, GetMaximum(&settings.barPlotSeries[Int(s)].ys))
					yMin = min(yMin, GetMinimum(&settings.barPlotSeries[Int(s)].ys))
					s = s + 1.0
				}
			}else{
				yMax = 10.0
				yMin = 0.0
			}
		}else{
			yMin = settings.yMin
			yMax = settings.yMax
		}

		/* boundaries*/
		xPixelMin = xPadding
		yPixelMin = yPadding
		xPixelMax = ImageWidth(&canvas) - xPadding
		yPixelMax = ImageHeight(&canvas) - yPadding
		xLengthPixels = xPixelMax - xPixelMin
		yLengthPixels = yPixelMax - yPixelMin

		/* Draw boundary.*/
		DrawRectangle1px(&canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, &settings.gridColor)

		/* Draw grid lines.*/
		yLabels = StringArrayReference()
		yLabelPriorities = NumberArrayReference()
		yGridPositions = ComputeGridLinePositions(yMin, yMax, &yLabels, &yLabelPriorities)

		if(settings.showGrid){
			/* Y-grid*/
			i = 0.0
			while(i < Double(yGridPositions.count)){
				y = yGridPositions[Int(i)]
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				DrawLine1px(&canvas, xPixelMin, py, xPixelMax, py, &settings.gridColor)
				i = i + 1.0
			}
		}

		/* Draw origin.*/
		if(yMin < 0.0 && yMax > 0.0){
			py = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)
			DrawLine1px(&canvas, xPixelMin, py, xPixelMax, py, &settings.gridColor)
		}

		/* Labels*/
		occupied = Array(repeating:Rectangle(), count: Int(Double(yLabels.stringArray.count)))
		i = 0.0
		while(i < Double(occupied.count)){
			occupied[Int(i)] = CreateRectangle(0.0, 0.0, 0.0, 0.0).ref
			i = i + 1.0
		}
		nextRectangle = CreateNumberReference(0.0).ref

		i = 1.0
		while(i <= 5.0){
			DrawYLabelsForPriority(i, yMin, xPixelMin, yMax, yPixelMin, yPixelMax, &nextRectangle, &gridLabelColor, &canvas, &yGridPositions, &yLabels, &yLabelPriorities, &occupied, true)
			i = i + 1.0
		}

		/* Draw bars.*/
		if(settings.autoColor){
			if(!settings.grayscaleAutoColor){
				colors = Get8HighContrastColors()
			}else{
				colors = Array(repeating:RGBA(), count: Int(ss))
				if(ss > 1.0){
					i = 0.0
					while(i < ss){
						colors[Int(i)] = GetGray(0.7 - (i/ss)*0.7).ref
						i = i + 1.0
					}
				}else{
					colors[Int(0)] = GetGray(0.5).ref
				}
			}
		}else{
			colors = Array(repeating:RGBA(), count: Int(0))
		}

		/* distances*/
		bs = Double(settings.barPlotSeries[Int(0)].ys.count)

		if(settings.autoSpacing){
			groupSeparation = ImageWidth(&canvas)*0.05
			barSeparation = ImageWidth(&canvas)*0.005
		}else{
			groupSeparation = settings.groupSeparation
			barSeparation = settings.barSeparation
		}

		barWidth = (xLengthPixels - groupSeparation*(bs - 1.0) - barSeparation*(bs*(ss - 1.0)))/(bs*ss)

		/* Draw bars.*/
		b = 0.0
		n = 0.0
		while(n < bs){
			s = 0.0
			while(s < ss){
				ys = settings.barPlotSeries[Int(s)].ys

				yValue = ys[Int(n)]

				yBottom = MapYCoordinate(yValue, yMin, yMax, yPixelMin, yPixelMax)
				yTop = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)

				x = xPixelMin + n*(groupSeparation + ss*barWidth) + s*(barWidth) + b*barSeparation
				w = barWidth

				if(yValue >= 0.0){
					y = yBottom
					h = yTop - y
				}else{
					y = yTop
					h = yBottom - yTop
				}

				/* Cut at boundaries.*/
				if(y < yPixelMin && y + h > yPixelMax){
					y = yPixelMin
					h = yPixelMax - yPixelMin
				}else if(y < yPixelMin){
					y = yPixelMin
					if(yValue >= 0.0){
						h = yTop - y
					}else{
						h = yBottom - y
					}
				}else if(y + h > yPixelMax){
					h = yPixelMax - y
				}

				/* Get color*/
				if(settings.autoColor){
					barColor = colors[Int(s)]
				}else{
					barColor = settings.barPlotSeries[Int(s)].color
				}

				/* Draw*/
				if(settings.barBorder){
					DrawFilledRectangleWithBorder(&canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), &GetBlack().ref, &barColor)
				}else{
					DrawFilledRectangle(&canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), &barColor)
				}

				b = b + 1.0
				s = s + 1.0
			}
			b = b - 1.0
			n = n + 1.0
		}

		/* x-labels*/
		n = 0.0
		while(n < bs){
			if(settings.autoLabels){
				label = CreateStringDecimalFromNumber(n + 1.0)
			}else{
				label = settings.xLabels[Int(n)].stringx
			}

			textwidth = GetTextWidth(&label)

			x = xPixelMin + (n + 0.5)*(ss*barWidth + (ss - 1.0)*barSeparation) + n*groupSeparation - textwidth/2.0

			DrawText(&canvas, floor(x), ImageHeight(&canvas) - yPadding + 20.0, &label, &gridLabelColor)

			b = b + 1.0
			n = n + 1.0
		}

		canvasReference.image = canvas
	}

	return success
}


func BarPlotSettingsIsValid(_ settings : inout BarPlotSettings, _ errorMessage : inout StringReference) -> Bool{
	var success, lengthSet : Bool
	var series : BarPlotSeries
	var i, length : Double

	success = true

	/* Check series lengths.*/
	lengthSet = false
	length = 0.0
	i = 0.0
	while(i < Double(settings.barPlotSeries.count)){
		series = settings.barPlotSeries[Int(i)]

		if(!lengthSet){
			length = Double(series.ys.count)
			lengthSet = true
		}else if(length != Double(series.ys.count)){
			success = false
			errorMessage.stringx = characterArray("The number of data points must be equal for all series.").ca
		}
		i = i + 1.0
	}

	/* Check bounds.*/
	if(!settings.autoBoundaries){
		if(settings.yMin >= settings.yMax){
			success = false
			errorMessage.stringx = characterArray("Minimum y lower than maximum y.").ca
		}
	}

	/* Check padding.*/
	if(!settings.autoPadding){
		if(2.0*settings.xPadding >= settings.width){
			success = false
			errorMessage.stringx = characterArray("Double the horizontal padding is larger than or equal to the width.").ca
		}
		if(2.0*settings.yPadding >= settings.height){
			success = false
			errorMessage.stringx = characterArray("Double the vertical padding is larger than or equal to the height.").ca
		}
	}

	/* Check width and height.*/
	if(settings.width < 0.0){
		success = false
		errorMessage.stringx = characterArray("Width lower than zero.").ca
	}
	if(settings.height < 0.0){
		success = false
		errorMessage.stringx = characterArray("Height lower than zero.").ca
	}

	/* Check spacing*/
	if(!settings.autoSpacing){
		if(settings.groupSeparation < 0.0){
			success = false
			errorMessage.stringx = characterArray("Group separation lower than zero.").ca
		}
		if(settings.barSeparation < 0.0){
			success = false
			errorMessage.stringx = characterArray("Bar separation lower than zero.").ca
		}
	}

	return success
}


func GetMinimum(_ data : inout [Double]) -> Double{
	var i, minimum : Double

	minimum = data[Int(0)]
	i = 0.0
	while(i < Double(data.count)){
		minimum = min(minimum, data[Int(i)])
		i = i + 1.0
	}

	return minimum
}


func GetMaximum(_ data : inout [Double]) -> Double{
	var i, maximum : Double

	maximum = data[Int(0)]
	i = 0.0
	while(i < Double(data.count)){
		maximum = max(maximum, data[Int(i)])
		i = i + 1.0
	}

	return maximum
}


func BinomialDensity(_ x : Double, _ size : Double, _ p : Double) -> Double{
	var x = x;
	var size = size;
	var p = p;
	return Combinations(size, x)*pow(p, x)*pow(1.0 - p, size - x)
}


func BinomialRandom(_ prg : inout PseudorandomGenerator, _ n : Double, _ size : Double, _ p : Double) -> [Double]{
	var n = n;
	var size = size;
	var p = p;
	var ns : [Double]
	var i, j, nr, c : Double

	ns = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		c = 0.0

		j = 0.0
		while(j < size){
			nr = PseudorandomNextNumber(&prg)
			if(nr < p){
				c = c + 1.0
			}
			j = j + 1.0
		}

		ns[Int(i)] = c
		i = i + 1.0
	}

	return ns
}


func BinomialProbability(_ x : Double, _ size : Double, _ prob : Double) -> Double{
	var x = x;
	var size = size;
	var prob = prob;
	var sum, i : Double

	sum = 0.0
	i = 0.0
	while(i <= x){
		sum = sum + BinomialDensity(i, size, prob)
		i = i + 1.0
	}

	return sum
}


func BinomialQuantile(_ u : Double, _ size : Double, _ prob : Double) -> Double{
	var u = u;
	var size = size;
	var prob = prob;
	var sum, i : Double
	var done : Bool

	sum = 0.0
	done = false
	i = 0.0
	while(i <= size && !done){
		sum = sum + BinomialDensity(i, size, prob)
		if(sum > u){
			done = true
		}
		i = i + 1.0
	}

	return i - 1.0
}


func NormalDensity(_ x : Double, _ mu : Double, _ sd : Double) -> Double{
	var x = x;
	var mu = mu;
	var sd = sd;
	return 1.0/(sqrt(2.0*Double.pi)*sd)*exp(-(pow(x - mu, 2.0)/(2.0*pow(sd, 2.0))))
}


func NormalRandom(_ prg : inout PseudorandomGenerator, _ n : Double, _ mean : Double, _ sd : Double) -> [Double]{
	var n = n;
	var mean = mean;
	var sd = sd;
	var ns : [Double]
	var i, nr : Double

	ns = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		nr = PseudorandomNextNumber(&prg)
		ns[Int(i)] = NormalQuantile(nr, mean, sd)
		i = i + 1.0
	}

	return ns
}


func NormalProbability(_ q : Double, _ mean : Double, _ sd : Double) -> Double{
	var q = q;
	var mean = mean;
	var sd = sd;
	return NormalProbabilityMethod2(q, mean, sd)
}


func NormalProbabilityMethod1(_ q : Double, _ mean : Double, _ sd : Double) -> Double{
	var q = q;
	var mean = mean;
	var sd = sd;
	var p, z, qz, c0, c1, c2, c3, c4, c5 : Double

	q = (q - mean)/sd

	if(q < 0.0){
		p = 1.0 - NormalProbabilityMethod1(-q, 0.0, 1.0)
	}else{
		c0 = 0.2316419
		c1 = 0.319381530
		c2 = -0.356563782
		c3 = 1.781477937
		c4 = -1.821255978
		c5 = 1.330274429

		z = 1.0/(1.0 + c0*q)
		qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))))

		p = 1.0 - qz*NormalDensity(q, 0.0, 1.0)
	}

	return p
}


func NormalProbabilityMethod2(_ x : Double, _ mean : Double, _ sd : Double) -> Double{
	var x = x;
	var mean = mean;
	var sd = sd;
	return 1.0/2.0*(1.0 + Error((x - mean)/(sd*sqrt(2.0))))
}


func NormalQuantile(_ u : Double, _ mean : Double, _ sd : Double) -> Double{
	var u = u;
	var mean = mean;
	var sd = sd;
	return NormalQuantileMethod1(u, mean, sd)
}


func NormalQuantileMethod1(_ u : Double, _ mean : Double, _ sd : Double) -> Double{
	var u = u;
	var mean = mean;
	var sd = sd;
	var q, z, q1z, q2z, c0, c1, c2, c3, c4, c5, c6, c7, c8 : Double

	if(u < 1.0/2.0){
		q = -NormalQuantile(1.0 - u, 0.0, 1.0)
	}else{
		z = sqrt(-2.0*log(1.0 - u))
		c0 = -0.322232431088
		c1 = -0.342242088547
		c2 = -0.020423121024
		c3 = -0.0000453642210148
		c4 = 0.099348462606
		c5 = 0.58858157049
		c6 = 0.531103462366
		c7 = 0.10353775285
		c8 = 0.0038560700634
		q1z = c0 + z*(-1.0 + z*(c1 + z*(c2 + c3*z)))
		q2z = c4 + z*(c5 + z*(c6 + z*(c7 + c8*z)))
		q = z + q1z/q2z
	}

	q = mean + q*sd

	return q
}


func NormalQuantileMethod2(_ u : Double, _ mean : Double, _ sd : Double) -> Double{
	var u = u;
	var mean = mean;
	var sd = sd;
	return mean + sd*sqrt(2.0)*ErrorInverse(2.0*u - 1.0)
}


func PossionMass(_ k : Double, _ lambda : Double) -> Double{
	var k = k;
	var lambda = lambda;
	return pow(lambda, k)*exp(-lambda)/Factorial(k)
}


func PoissonRandom(_ prg : inout PseudorandomGenerator, _ n : Double, _ lambda : Double) -> [Double]{
	var n = n;
	var lambda = lambda;
	var ns : [Double]
	var i, nr : Double

	ns = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		nr = PseudorandomNextNumber(&prg)
		ns[Int(i)] = PoissonQuantile(nr, lambda)
		i = i + 1.0
	}

	return ns
}


func PoissonQuantile(_ p : Double, _ lambda : Double) -> Double{
	var p = p;
	var lambda = lambda;
	var sum, i : Double
	var done : Bool

	sum = 0.0
	done = false
	i = 0.0
	while(i <= lambda && !done){
		sum = sum + PossionMass(i, lambda)
		if(sum > p){
			done = true
		}
		i = i + 1.0
	}

	return i - 1.0
}


func PoissonProbability(_ k : Double, _ lambda : Double) -> Double{
	var k = k;
	var lambda = lambda;
	var i, t : Double

	t = 0.0
	i = 0.0
	while(i <= k){
		t = t + pow(lambda, i)/Factorial(i)
		i = i + 1.0
	}

	return t/exp(lambda)
}


func SampleWithReplacement(_ prg : inout PseudorandomGenerator, _ k : Double, _ n : Double) -> [Double]{
	var k = k;
	var n = n;
	var ss : [Double]
	var i : Double

	ss = Array(repeating:Double(), count: Int(k))

	i = 0.0
	while(i < k){
		ss[Int(i)] = PseudorandomNextInteger(&prg, n)
		i = i + 1.0
	}

	return ss
}


func Sample(_ prg : inout PseudorandomGenerator, _ k : Double, _ n : Double) -> [Double]{
	var k = k;
	var n = n;
	var ss, list : [Double]
	var i, next : Double
	var hasPicked : [Bool]
	var ssReference : NumberArrayReference

	ss = Array(repeating:Double(), count: Int(k))
	if(n/10.0 < k){
		/* If k is relatively high:*/
		list = RandomPermutation(&prg, n)

		ssReference = NumberArrayReference()
		arraysCopyNumberArrayRange(&list, 0.0, k, &ssReference)
		ss = ssReference.numberArray
		delete(ssReference)
		delete(list)
	}else{
		/* If k is relatively low:*/
		hasPicked = arraysCreateBooleanArray(n, false)

		i = 0.0
		while(i < n){
			next = PseudorandomNextInteger(&prg, n)
			if(!hasPicked[Int(next)]){
				hasPicked[Int(next)] = true
				ss[Int(i)] = next
				i = i + 1.0
			}
		}

		delete(hasPicked)
	}

	return ss
}


func Shuffle(_ prg : inout PseudorandomGenerator, _ list : inout [Double]) -> Void{
	FisherYatesShuffle(&prg, &list)
}


func FisherYatesShuffle(_ prg : inout PseudorandomGenerator, _ a : inout [Double]) -> Void{
	var i, j, n : Double

	n = Double(a.count)

	i = 0.0
	while(i < n - 2.0){
		j = PseudorandomNextIntegerBetween(&prg, i, n)
		arraysSwapElementsOfNumberArray(&a, i, j)
		i = i + 1.0
	}
}


func SampleWithReplacementFromArray(_ prg : inout PseudorandomGenerator, _ a : inout [Double], _ k : Double) -> [Double]{
	var k = k;
	var source, list : [Double]
	var i : Double

	source = SampleWithReplacement(&prg, k, Double(a.count))

	list = Array(repeating:Double(), count: Int(k))

	i = 0.0
	while(i < k){
		list[Int(i)] = a[Int(source[Int(i)])]
		i = i + 1.0
	}

	delete(source)

	return list
}


func SampleFromArray(_ prg : inout PseudorandomGenerator, _ a : inout [Double], _ k : Double) -> [Double]{
	var k = k;
	var source, list : [Double]
	var i : Double

	source = Sample(&prg, k, Double(a.count))

	list = Array(repeating:Double(), count: Int(k))

	i = 0.0
	while(i < k){
		list[Int(i)] = a[Int(source[Int(i)])]
		i = i + 1.0
	}

	delete(source)

	return list
}


func RandomPermutation(_ prg : inout PseudorandomGenerator, _ n : Double) -> [Double]{
	var n = n;
	var list : [Double]
	var i : Double

	list = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		list[Int(i)] = i
		i = i + 1.0
	}

	Shuffle(&prg, &list)

	return list
}


func StudentTDensity(_ x : Double, _ v : Double) -> Double{
	var x = x;
	var v = v;
	return Gamma((v + 1.0)/2.0)/(sqrt(v*Double.pi)*Gamma(v/2.0))*pow(1.0 + pow(x, 2.0)/v, -((v + 1.0)/2.0))
}


func StudentTProbability(_ x : Double, _ v : Double) -> Double{
	var x = x;
	var v = v;
	return 1.0/2.0 + x*Gamma((v + 1.0)/2.0)*Hypergeometric(1.0/2.0, (v + 1.0)/2.0, 3.0/2.0, -pow(x, 2.0)/v, 50.0, 0.00001)/(sqrt(Double.pi*v)*Gamma(v/2.0))
}


func StudentTRandom(_ prg : inout PseudorandomGenerator, _ n : Double, _ v : Double) -> [Double]{
	var n = n;
	var v = v;
	var ns : [Double]
	var i, nr : Double

	ns = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		nr = PseudorandomNextNumber(&prg)
		ns[Int(i)] = StudentTQuantile(nr, v)
		i = i + 1.0
	}

	return ns
}


func StudentTQuantile(_ p : Double, _ v : Double) -> Double{
	var p = p;
	var v = v;
	var t, i, j, q, hy, qi, qip1, gy, a : Double

	if(v == 1.0){
		q = tan(Double.pi*(p - 1.0/2.0))
	}else if(v == 2.0){
		a = 4.0*p*(1.0 - p)
		q = (2.0*p - 1.0)*sqrt(2.0/a)
	}else if(v == 4.0){
		a = 4.0*p*(1.0 - p)
		q = cos(1.0/3.0*acos(sqrt(a)))/sqrt(a)
		q = Sign(p - 1.0/2.0)*2.0*sqrt(q - 1.0)
	}else if(DivisibleBy(v, 2.0)){
		q = ChengFuStudentTQuantileAlgorithm(p, v)
	}else{
		q = HillsAlgorithm396(p, v)
	}

	return q
}


func ChengFuStudentTQuantileAlgorithm(_ p : Double, _ v : Double) -> Double{
	var p = p;
	var v = v;
	var a, qi, i, gy, j, qip1, q, k : Double

	k = ceil(v/2.0)
	a = 1.0 - p

	if(a != 0.5){
		qi = sqrt(2.0*pow(1.0 - 2.0*a, 2.0)/(1.0 - pow(1.0 - 2.0*a, 2.0)))

		i = 0.0
		while(i < 20.0){
			gy = 0.0
			j = 0.0
			while(j <= k - 1.0){
				gy = gy + Factorial(2.0*j)/pow(2.0, 2.0*j)/pow(Factorial(j), 2.0)*pow(1.0 + pow(qi, 2.0)/(2.0*k), -j)
				j = j + 1.0
			}

			qip1 = 1.0/sqrt(1.0/(2.0*k)*(pow(gy/(1.0 - 2.0*a), 2.0) - 1.0))

			qi = qip1
			i = i + 1.0
		}

		if(a > 0.5){
			q = -qi
		}else{
			q = qi
		}
	}else{
		q = 0.0
	}
	return q
}


func HillsAlgorithm396(_ p : Double, _ v : Double) -> Double{
	var p = p;
	var v = v;
	var q, t, z : Double
	var a, b, c, d, x, y : Double
	var negate : Bool

	if(p > 0.5){
		negate = false
		z = 2.0*(1.0 - p)
	}else{
		negate = true
		z = 2.0*p
	}

	a = 1.0/(v - 0.5)
	b = 48.0/(a*a)
	c = ((20700.0*a/b - 98.0)*a - 16.0)*a + 96.36
	d = ((94.5/(b + c) - 3.0)/b + 1.0)*sqrt(a*Double.pi/2.0)*v
	x = z*d
	y = pow(x, 2.0/v)

	if(y > 0.05 + a){
		x = NormalQuantile(z*0.5, 0.0, 1.0)
		y = x*x
		if(v < 5.0){
			c = c + 0.3*(v - 4.5)*(x + 0.6)
		}
		c = c + (((0.05*d*x - 5.0)*x - 7.0)*x - 2.0)*x + b
		y = (((((0.4*y + 6.3)*y + 36.0)*y + 94.5)/c - y - 3.0)/b + 1.0)*x
		y = a*y*y
		if(y > 0.002){
			y = exp(y) - 1.0
		}else{
			y = y + 0.5*y*y
		}
	}else{
		y = ((1.0/(((v + 6.0)/(v*y) - 0.089*d - 0.822)*(v + 2.0)*3.0) + 0.5/(v + 4.0))*y - 1.0)*(v + 1.0)/(v + 2.0) + 1.0/y
	}

	q = sqrt(v*y)

	if(negate){
		q = -q
	}

	return q
}


func Mean(_ list : inout [Double]) -> Double{
	var sum, i : Double

	sum = 0.0
	i = 0.0
	while(i < Double(list.count)){
		sum = sum + list[Int(i)]
		i = i + 1.0
	}

	return sum/Double(list.count)
}


func MeanOfRows(_ list : inout Matrix) -> [Double]{
	var means : [Double]
	var i : Double

	means = Array(repeating:Double(), count: Int(Double(list.r.count)))

	i = 0.0
	while(i < Double(list.r.count)){
		means[Int(i)] = Mean(&list.r[Int(i)].c)
		i = i + 1.0
	}

	return means
}


func MeanOfColumns(_ list : inout Matrix) -> [Double]{
	var means : [Double]
	var listT : Matrix

	listT = TransposeToNew(&list).ref

	means = MeanOfRows(&listT)

	delete(listT)

	return means
}


func Variance(_ list : inout [Double]) -> Double{
	var mu, sum, i : Double

	mu = Mean(&list)

	sum = 0.0
	i = 0.0
	while(i < Double(list.count)){
		sum = sum + pow(list[Int(i)] - mu, 2.0)
		i = i + 1.0
	}

	return sum/Double(list.count)
}


func Covariance(_ list1 : inout [Double], _ list2 : inout [Double]) -> Double{
	var mu1, mu2, sum, i : Double

	sum = 0.0
	if(Double(list1.count) == Double(list2.count)){

		mu1 = Mean(&list1)
		mu2 = Mean(&list2)

		sum = 0.0
		i = 0.0
		while(i < Double(list1.count)){
			sum = sum + (list1[Int(i)] - mu1)*(list2[Int(i)] - mu2)
			i = i + 1.0
		}
	}

	return sum/Double(list1.count)
}


func CovarianceMatrix(_ X : inout Matrix) -> MatrixReferenceClass{
	var A, XCentered, muMatrix : Matrix
	var mu : [Double]

	mu = MeanOfColumns(&X)
	muMatrix = CreateMatrixFromRowCopies(&mu, NumberOfRows(&X)).ref

	XCentered = CreateCopyOfMatrix(&X).ref
	Subtract(&XCentered, &muMatrix)

	A = MultiplyToNew(&TransposeToNew(&XCentered).ref, &XCentered).ref
	ScalarDivide(&A, NumberOfRows(&X))

	var returnReference = MatrixReferenceClass()
	returnReference.ref = A
	return returnReference
}


func CorrelationMatrix(_ X : inout Matrix) -> MatrixReferenceClass{
	var sigma, variancesMatrix, t1, correlationMatrixResult : Matrix
	var variances : [Double]
	var n : Double

	sigma = SampleCovarianceMatrix(&X).ref

	n = NumberOfRows(&sigma)
	variances = Array(repeating:Double(), count: Int(n))
	ExtractDiagonal(&sigma, &variances)
	vectorPower(&variances, -1.0/2.0)
	variancesMatrix = CreateDiagonalMatrixFromArray(&variances).ref
	t1 = CreateCopyOfMatrix(&variancesMatrix).ref
	Multiply(&t1, &variancesMatrix, &sigma)
	correlationMatrixResult = CreateCopyOfMatrix(&variancesMatrix).ref
	Multiply(&correlationMatrixResult, &t1, &variancesMatrix)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = correlationMatrixResult
	return returnReference
}


func SampleCovarianceMatrix(_ X : inout Matrix) -> MatrixReferenceClass{
	var A : Matrix

	A = CovarianceMatrix(&X).ref
	ScalarMultiply(&A, NumberOfRows(&X)/(NumberOfRows(&X) - 1.0))

	var returnReference = MatrixReferenceClass()
	returnReference.ref = A
	return returnReference
}


func Correlation(_ list1 : inout [Double], _ list2 : inout [Double]) -> Double{
	var cv, sd1, sd2 : Double

	cv = Covariance(&list1, &list2)
	sd1 = StandardDeviation(&list1)
	sd2 = StandardDeviation(&list2)

	return cv/(sd1*sd2)
}


func Percentile(_ list : inout [Double], _ p : Double) -> Double{
	var p = p;
	return list[Int(ceil(Double(list.count)*p) - 1.0)]
}


func VarianceSample(_ list : inout [Double]) -> Double{
	return Variance(&list)*Double(list.count)/(Double(list.count) - 1.0)
}


func StandardDeviation(_ list : inout [Double]) -> Double{
	return sqrt(Variance(&list))
}


func StandardDeviationSample(_ list : inout [Double]) -> Double{
	return sqrt(VarianceSample(&list))
}


func Median(_ list : inout [Double]) -> Double{
	var m : Double

	QuickSortNumbers(&list)

	if(Double(list.count).truncatingRemainder(dividingBy:2.0) == 1.0){
		m = list[Int(floor(Double(list.count)/2.0))]
	}else{
		m = (list[Int(Double(list.count)/2.0)] + list[Int(Double(list.count)/2.0 - 1.0)])/2.0
	}

	return m
}


func Mode(_ list : inout [Double]) -> [Double]{
	var unique, mostFrequent, valuesMostFrequent : Double
	var modes, counts : [Double]

	modes = Array(repeating:Double(), count: Int(0))
	if(Double(list.count) > 0.0){
		QuickSortNumbers(&list)
		unique = CountUniqueNumbers(&list)
		counts = CountOccurrenceOfEachNumber(&list, unique)
		mostFrequent = FindMostFrequentNumber(&counts)
		valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, &counts)
		delete(modes)
		modes = GetListOfNumbersWithHighestOccurrence(&list, mostFrequent, valuesMostFrequent, &counts)
		delete(counts)
	}

	return modes
}


func CountUniqueNumbers(_ list : inout [Double]) -> Double{
	var last, unique, i : Double

	last = list[Int(0)]
	unique = 1.0
	i = 1.0
	while(i < Double(list.count)){
		if(list[Int(i)] != last){
			unique = unique + 1.0
			last = list[Int(i)]
		}
		i = i + 1.0
	}

	return unique
}


func CountOccurrenceOfEachNumber(_ list : inout [Double], _ unique : Double) -> [Double]{
	var unique = unique;
	var counts : [Double]
	var current, last, i : Double

	counts = Array(repeating:Double(), count: Int(unique))

	current = 0.0
	counts[Int(0)] = 1.0
	last = list[Int(0)]
	i = 1.0
	while(i < Double(list.count)){
		if(list[Int(i)] != last){
			current = current + 1.0
			counts[Int(current)] = 1.0
		}else{
			counts[Int(current)] = counts[Int(current)] + 1.0
		}
		last = list[Int(i)]
		i = i + 1.0
	}

	return counts
}


func FindMostFrequentNumber(_ counts : inout [Double]) -> Double{
	var mostFrequent, i : Double

	mostFrequent = 0.0
	i = 0.0
	while(i < Double(counts.count)){
		mostFrequent = max(counts[Int(i)], mostFrequent)
		i = i + 1.0
	}
	return mostFrequent
}


func CountNumberOfHighestOccurrences(_ mostFrequent : Double, _ counts : inout [Double]) -> Double{
	var mostFrequent = mostFrequent;
	var valuesMostFrequent, i : Double

	valuesMostFrequent = 0.0
	i = 0.0
	while(i < Double(counts.count)){
		if(counts[Int(i)] == mostFrequent){
			valuesMostFrequent = valuesMostFrequent + 1.0
		}
		i = i + 1.0
	}
	return valuesMostFrequent
}


func GetListOfNumbersWithHighestOccurrence(_ list : inout [Double], _ mostFrequent : Double, _ valuesMostFrequent : Double, _ counts : inout [Double]) -> [Double]{
	var mostFrequent = mostFrequent;
	var valuesMostFrequent = valuesMostFrequent;
	var modes : [Double]
	var current, currentInsert, i : Double

	modes = Array(repeating:Double(), count: Int(valuesMostFrequent))

	current = 0.0
	currentInsert = 0.0
	i = 0.0
	while(i < Double(counts.count)){
		if(counts[Int(i)] == mostFrequent){
			modes[Int(currentInsert)] = list[Int(current)]
			currentInsert = currentInsert + 1.0
		}

		current = current + counts[Int(i)]
		i = i + 1.0
	}

	return modes
}


func LogNormalDensity(_ x : Double, _ mean : Double, _ sd : Double) -> Double{
	var x = x;
	var mean = mean;
	var sd = sd;
	return 1.0/(x*sd*sqrt(2.0*Double.pi))*exp(-(pow(log(x) - mean, 2.0)/(2.0*pow(sd, 2.0))))
}


func LogNormalRandom(_ prg : inout PseudorandomGenerator, _ n : Double, _ mean : Double, _ sd : Double) -> [Double]{
	var n = n;
	var mean = mean;
	var sd = sd;
	var i : Double
	var rs : [Double]

	rs = NormalRandom(&prg, n, mean, sd)

	i = 0.0
	while(i < n){
		rs[Int(i)] = exp(rs[Int(i)])
		i = i + 1.0
	}

	return rs
}


func LogNormalProbability(_ q : Double, _ mean : Double, _ sd : Double) -> Double{
	var q = q;
	var mean = mean;
	var sd = sd;
	return NormalProbability(log(q), mean, sd)
}


func LogNormalQuantile(_ p : Double, _ mean : Double, _ sd : Double) -> Double{
	var p = p;
	var mean = mean;
	var sd = sd;
	return exp(NormalQuantile(p, mean, sd))
}


func CreateUnsignedInteger(_ digits : Double) -> UnsignedIntegerReferenceClass{
	var digits = digits;
	var x : UnsignedInteger

	x = UnsignedInteger()
	x.digits = Array(repeating:Double(), count: Int(digits))

	ClearUnsignedInteger(&x)

	var returnReference = UnsignedIntegerReferenceClass()
	returnReference.ref = x
	return returnReference
}


func FreeUnsignedInteger(_ x : inout UnsignedInteger) -> Void{
	delete(x.digits)
	delete(x)
}


func ClearUnsignedInteger(_ x : inout UnsignedInteger) -> Void{
	var i : Double

	i = 0.0
	while(i < DigitCapacityUnsignedInteger(&x)){
		x.digits[Int(i)] = 0.0
		i = i + 1.0
	}
}


func TrimUnsignedInteger(_ x : inout UnsignedInteger) -> Void{
	var capacity, digits, newCapacity, i : Double
	var newDigits : [Double]

	capacity = DigitCapacityUnsignedInteger(&x)
	digits = DigitsUnsignedInteger(&x)

	if(capacity > digits){
		newCapacity = digits
		newDigits = Array(repeating:Double(), count: Int(newCapacity))

		i = 0.0
		while(i < newCapacity){
			newDigits[Int(i)] = x.digits[Int(i)]
			i = i + 1.0
		}

		delete(x.digits)
		x.digits = newDigits
	}
}


func ToStringUnsignedInteger(_ x : inout UnsignedInteger) -> [Character]{
	var str : [Character]
	var c : Character
	var i, digits, digit : Double

	digits = DigitsUnsignedInteger(&x)
	str = Array(repeating:Character(" "), count: Int(digits))

	i = 0.0
	while(i < digits){
		digit = DigitUnsignedInteger(&x, i)

		c = DecimalDigitToCharacter(digit)

		str[Int(digits - i - 1.0)] = c
		i = i + 1.0
	}

	return str
}


func AddUnsignedInteger(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Void{
	var overflow : Bool
	var capacity, ads, bds : Double

	overflow = !AddFixedUnsignedInteger(&x, &a, &b)

	if(overflow){
		delete(x.digits)

		ads = DigitsUnsignedInteger(&a)
		bds = DigitsUnsignedInteger(&b)
		capacity = max(ads, bds) + 1.0
		x.digits = Array(repeating:Double(), count: Int(capacity))

		AddFixedUnsignedInteger(&x, &a, &b)
	}
}


func SubtractUnsignedInteger(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	var ads, xds : Double

	ads = DigitsUnsignedInteger(&a)
	xds = DigitCapacityUnsignedInteger(&x)

	if(xds < ads){
		delete(x.digits)
		x.digits = Array(repeating:Double(), count: Int(ads))
	}

	return SubtractFixedUnsignedInteger(&x, &a, &b)
}


func MultiplyUnsignedInteger(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Void{
	var overflow : Bool
	var capacity, ads, bds : Double

	overflow = !MultiplyFixedUnsignedInteger(&x, &a, &b)

	if(overflow){
		delete(x.digits)

		ads = DigitsUnsignedInteger(&a)
		bds = DigitsUnsignedInteger(&b)
		capacity = ads + bds
		x.digits = Array(repeating:Double(), count: Int(capacity))

		MultiplyFixedUnsignedInteger(&x, &a, &b)
	}
}


func DivideUnsignedInteger(_ q : inout UnsignedInteger, _ r : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	var capacity, ads, bds, qds, rds : Double

	ads = DigitsUnsignedInteger(&a)
	bds = DigitsUnsignedInteger(&b)
	qds = DigitCapacityUnsignedInteger(&q)
	rds = DigitCapacityUnsignedInteger(&r)

	if(qds < ads - bds + 1.0){
		capacity = ads - bds + 1.0
		q.digits = Array(repeating:Double(), count: Int(capacity))
	}

	if(rds < bds){
		capacity = bds
		r.digits = Array(repeating:Double(), count: Int(capacity))
	}

	return DivideFixedUnsignedInteger(&q, &r, &a, &b)
}


func ShiftLeftUnsignedInteger(_ x : inout UnsignedInteger, _ shifts : Double) -> Void{
	var shifts = shifts;
	var xds, capacity, i : Double
	var oldDigits : [Double]

	xds = DigitsUnsignedInteger(&x)
	capacity = DigitCapacityUnsignedInteger(&x)

	if(xds + shifts > capacity){
		capacity = xds + shifts
		oldDigits = x.digits
		x.digits = Array(repeating:Double(), count: Int(capacity))
	}else{
		oldDigits = x.digits
	}

	i = 0.0
	while(i < Double(oldDigits.count) - shifts){
		x.digits[Int(Double(oldDigits.count) - i - 1.0)] = oldDigits[Int(Double(oldDigits.count) - shifts - i - 1.0)]
		i = i + 1.0
	}

	while(i < Double(oldDigits.count)){
		x.digits[Int(Double(oldDigits.count) - i - 1.0)] = 0.0
		i = i + 1.0
	}
}


func CreateArbitraryPrecisionInteger(_ digits : Double) -> ArbitraryPrecisionIntegerReferenceClass{
	var digits = digits;
	var x : ArbitraryPrecisionInteger

	x = ArbitraryPrecisionInteger()
	x.sign = true
	x.number = CreateUnsignedInteger(digits).ref

	var returnReference = ArbitraryPrecisionIntegerReferenceClass()
	returnReference.ref = x
	return returnReference
}


func FreeArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger) -> Void{
	FreeUnsignedInteger(&x.number)
	delete(x)
}


func ClearArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger) -> Void{
	x.sign = true
	ClearUnsignedInteger(&x.number)
}


func TrimArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger) -> Void{
	TrimUnsignedInteger(&x.number)
}


func ToStringArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger) -> [Character]{
	var str : [Character]
	var c : Character
	var i, digits, digit : Double

	if(Double(x.number.digits.count) > 0.0){

		digits = DigitsUnsignedInteger(&x.number)
		str = Array(repeating:Character(" "), count: Int(1.0 + digits))

		if(x.sign){
			str[Int(0)] = "+"
		}else{
			str[Int(0)] = "-"
		}

		i = 0.0
		while(i < digits){
			digit = DigitUnsignedInteger(&x.number, i)

			c = DecimalDigitToCharacter(digit)

			str[Int(1.0 + digits - i - 1.0)] = c
			i = i + 1.0
		}
	}else{
		str = Array(repeating:Character(" "), count: Int(2))
		str[Int(0)] = "+"
		str[Int(1)] = "0"
	}

	return str
}


func CreateArbitraryPrecisionIntegerFromString(_ str : inout [Character]) -> ArbitraryPrecisionIntegerReferenceClass{
	var x : ArbitraryPrecisionInteger
	var c : Character
	var i, digit, stringDigits, hasSign : Double

	hasSign = 0.0
	if(Double(str.count) > 0.0){
		if(str[Int(0)] == "-" || str[Int(0)] == "+"){
			hasSign = 1.0
		}
	}

	x = CreateArbitraryPrecisionInteger(Double(str.count) - hasSign).ref
	stringDigits = Double(str.count)

	if(Double(str.count) > 0.0){
		x.sign = true
		if(str[Int(0)] == "-"){
			x.sign = false
		}else if(str[Int(0)] == "+"){
			x.sign = true
		}
	}

	i = 0.0
	while(i < stringDigits - hasSign){
		c = str[Int(stringDigits - i - 1.0)]
		digit = CharacterToDecimalDigit(c)
		x.number.digits[Int(i)] = digit
		i = i + 1.0
	}

	var returnReference = ArbitraryPrecisionIntegerReferenceClass()
	returnReference.ref = x
	return returnReference
}


func AddArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger, _ a : inout ArbitraryPrecisionInteger, _ b : inout ArbitraryPrecisionInteger) -> Void{
	var asx, bs : Bool
	var comparisonResult : Double

	asx = a.sign
	bs = b.sign

	if(asx == bs){
		AddUnsignedInteger(&x.number, &a.number, &b.number)
		x.sign = asx
	}else if(asx == true){
		comparisonResult = CompareFixedUnsignedInteger(&a.number, &b.number)

		if(comparisonResult == 1.0 || comparisonResult == 0.0){
			SubtractUnsignedInteger(&x.number, &a.number, &b.number)
		}else{
			SubtractUnsignedInteger(&x.number, &b.number, &a.number)
			x.sign = false
		}
	}else{
		comparisonResult = CompareFixedUnsignedInteger(&b.number, &a.number)

		if(comparisonResult == 1.0 || comparisonResult == 0.0){
			SubtractUnsignedInteger(&x.number, &b.number, &a.number)
		}else{
			SubtractUnsignedInteger(&x.number, &a.number, &b.number)
			x.sign = false
		}
	}
}


func SubtractArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger, _ a : inout ArbitraryPrecisionInteger, _ b : inout ArbitraryPrecisionInteger) -> Void{
	var asx, bs : Bool
	var comparisonResult : Double

	asx = a.sign
	bs = b.sign

	if(asx == bs){
		if(asx == true){
			comparisonResult = CompareFixedUnsignedInteger(&a.number, &b.number)

			if(comparisonResult == 1.0 || comparisonResult == 0.0){
				SubtractUnsignedInteger(&x.number, &a.number, &b.number)
			}else{
				SubtractUnsignedInteger(&x.number, &b.number, &a.number)
				x.sign = false
			}
		}else{
			comparisonResult = CompareFixedUnsignedInteger(&b.number, &a.number)

			if(comparisonResult == 1.0 || comparisonResult == 0.0){
				SubtractUnsignedInteger(&x.number, &b.number, &a.number)
			}else{
				SubtractUnsignedInteger(&x.number, &a.number, &b.number)
				x.sign = false
			}
		}
	}else if(asx == false){
		AddUnsignedInteger(&x.number, &a.number, &b.number)
		x.sign = false
	}else{
		AddUnsignedInteger(&x.number, &a.number, &b.number)
		x.sign = true
	}
}


func MultiplyArbitraryPrecisionInteger(_ x : inout ArbitraryPrecisionInteger, _ a : inout ArbitraryPrecisionInteger, _ b : inout ArbitraryPrecisionInteger) -> Void{
	MultiplyUnsignedInteger(&x.number, &a.number, &b.number)
	if(a.sign != b.sign){
		x.sign = false
	}
}


func DivideArbitraryPrecisionInteger(_ q : inout ArbitraryPrecisionInteger, _ r : inout ArbitraryPrecisionInteger, _ a : inout ArbitraryPrecisionInteger, _ b : inout ArbitraryPrecisionInteger) -> Bool{
	var success, rIsZero : Bool
	var i : Double

	if(a.sign == b.sign){
		success = DivideUnsignedInteger(&q.number, &r.number, &a.number, &b.number)

		if(success){
			q.sign = true
			r.sign = true
		}
	}else if(a.sign == false){
		success = DivideUnsignedInteger(&q.number, &r.number, &a.number, &b.number)

		if(success){
			q.sign = false
			r.sign = true
		}

		rIsZero = true
		i = 0.0
		while(i < Double(r.number.digits.count)){
			if(r.number.digits[Int(i)] != 0.0){
				rIsZero = false
			}
			i = i + 1.0
		}

		if(!rIsZero){
			AddUnsignedInteger(&a.number, &a.number, &b.number)
			success = DivideUnsignedInteger(&q.number, &r.number, &a.number, &b.number)
			SubtractUnsignedInteger(&r.number, &b.number, &r.number)
			SubtractUnsignedInteger(&a.number, &a.number, &b.number)
		}
	}else{
		AddUnsignedInteger(&a.number, &a.number, &b.number)

		success = DivideUnsignedInteger(&q.number, &r.number, &a.number, &b.number)

		if(success){
			q.sign = false
			r.sign = false
		}
	}

	return success
}


func AddArbitraryPrecisionIntegerStrings(_ aStr : inout [Character], _ bStr : inout [Character]) -> [Character]{
	var a, b, c : ArbitraryPrecisionInteger
	var cStr : [Character]

	a = CreateArbitraryPrecisionIntegerFromString(&aStr).ref
	b = CreateArbitraryPrecisionIntegerFromString(&bStr).ref
	c = CreateArbitraryPrecisionInteger(0.0).ref

	AddArbitraryPrecisionInteger(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionInteger(&c)

	return cStr
}


func SubtractArbitraryPrecisionIntegerStrings(_ aStr : inout [Character], _ bStr : inout [Character]) -> [Character]{
	var a, b, c : ArbitraryPrecisionInteger
	var cStr : [Character]

	a = CreateArbitraryPrecisionIntegerFromString(&aStr).ref
	b = CreateArbitraryPrecisionIntegerFromString(&bStr).ref
	c = CreateArbitraryPrecisionInteger(0.0).ref

	SubtractArbitraryPrecisionInteger(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionInteger(&c)

	return cStr
}


func MultiplyArbitraryPrecisionIntegerStrings(_ aStr : inout [Character], _ bStr : inout [Character]) -> [Character]{
	var a, b, c : ArbitraryPrecisionInteger
	var cStr : [Character]

	a = CreateArbitraryPrecisionIntegerFromString(&aStr).ref
	b = CreateArbitraryPrecisionIntegerFromString(&bStr).ref
	c = CreateArbitraryPrecisionInteger(0.0).ref

	MultiplyArbitraryPrecisionInteger(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionInteger(&c)

	return cStr
}


func DivideArbitraryPrecisionIntegerStrings(_ aStr : inout [Character], _ bStr : inout [Character], _ rStr : inout StringReference) -> [Character]{
	var a, b, q, r : ArbitraryPrecisionInteger
	var qStr : [Character]

	a = CreateArbitraryPrecisionIntegerFromString(&aStr).ref
	b = CreateArbitraryPrecisionIntegerFromString(&bStr).ref
	q = CreateArbitraryPrecisionInteger(0.0).ref
	r = CreateArbitraryPrecisionInteger(0.0).ref

	DivideArbitraryPrecisionInteger(&q, &r, &a, &b)

	qStr = ToStringArbitraryPrecisionInteger(&q)
	rStr.stringx = ToStringArbitraryPrecisionInteger(&r)

	return qStr
}


func CreateArbitraryPrecisionFixedPointNumber(_ digitsBeforePoint : Double, _ digitsAfterPoint : Double) -> ArbitraryPrecisionFixedPointNumberReferenceClass{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var x : ArbitraryPrecisionFixedPointNumber

	x = ArbitraryPrecisionFixedPointNumber()
	x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint).ref
	x.pointPosition = digitsAfterPoint

	var returnReference = ArbitraryPrecisionFixedPointNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func FreeArbitraryPrecisionFixedPointNumber(_ x : inout ArbitraryPrecisionFixedPointNumber) -> Void{
	FreeArbitraryPrecisionInteger(&x.baseNumber)
	delete(x)
}


func AddArbitraryPrecisionFixedPoint(_ x : inout ArbitraryPrecisionFixedPointNumber, _ a : inout ArbitraryPrecisionFixedPointNumber, _ b : inout ArbitraryPrecisionFixedPointNumber) -> Bool{
	var x1, x2 : ArbitraryPrecisionFixedPointNumber
	var aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint : Double
	var success : Bool

	aDigitsBeforePoint = GetDigitsBeforePoint(&a)
	aDigitsAfterPoint = GetDigitsAfterPoint(&a)

	bDigitsBeforePoint = GetDigitsBeforePoint(&b)
	bDigitsAfterPoint = GetDigitsAfterPoint(&b)

	digitsBeforePoint = max(aDigitsBeforePoint, bDigitsBeforePoint)
	digitsAfterPoint = max(aDigitsAfterPoint, bDigitsAfterPoint)

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	AddArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &a.baseNumber)
	AddArbitraryPrecisionInteger(&x2.baseNumber, &x2.baseNumber, &b.baseNumber)

	ShiftLeftUnsignedInteger(&x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(&x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	AddArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(&x, &x1)

	return success
}


func AssignArbitraryPrecisionFixedPoint(_ x : inout ArbitraryPrecisionFixedPointNumber, _ a : inout ArbitraryPrecisionFixedPointNumber) -> Bool{
	var success, isPointFive, zeroOverflow : Bool
	var aDigitsBeforePoint, aDigitsAfterPoint, xDigitsBeforePoint, xDigitsAfterPoint, i, digit : Double
	var epsilon : UnsignedInteger

	xDigitsBeforePoint = GetDigitsBeforePoint(&x)
	aDigitsBeforePoint = GetDigitsBeforePoint(&a)
	xDigitsAfterPoint = GetDigitsAfterPoint(&x)
	aDigitsAfterPoint = GetDigitsAfterPoint(&a)

	zeroOverflow = true
	if(xDigitsBeforePoint < aDigitsBeforePoint){
		i = 0.0
		while(i < aDigitsBeforePoint - xDigitsBeforePoint){
			if(DigitUnsignedInteger(&a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1.0) != 0.0){
				zeroOverflow = false
			}
			i = i + 1.0
		}
	}

	if(zeroOverflow){
		/* Assign before point.*/
		i = 0.0
		while(i < xDigitsBeforePoint){
			if(i >= aDigitsBeforePoint){
				x.baseNumber.number.digits[Int(xDigitsAfterPoint + i)] = 0.0
			}else{
				x.baseNumber.number.digits[Int(xDigitsAfterPoint + i)] = DigitUnsignedInteger(&a.baseNumber.number, aDigitsAfterPoint + i)
			}
			i = i + 1.0
		}

		/* Assign after point:*/
		i = 0.0
		while(i < xDigitsAfterPoint){
			if(aDigitsAfterPoint - i - 1.0 < 0.0){
				x.baseNumber.number.digits[Int(xDigitsAfterPoint - i - 1.0)] = 0.0
			}else{
				x.baseNumber.number.digits[Int(xDigitsAfterPoint - i - 1.0)] = DigitUnsignedInteger(&a.baseNumber.number, aDigitsAfterPoint - i - 1.0)
			}
			i = i + 1.0
		}

		/* Assign sign.*/
		x.baseNumber.sign = a.baseNumber.sign

		/* Round if necessary.*/
		if(aDigitsAfterPoint > xDigitsAfterPoint){
			if(x.baseNumber.sign == true){
				digit = DigitUnsignedInteger(&a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

				if(digit >= 5.0){
					/* Make epsilon.*/
					epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint).ref
					epsilon.digits[Int(0)] = 1.0
					success = AddFixedUnsignedInteger(&x.baseNumber.number, &x.baseNumber.number, &epsilon)
					FreeUnsignedInteger(&epsilon)
				}else{
					success = true
				}
			}else{
				digit = DigitUnsignedInteger(&a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

				isPointFive = true
				if(digit == 5.0){
					i = aDigitsAfterPoint - xDigitsAfterPoint - 2.0
					while(i >= 0.0){
						if(DigitUnsignedInteger(&a.baseNumber.number, i) != 0.0){
							isPointFive = false
						}
						i = i - 1.0
					}
				}else{
					isPointFive = false
				}

				if(digit <= 4.0 || isPointFive){
					success = true
				}else{
					epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint).ref
					epsilon.digits[Int(0)] = 1.0
					success = AddFixedUnsignedInteger(&x.baseNumber.number, &x.baseNumber.number, &epsilon)
					FreeUnsignedInteger(&epsilon)
				}
			}
		}else{
			success = true
		}
	}else{
		success = false
	}

	return success
}


func GetDigitsBeforePoint(_ a : inout ArbitraryPrecisionFixedPointNumber) -> Double{
	var sum : Double
	var digitsBeforePoint, digitsAfterPoint : Double

	digitsAfterPoint = GetDigitsAfterPoint(&a)
	sum = DigitCapacityUnsignedInteger(&a.baseNumber.number)
	digitsBeforePoint = sum - digitsAfterPoint

	return digitsBeforePoint
}


func GetDigitsAfterPoint(_ a : inout ArbitraryPrecisionFixedPointNumber) -> Double{
	return a.pointPosition
}


func ToStringArbitraryPrecisionFixedPoint(_ x : inout ArbitraryPrecisionFixedPointNumber) -> [Character]{
	var str : [Character]
	var c : Character
	var i, digits, digit, point : Double

	if(Double(x.baseNumber.number.digits.count) > 0.0){

		digits = GetDigitsBeforePoint(&x) + GetDigitsAfterPoint(&x)
		str = Array(repeating:Character(" "), count: Int(1.0 + GetDigitsBeforePoint(&x) + 1.0 + GetDigitsAfterPoint(&x)))

		if(x.baseNumber.sign){
			str[Int(0)] = "+"
		}else{
			str[Int(0)] = "-"
		}

		point = 1.0

		i = 0.0
		while(i < digits){
			digit = DigitUnsignedInteger(&x.baseNumber.number, i)

			if(i == x.pointPosition){
				str[Int(1.0 + digits - i - 1.0 + point)] = "."
				point = 0.0
			}

			c = DecimalDigitToCharacter(digit)

			str[Int(1.0 + digits - i - 1.0 + point)] = c
			i = i + 1.0
		}
	}else{
		str = Array(repeating:Character(" "), count: Int(3))
		str[Int(0)] = "+"
		str[Int(1)] = "0"
		str[Int(2)] = "."
	}

	return str
}


func CreateArbitraryPrecisionFixedPointFromString(_ digitsBeforePoint : Double, _ digitsAfterPoint : Double, _ str : inout [Character]) -> ArbitraryPrecisionFixedPointNumberReferenceClass{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var x : ArbitraryPrecisionFixedPointNumber
	var c : Character
	var i, digit, stringDigits, hasSign, pointPosition, hasPoint, point : Double

	x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	hasSign = 0.0
	if(Double(str.count) > 0.0){
		if(str[Int(0)] == "-" || str[Int(0)] == "+"){
			hasSign = 1.0
		}
	}

	pointPosition = Double(str.count)
	hasPoint = 0.0
	i = 0.0
	while(i < Double(str.count) && hasPoint == 0.0){
		if(str[Int(Double(str.count) - i - 1.0)] == "."){
			pointPosition = i
			hasPoint = 1.0
		}
		i = i + 1.0
	}
	stringDigits = Double(str.count)

	if(Double(str.count) > 0.0){
		x.baseNumber.sign = true
		if(str[Int(0)] == "-"){
			x.baseNumber.sign = false
		}else if(str[Int(0)] == "+"){
			x.baseNumber.sign = true
		}
	}

	point = 0.0
	i = 0.0
	while(i < stringDigits - hasSign - hasPoint){
		if(i == pointPosition){
			point = 1.0
		}
		c = str[Int(stringDigits - point - i - 1.0)]
		digit = CharacterToDecimalDigit(c)
		x.baseNumber.number.digits[Int(i)] = digit
		i = i + 1.0
	}

	var returnReference = ArbitraryPrecisionFixedPointNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func SubtractArbitraryPrecisionFixedPoint(_ x : inout ArbitraryPrecisionFixedPointNumber, _ a : inout ArbitraryPrecisionFixedPointNumber, _ b : inout ArbitraryPrecisionFixedPointNumber) -> Bool{
	var x1, x2 : ArbitraryPrecisionFixedPointNumber
	var aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint : Double
	var success : Bool

	aDigitsBeforePoint = GetDigitsBeforePoint(&a)
	aDigitsAfterPoint = GetDigitsAfterPoint(&a)

	bDigitsBeforePoint = GetDigitsBeforePoint(&b)
	bDigitsAfterPoint = GetDigitsAfterPoint(&b)

	digitsBeforePoint = max(aDigitsBeforePoint, bDigitsBeforePoint)
	digitsAfterPoint = max(aDigitsAfterPoint, bDigitsAfterPoint)

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	AddArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &a.baseNumber)
	AddArbitraryPrecisionInteger(&x2.baseNumber, &x2.baseNumber, &b.baseNumber)

	ShiftLeftUnsignedInteger(&x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(&x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	SubtractArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(&x, &x1)

	return success
}


func MultiplyArbitraryPrecisionFixedPoint(_ x : inout ArbitraryPrecisionFixedPointNumber, _ a : inout ArbitraryPrecisionFixedPointNumber, _ b : inout ArbitraryPrecisionFixedPointNumber) -> Bool{
	var x1, x2, t : ArbitraryPrecisionFixedPointNumber
	var aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint : Double
	var success : Bool

	aDigitsBeforePoint = GetDigitsBeforePoint(&a)
	aDigitsAfterPoint = GetDigitsAfterPoint(&a)

	bDigitsBeforePoint = GetDigitsBeforePoint(&b)
	bDigitsAfterPoint = GetDigitsAfterPoint(&b)

	digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
	digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	AddArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &a.baseNumber)
	AddArbitraryPrecisionInteger(&x2.baseNumber, &x2.baseNumber, &b.baseNumber)

	ShiftLeftUnsignedInteger(&x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(&x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	t = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint).ref
	MultiplyArbitraryPrecisionInteger(&t.baseNumber, &x1.baseNumber, &x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(&x, &t)

	return success
}


func DivideArbitraryPrecisionFixedPoint(_ q : inout ArbitraryPrecisionFixedPointNumber, _ a : inout ArbitraryPrecisionFixedPointNumber, _ b : inout ArbitraryPrecisionFixedPointNumber) -> Bool{
	var x1, x2, qx, rx : ArbitraryPrecisionFixedPointNumber
	var aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint, qDigitsBeforePoint, qDigitsAfterPoint : Double
	var success : Bool

	aDigitsBeforePoint = GetDigitsBeforePoint(&a)
	aDigitsAfterPoint = GetDigitsAfterPoint(&a)

	bDigitsBeforePoint = GetDigitsBeforePoint(&b)
	bDigitsAfterPoint = GetDigitsAfterPoint(&b)

	qDigitsAfterPoint = GetDigitsAfterPoint(&q)

	digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
	digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

	x1 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint).ref
	x2 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint).ref

	AddArbitraryPrecisionInteger(&x1.baseNumber, &x1.baseNumber, &a.baseNumber)
	AddArbitraryPrecisionInteger(&x2.baseNumber, &x2.baseNumber, &b.baseNumber)

	ShiftLeftUnsignedInteger(&x1.baseNumber.number, qDigitsAfterPoint + 1.0 + bDigitsAfterPoint)

	qx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint).ref
	rx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint).ref
	DivideArbitraryPrecisionInteger(&qx.baseNumber, &rx.baseNumber, &x1.baseNumber, &x2.baseNumber)
	qx.pointPosition = qx.pointPosition + qDigitsAfterPoint - aDigitsAfterPoint + 1.0 - 2.0*bDigitsAfterPoint

	success = AssignArbitraryPrecisionFixedPoint(&q, &qx)

	return success
}


func AddArbitraryPrecisionFixedPointStrings(_ aStr : inout [Character], _ bStr : inout [Character], _ digitsBeforePoint : Double, _ digitsAfterPoint : Double) -> [Character]{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var a, b, c : ArbitraryPrecisionFixedPointNumber
	var cStr : [Character]

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&aStr), GetDigitsAfterAPFPString(&aStr), &aStr).ref
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&bStr), GetDigitsAfterAPFPString(&bStr), &bStr).ref
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	AddArbitraryPrecisionFixedPoint(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionFixedPoint(&c)

	return cStr
}


func SubtractArbitraryPrecisionFixedPointStrings(_ aStr : inout [Character], _ bStr : inout [Character], _ digitsBeforePoint : Double, _ digitsAfterPoint : Double) -> [Character]{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var a, b, c : ArbitraryPrecisionFixedPointNumber
	var cStr : [Character]

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&aStr), GetDigitsAfterAPFPString(&aStr), &aStr).ref
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&bStr), GetDigitsAfterAPFPString(&bStr), &bStr).ref
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	SubtractArbitraryPrecisionFixedPoint(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionFixedPoint(&c)

	return cStr
}


func MultiplyArbitraryPrecisionFixedPointStrings(_ aStr : inout [Character], _ bStr : inout [Character], _ digitsBeforePoint : Double, _ digitsAfterPoint : Double) -> [Character]{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var a, b, c : ArbitraryPrecisionFixedPointNumber
	var cStr : [Character]

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&aStr), GetDigitsAfterAPFPString(&aStr), &aStr).ref
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&bStr), GetDigitsAfterAPFPString(&bStr), &bStr).ref
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	MultiplyArbitraryPrecisionFixedPoint(&c, &a, &b)

	cStr = ToStringArbitraryPrecisionFixedPoint(&c)

	return cStr
}


func DivideArbitraryPrecisionFixedPointStrings(_ aStr : inout [Character], _ bStr : inout [Character], _ digitsBeforePoint : Double, _ digitsAfterPoint : Double) -> [Character]{
	var digitsBeforePoint = digitsBeforePoint;
	var digitsAfterPoint = digitsAfterPoint;
	var a, b, q, r : ArbitraryPrecisionFixedPointNumber
	var qStr : [Character]

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&aStr), GetDigitsAfterAPFPString(&aStr), &aStr).ref
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(&bStr), GetDigitsAfterAPFPString(&bStr), &bStr).ref
	q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint).ref

	DivideArbitraryPrecisionFixedPoint(&q, &a, &b)

	qStr = ToStringArbitraryPrecisionFixedPoint(&q)

	return qStr
}


func GetDigitsAfterAPFPString(_ str : inout [Character]) -> Double{
	var pointPosition, hasPoint, i, digitsAfter : Double

	pointPosition = Double(str.count)
	hasPoint = 0.0
	i = 0.0
	while(i < Double(str.count) && hasPoint == 0.0){
		if(str[Int(Double(str.count) - i - 1.0)] == "."){
			pointPosition = i
			hasPoint = 1.0
		}
		i = i + 1.0
	}

	if(hasPoint == 0.0){
		digitsAfter = 0.0
	}else{
		digitsAfter = pointPosition
	}

	return digitsAfter
}


func GetDigitsBeforeAPFPString(_ str : inout [Character]) -> Double{
	var hasSign, pointPosition, hasPoint, i, digitsBefore : Double

	hasSign = 0.0
	if(Double(str.count) > 0.0){
		if(str[Int(0)] == "-" || str[Int(0)] == "+"){
			hasSign = 1.0
		}
	}

	pointPosition = 0.0
	hasPoint = 0.0
	i = 0.0
	while(i < Double(str.count) && hasPoint == 0.0){
		if(str[Int(Double(str.count) - i - 1.0)] == "."){
			pointPosition = i
			hasPoint = 1.0
		}
		i = i + 1.0
	}

	if(hasPoint == 0.0){
		digitsBefore = Double(str.count) - hasPoint
	}else{
		digitsBefore = Double(str.count) - pointPosition - hasSign - 1.0
	}

	return digitsBefore
}


func DecimalDigitToCharacter(_ digit : Double) -> Character{
	var digit = digit;
	var c : Character
	if(digit == 1.0){
		c = "1"
	}else if(digit == 2.0){
		c = "2"
	}else if(digit == 3.0){
		c = "3"
	}else if(digit == 4.0){
		c = "4"
	}else if(digit == 5.0){
		c = "5"
	}else if(digit == 6.0){
		c = "6"
	}else if(digit == 7.0){
		c = "7"
	}else if(digit == 8.0){
		c = "8"
	}else if(digit == 9.0){
		c = "9"
	}else{
		c = "0"
	}
	return c
}


func DigitUnsignedInteger(_ x : inout UnsignedInteger, _ i : Double) -> Double{
	var i = i;
	return x.digits[Int(i)]
}


func DigitsUnsignedInteger(_ x : inout UnsignedInteger) -> Double{
	var i, capacity, digits : Double
	var done : Bool

	capacity = DigitCapacityUnsignedInteger(&x)
	done = false
	digits = capacity

	i = capacity - 1.0
	while(i >= 0.0 && !done){
		if(DigitUnsignedInteger(&x, i) == 0.0){
			digits = digits - 1.0
		}else{
			done = true
		}
		i = i - 1.0
	}

	if(digits == 0.0){
		digits = 1.0
	}

	return digits
}


func ToStringFixedUnsignedInteger(_ x : inout UnsignedInteger) -> [Character]{
	var str : [Character]
	var c : Character
	var i, digits, digit : Double

	digits = DigitCapacityUnsignedInteger(&x)
	str = Array(repeating:Character(" "), count: Int(digits))

	i = 0.0
	while(i < digits){
		digit = DigitUnsignedInteger(&x, i)

		c = DecimalDigitToCharacter(digit)

		str[Int(digits - i - 1.0)] = c
		i = i + 1.0
	}

	return str
}


func DigitCapacityUnsignedInteger(_ x : inout UnsignedInteger) -> Double{
	return Double(x.digits.count)
}


func CreateFixedUnsignedIntegerFromString(_ digits : Double, _ str : inout [Character]) -> UnsignedIntegerReferenceClass{
	var digits = digits;
	var x : UnsignedInteger
	var c : Character
	var i, digit, stringDigits : Double

	x = CreateUnsignedInteger(digits).ref
	stringDigits = Double(str.count)

	i = 0.0
	while(i < stringDigits){
		c = str[Int(stringDigits - i - 1.0)]

		digit = CharacterToDecimalDigit(c)

		x.digits[Int(i)] = digit
		i = i + 1.0
	}

	var returnReference = UnsignedIntegerReferenceClass()
	returnReference.ref = x
	return returnReference
}


func CharacterToDecimalDigit(_ c : Character) -> Double{
	var c = c;
	var digit : Double

	if(c == "1"){
		digit = 1.0
	}else if(c == "2"){
		digit = 2.0
	}else if(c == "3"){
		digit = 3.0
	}else if(c == "4"){
		digit = 4.0
	}else if(c == "5"){
		digit = 5.0
	}else if(c == "6"){
		digit = 6.0
	}else if(c == "7"){
		digit = 7.0
	}else if(c == "8"){
		digit = 8.0
	}else if(c == "9"){
		digit = 9.0
	}else{
		digit = 0.0
	}

	return digit
}


func AddFixedUnsignedInteger(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	return AddFixedUnsignedIntegerWithShift(&x, &a, &b, 0.0, 0.0)
}


func AddFixedUnsignedIntegerWithShift(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger, _ aShift : Double, _ bShift : Double) -> Bool{
	var aShift = aShift;
	var bShift = bShift;
	var ads, bds, xds, i, carry, remainder, ad, bd, apos, bpos : Double
	var overflow : Bool

	ads = DigitsUnsignedInteger(&a)
	bds = DigitsUnsignedInteger(&b)
	xds = DigitCapacityUnsignedInteger(&x)

	if(xds >= ads && xds >= bds){
		carry = 0.0

		i = 0.0
		while(i < xds){
			apos = i - aShift
			if(apos >= 0.0 && apos < ads){
				ad = DigitUnsignedInteger(&a, apos)
			}else{
				ad = 0.0
			}

			bpos = i - bShift
			if(bpos >= 0.0 && bpos < bds){
				bd = DigitUnsignedInteger(&b, bpos)
			}else{
				bd = 0.0
			}

			remainder = ad + bd + carry

			if(remainder >= 10.0){
				carry = 1.0
				remainder = remainder - 10.0
			}else{
				carry = 0.0
			}

			x.digits[Int(i)] = remainder
			i = i + 1.0
		}

		if(carry == 1.0){
			overflow = true
		}else{
			overflow = false
		}
	}else{
		overflow = true
	}

	return !overflow
}


func SubtractFixedUnsignedInteger(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	return SubtractFixedUnsignedIntegerWithShift(&x, &a, &b, 0.0, 0.0)
}


func SubtractFixedUnsignedIntegerWithShift(_ x : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger, _ aShift : Double, _ bShift : Double) -> Bool{
	var aShift = aShift;
	var bShift = bShift;
	var ads, bds, xds, i, borrow, remainder, ad, bd, apos, bpos : Double
	var underflow, overflow : Bool

	ads = DigitsUnsignedInteger(&a)
	bds = DigitsUnsignedInteger(&b)
	xds = DigitCapacityUnsignedInteger(&x)

	borrow = 0.0
	overflow = false

	i = 0.0
	while(i < max(max(ads, bds), xds) && !overflow){
		apos = i - aShift
		if(apos >= 0.0 && apos < ads){
			ad = DigitUnsignedInteger(&a, apos)
		}else{
			ad = 0.0
		}

		bpos = i - bShift
		if(bpos >= 0.0 && bpos < bds){
			bd = DigitUnsignedInteger(&b, bpos)
		}else{
			bd = 0.0
		}

		remainder = ad - bd - borrow

		if(remainder < 0.0){
			borrow = 1.0
			remainder = remainder + 10.0
		}else{
			borrow = 0.0
		}

		if(remainder != 0.0){
			if(i < xds){
			}else{
				overflow = true
			}
		}

		if(i < xds){
			x.digits[Int(i)] = remainder
		}
		i = i + 1.0
	}

	if(borrow == 1.0){
		underflow = true
	}else{
		underflow = false
	}

	return !underflow && !overflow
}


func MultiplyFixedUnsignedInteger(_ c : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	var i, j, ads, ad : Double
	var success : Bool

	success = true

	ClearUnsignedInteger(&c)

	ads = DigitsUnsignedInteger(&a)
	i = 0.0
	while(i < ads){
		ad = DigitUnsignedInteger(&a, i)

		j = 0.0
		while(j < ad){
			success = success && AddFixedUnsignedIntegerWithShift(&c, &c, &b, 0.0, i)
			j = j + 1.0
		}
		i = i + 1.0
	}

	if(Double(c.digits.count) == 0.0){
		success = false
	}

	return success
}


func CompareFixedUnsignedInteger(_ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Double{
	var comparizonResult, ads, bds, i, ad, bd : Double
	var done : Bool

	ads = DigitsUnsignedInteger(&a)
	bds = DigitsUnsignedInteger(&b)

	comparizonResult = 0.0

	if(ads > bds){
		comparizonResult = 1.0
	}else if(ads < bds){
		comparizonResult = -1.0
	}else{
		done = false
		i = ads - 1.0
		while(i >= 0.0 && !done){
			ad = DigitUnsignedInteger(&a, i)
			bd = DigitUnsignedInteger(&b, i)

			if(ad > bd){
				comparizonResult = 1.0
				done = true
			}else if(ad < bd){
				comparizonResult = -1.0
				done = true
			}
			i = i - 1.0
		}
	}

	return comparizonResult
}


func CompareFixedUnsignedIntegerWithShift(_ a : inout UnsignedInteger, _ b : inout UnsignedInteger, _ aShift : Double, _ bShift : Double) -> Double{
	var aShift = aShift;
	var bShift = bShift;
	var comparizonResult, ads, bds, i, ad, bd, apos, bpos : Double
	var done : Bool

	ads = DigitsUnsignedInteger(&a)
	if(ads > 0.0){
		ads = ads + aShift
	}
	bds = DigitsUnsignedInteger(&b)
	if(bds > 0.0){
		bds = bds + bShift
	}

	comparizonResult = 0.0

	if(ads > bds){
		comparizonResult = 1.0
	}else if(ads < bds){
		comparizonResult = -1.0
	}else{
		done = false
		i = ads - 1.0
		while(i >= 0.0 && !done){
			apos = i - aShift
			if(apos >= 0.0 && apos < ads){
				ad = DigitUnsignedInteger(&a, apos)
			}else{
				ad = 0.0
			}

			bpos = i - bShift
			if(bpos >= 0.0 && bpos < bds){
				bd = DigitUnsignedInteger(&b, bpos)
			}else{
				bd = 0.0
			}

			if(ad > bd){
				comparizonResult = 1.0
				done = true
			}else if(ad < bd){
				comparizonResult = -1.0
				done = true
			}
			i = i - 1.0
		}
	}

	return comparizonResult
}


func DivideFixedUnsignedInteger(_ q : inout UnsignedInteger, _ r : inout UnsignedInteger, _ a : inout UnsignedInteger, _ b : inout UnsignedInteger) -> Bool{
	var i, j, ads, bds, qd, comparisonResult, qdsCapacity : Double
	var success, done : Bool

	success = true

	ClearUnsignedInteger(&q)
	ClearUnsignedInteger(&r)

	ads = DigitsUnsignedInteger(&a)
	bds = DigitsUnsignedInteger(&b)
	qdsCapacity = DigitCapacityUnsignedInteger(&q)

	/* bds == 0 -> b.digits[0] != 0*/
	if(bds != 1.0 || b.digits[Int(0)] != 0.0){
		if(ads >= bds){
			i = ads - bds
			while(i >= 0.0 && success){
				qd = 0.0
				done = false
				j = 0.0
				while(j <= 9.0 && !done){
					comparisonResult = CompareFixedUnsignedIntegerWithShift(&a, &b, 0.0, i)
					if(comparisonResult == 1.0 || comparisonResult == 0.0){
						SubtractFixedUnsignedIntegerWithShift(&a, &a, &b, 0.0, i)
						qd = qd + 1.0
					}else{
						done = true
					}
					j = j + 1.0
				}
				if(i < qdsCapacity){
					q.digits[Int(i)] = qd
				}else{
					success = false
				}
				i = i - 1.0
			}
			if(success){
				/* Put the rest in the remainder.*/
				success = AddFixedUnsignedInteger(&r, &r, &a)

				if(success){
					/* Reconstruct a.*/
					MultiplyFixedUnsignedInteger(&a, &q, &b)
					AddFixedUnsignedInteger(&a, &a, &r)
				}
			}
		}else{
			/* Put everything in the remainder.*/
			AddFixedUnsignedInteger(&r, &r, &a)
		}
	}else{
		/* division by zero*/
		success = false
	}

	return success
}


func AssertFalse(_ b : Bool, _ failures : inout NumberReference) -> Void{
	var b = b;
	if(b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertTrue(_ b : Bool, _ failures : inout NumberReference) -> Void{
	var b = b;
	if(!b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertEquals(_ a : Double, _ b : Double, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertBooleansEqual(_ a : Bool, _ b : Bool, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertCharactersEqual(_ a : Character, _ b : Character, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertStringEquals(_ a : inout [Character], _ b : inout [Character], _ failures : inout NumberReference) -> Void{
	if(!arraysStringsEqual(&a, &b)){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertNumberArraysEqual(_ a : inout [Double], _ b : inout [Double], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertEquals(a[Int(i)], b[Int(i)], &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertBooleanArraysEqual(_ a : inout [Bool], _ b : inout [Bool], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertBooleansEqual(a[Int(i)], b[Int(i)], &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertStringArraysEqual(_ a : inout [StringReference], _ b : inout [StringReference], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertStringEquals(&a[Int(i)].stringx, &b[Int(i)].stringx, &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func CreateBooleanReference(_ value : Bool) -> BooleanReferenceReferenceClass{
	var value = value;
	var ref : BooleanReference

	ref = BooleanReference()
	ref.booleanValue = value

	var returnReference = BooleanReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateBooleanArrayReference(_ value : inout [Bool]) -> BooleanArrayReferenceReferenceClass{
	var ref : BooleanArrayReference

	ref = BooleanArrayReference()
	ref.booleanArray = value

	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateBooleanArrayReferenceLengthValue(_ length : Double, _ value : Bool) -> BooleanArrayReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : BooleanArrayReference
	var i : Double

	ref = BooleanArrayReference()
	ref.booleanArray = Array(repeating:Bool(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.booleanArray[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeBooleanArrayReference(_ booleanArrayReference : inout BooleanArrayReference) -> Void{
	delete(booleanArrayReference.booleanArray)
	delete(booleanArrayReference)
}


func CreateCharacterReference(_ value : Character) -> CharacterReferenceReferenceClass{
	var value = value;
	var ref : CharacterReference

	ref = CharacterReference()
	ref.characterValue = value

	var returnReference = CharacterReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberReference(_ value : Double) -> NumberReferenceReferenceClass{
	var value = value;
	var ref : NumberReference

	ref = NumberReference()
	ref.numberValue = value

	var returnReference = NumberReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberArrayReference(_ value : inout [Double]) -> NumberArrayReferenceReferenceClass{
	var ref : NumberArrayReference

	ref = NumberArrayReference()
	ref.numberArray = value

	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberArrayReferenceLengthValue(_ length : Double, _ value : Double) -> NumberArrayReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : NumberArrayReference
	var i : Double

	ref = NumberArrayReference()
	ref.numberArray = Array(repeating:Double(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.numberArray[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeNumberArrayReference(_ numberArrayReference : inout NumberArrayReference) -> Void{
	delete(numberArrayReference.numberArray)
	delete(numberArrayReference)
}


func CreateStringReference(_ value : inout [Character]) -> StringReferenceReferenceClass{
	var ref : StringReference
	var i : Double

	ref = StringReference()
	ref.stringx = Array(repeating:Character(" "), count: Int(Double(value.count)))
	i = 0.0
	while(i < Double(value.count)){
		ref.stringx[Int(i)] = value[Int(i)]
		i = i + 1.0
	}

	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateStringReferenceLengthValue(_ length : Double, _ value : Character) -> StringReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : StringReference
	var i : Double

	ref = StringReference()
	ref.stringx = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < length){
		ref.stringx[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeStringReference(_ stringReference : inout StringReference) -> Void{
	delete(stringReference.stringx)
	delete(stringReference)
}


func CreateStringArrayReference(_ strings : inout [StringReference]) -> StringArrayReferenceReferenceClass{
	var ref : StringArrayReference

	ref = StringArrayReference()
	ref.stringArray = strings

	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateStringArrayReferenceLengthValue(_ length : Double, _ value : inout [Character]) -> StringArrayReferenceReferenceClass{
	var length = length;
	var ref : StringArrayReference
	var i : Double

	ref = StringArrayReference()
	ref.stringArray = Array(repeating:StringReference(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.stringArray[Int(i)] = CreateStringReference(&value).ref
		i = i + 1.0
	}

	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeStringArrayReference(_ stringArrayReference : inout StringArrayReference) -> Void{
	FreeStringReferenceArray(&stringArrayReference.stringArray)
	delete(stringArrayReference)
}


func FreeStringReferenceArray(_ stringReferencesArray : inout [StringReference]) -> Void{
	var i : Double
	i = 0.0
	while(i < Double(stringReferencesArray.count)){
		delete(stringReferencesArray[Int(i)])
		i = i + 1.0
	}
	delete(stringReferencesArray)
}


func Increase(_ nRef : inout NumberReference) -> Double{
	nRef.numberValue = nRef.numberValue + 1.0

	return nRef.numberValue
}


func Decrease(_ nRef : inout NumberReference) -> Double{
	nRef.numberValue = nRef.numberValue - 1.0

	return nRef.numberValue
}


func AddToReference(_ nRef : inout NumberReference, _ n : Double) -> Double{
	var n = n;
	nRef.numberValue = nRef.numberValue + n

	return nRef.numberValue
}


func CreateDate(_ year : Double, _ month : Double, _ day : Double) -> DateReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var date : Date

	date = Date()

	date.year = year
	date.month = month
	date.day = day

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func IsLeapYearWithCheck(_ year : Double, _ isLeapYearReference : inout BooleanReference, _ message : inout StringReference) -> Bool{
	var year = year;
	var itIsLeapYear : Bool
	var success : Bool

	if(year >= 1752.0){
		success = true
		itIsLeapYear = IsLeapYear(year)
	}else{
		success = false
		itIsLeapYear = false
		message.stringx = characterArray("Gregorian calendar was not in general use.").ca
	}

	isLeapYearReference.booleanValue = itIsLeapYear
	return success
}


func IsLeapYear(_ year : Double) -> Bool{
	var year = year;
	var itIsLeapYear : Bool

	if(DivisibleBy(year, 4.0)){
		if(DivisibleBy(year, 100.0)){
			if(DivisibleBy(year, 400.0)){
				itIsLeapYear = true
			}else{
				itIsLeapYear = false
			}
		}else{
			itIsLeapYear = true
		}
	}else{
		itIsLeapYear = false
	}

	return itIsLeapYear
}


func DayToDateWithCheck(_ dayNr : Double, _ dateReference : inout DateReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var date : Date
	var remainder : NumberReference
	var success : Bool

	if(dayNr >= -79623.0){
		date = Date()
		remainder = NumberReference()
		remainder.numberValue = dayNr + 79623.0
		/* Days since 1752-01-01. Day 0: Thursday, 1970-01-01*/
		/* Find year.*/
		date.year = GetYearFromDayNr(remainder.numberValue, &remainder)

		/* Find month.*/
		date.month = GetMonthFromDayNr(remainder.numberValue, date.year, &remainder)

		/* Find day.*/
		date.day = 1.0 + remainder.numberValue

		dateReference.date = date
		success = true
	}else{
		success = false
		message.stringx = characterArray("Gregorian calendar was not in general use before 1752.").ca
	}

	return success
}


func DayToDate(_ dayNr : Double) -> DateReferenceClass{
	var dayNr = dayNr;
	var date : Date
	var success : Bool
	var dateRef : DateReference
	var message : StringReference

	dateRef = DateReference()
	message = StringReference()

	success = DayToDateWithCheck(dayNr, &dateRef, &message)
	if(success){
		date = dateRef.date
		delete(dateRef)
		FreeStringReference(&message)
	}else{
		date = CreateDate(1970.0, 1.0, 1.0).ref
	}

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func GetMonthFromDayNrWithCheck(_ dayNr : Double, _ year : Double, _ monthReference : inout NumberReference, _ remainderReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var year = year;
	var month : Double
	var success : Bool

	if(dayNr >= -79623.0){
		month = GetMonthFromDayNr(dayNr, year, &remainderReference)
		monthReference.numberValue = month
		success = true
	}else{
		success = false
		message.stringx = characterArray("Gregorian calendar not in general use before 1752.").ca
	}

	return success
}


func GetMonthFromDayNr(_ dayNr : Double, _ year : Double, _ remainderReference : inout NumberReference) -> Double{
	var dayNr = dayNr;
	var year = year;
	var daysInMonth : [Double]
	var done : Bool
	var month : Double

	daysInMonth = GetDaysInMonth(year)
	done = false
	month = 1.0

	while(!done){
		if(dayNr >= daysInMonth[Int(month)]){
			dayNr = dayNr - daysInMonth[Int(month)]
			month = month + 1.0
		}else{
			done = true
		}
	}
	remainderReference.numberValue = dayNr

	return month
}


func GetYearFromDayNrWithCheck(_ dayNr : Double, _ yearReference : inout NumberReference, _ remainder : inout NumberReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var success : Bool
	var year : Double

	if(dayNr >= 0.0){
		success = true
		year = GetYearFromDayNr(dayNr, &remainder)
		yearReference.numberValue = year
	}else{
		success = false
		message.stringx = characterArray("Day number must be 0 or higher. 0 is 1752-01-01.").ca
	}

	return success
}


func GetYearFromDayNr(_ dayNr : Double, _ remainder : inout NumberReference) -> Double{
	var dayNr = dayNr;
	var nrOfDays : Double
	var done : Bool
	var year : Double

	done = false
	year = 1752.0

	while(!done){
		if(IsLeapYear(year)){
			nrOfDays = 366.0
		}else{
			nrOfDays = 365.0
		}

		if(dayNr >= nrOfDays){
			/* First day is 0.*/
			dayNr = dayNr - nrOfDays
			year = year + 1.0
		}else{
			done = true
		}
	}
	remainder.numberValue = dayNr

	return year
}


func DaysBetweenDates(_ A : inout Date, _ B : inout Date) -> Double{
	var daysA, daysB, daysBetween : Double

	daysA = DateToDays(&A)
	daysB = DateToDays(&B)

	daysBetween = daysB - daysA

	return daysBetween
}


func GetDaysInMonthWithCheck(_ year : Double, _ daysInMonthReference : inout NumberArrayReference, _ message : inout StringReference) -> Bool{
	var year = year;
	var daysInMonth : [Double]
	var success : Bool
	var date : Date

	date = CreateDate(year, 1.0, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		daysInMonth = GetDaysInMonth(year)

		daysInMonthReference.numberArray = daysInMonth
	}

	return success
}


func GetDaysInMonth(_ year : Double) -> [Double]{
	var year = year;
	var daysInMonth : [Double]

	daysInMonth = Array(repeating:Double(), count: Int(1.0 + 12.0))

	daysInMonth[Int(0)] = 0.0
	daysInMonth[Int(1)] = 31.0

	if(IsLeapYear(year)){
		daysInMonth[Int(2)] = 29.0
	}else{
		daysInMonth[Int(2)] = 28.0
	}
	daysInMonth[Int(3)] = 31.0
	daysInMonth[Int(4)] = 30.0
	daysInMonth[Int(5)] = 31.0
	daysInMonth[Int(6)] = 30.0
	daysInMonth[Int(7)] = 31.0
	daysInMonth[Int(8)] = 31.0
	daysInMonth[Int(9)] = 30.0
	daysInMonth[Int(10)] = 31.0
	daysInMonth[Int(11)] = 30.0
	daysInMonth[Int(12)] = 31.0

	return daysInMonth
}


func DateToDaysWithCheck(_ date : inout Date, _ dayNumberReferenceReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var days : Double
	var success : Bool

	success = IsValidDate(&date, &message)
	if(success){
		days = DateToDays(&date)
		dayNumberReferenceReference.numberValue = days
	}

	return success
}


func DateToDays(_ date : inout Date) -> Double{
	var days : Double

	/* Day 1752-01-01*/
	days = -79623.0

	days = days + DaysInYears(date.year)
	days = days + DaysInMonths(date.month, date.year)
	days = days + date.day - 1.0

	return days
}


func DateToWeekdayNumberWithCheck(_ date : inout Date, _ weekDayNumberReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var weekDay : Double
	var success : Bool

	success = IsValidDate(&date, &message)
	if(success){
		weekDay = DateToWeekdayNumber(&date)
		weekDayNumberReference.numberValue = weekDay
	}

	return success
}


func DateToWeekdayNumber(_ date : inout Date) -> Double{
	var days, weekDay : Double

	days = DateToDays(&date)

	days = days + 79623.0
	days = days + 5.0

	weekDay = days.truncatingRemainder(dividingBy:7.0) + 1.0

	return weekDay
}


func DateToWeeknumber(_ date : inout Date, _ yearRef : inout NumberReference) -> Double{
	var weekNumber, weekday, days, daysWeek1Start, weekdayNewYears : Double
	var week1Start, newyears : Date

	week1Start = CopyDate(&date).ref

	week1Start.day = 1.0
	week1Start.month = 1.0
	weekday = DateToWeekdayNumber(&week1Start)

	/* Set week1Start to the start of the Week 1.*/
	/* If monday, week 1 begins on Jan. 1st*/
	if(weekday == 1.0){
		week1Start.day = 1.0
	}
	/* If tuesday, week 1 begins on Dec. 31st*/
	if(weekday == 2.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 31.0
	}
	/* If wednesday, week 1 begins on Dec. 30th*/
	if(weekday == 3.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 30.0
	}
	/* If thursday, week 1 begins on Dec. 29th*/
	if(weekday == 4.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 29.0
	}
	/* If friday, week 1 begins on Jan. 4th*/
	if(weekday == 5.0){
		week1Start.day = 4.0
	}
	/* If saturday, week 1 begins on Jan. 3rd*/
	if(weekday == 6.0){
		week1Start.day = 3.0
	}
	/* If sunday, week 1 begins on Jan. 2nd*/
	if(weekday == 7.0){
		week1Start.day = 2.0
	}

	days = DateToDays(&date)
	daysWeek1Start = DateToDays(&week1Start)

	if(days >= daysWeek1Start){
		weekNumber = 1.0 + floor((days - daysWeek1Start)/7.0)

		if(weekNumber >= 1.0 && weekNumber <= 52.0){
			/* Week is between 1 and 52 in the current year.*/
			yearRef.numberValue = date.year
		}else{
			/* Is week nr 53 or 1 next year?*/
			newyears = CopyDate(&date).ref
			newyears.month = 12.0
			newyears.day = 31.0
			weekdayNewYears = DateToWeekdayNumber(&newyears)
			if(weekdayNewYears == 1.0 || weekdayNewYears == 2.0 || weekdayNewYears == 3.0){
				/* Week 1 next year.*/
				weekNumber = 1.0
				yearRef.numberValue = date.year + 1.0
			}else{
				/* Week 53*/
				yearRef.numberValue = date.year
			}
			delete(newyears)
		}
	}else{
		/* Week is in previous year. Either 52nd or 53rd.*/
		newyears = CopyDate(&date).ref
		newyears.month = 12.0
		newyears.day = 31.0
		newyears.year = date.year - 1.0
		weekNumber = DateToWeeknumber(&newyears, &yearRef)
		delete(newyears)
	}

	delete(week1Start)

	return weekNumber
}


func DaysInMonthsWithCheck(_ month : Double, _ year : Double, _ daysInMonthsReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var month = month;
	var year = year;
	var days : Double
	var success : Bool
	var date : Date

	date = CreateDate(year, month, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		days = DaysInMonths(month, year)

		daysInMonthsReference.numberValue = days
	}

	return success
}


func DaysInMonths(_ month : Double, _ year : Double) -> Double{
	var month = month;
	var year = year;
	var daysInMonth : [Double]
	var days : Double
	var i : Double

	daysInMonth = GetDaysInMonth(year)

	days = 0.0
	i = 1.0
	while(i < month){
		days = days + daysInMonth[Int(i)]
		i = i + 1.0
	}

	return days
}


func DaysInYearsWithCheck(_ years : Double, _ daysReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var years = years;
	var days : Double
	var success : Bool
	var date : Date

	date = CreateDate(years, 1.0, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		days = DaysInYears(years)
		daysReference.numberValue = days
	}

	return success
}


func DaysInYears(_ years : Double) -> Double{
	var years = years;
	var days : Double
	var i : Double
	var nrOfDays : Double

	days = 0.0
	i = 1752.0
	while(i < years){
		if(IsLeapYear(i)){
			nrOfDays = 366.0
		}else{
			nrOfDays = 365.0
		}
		days = days + nrOfDays
		i = i + 1.0
	}

	return days
}


func IsValidDate(_ date : inout Date, _ message : inout StringReference) -> Bool{
	var valid : Bool
	var daysInMonth : [Double]
	var daysInThisMonth : Double

	if(date.year >= 1752.0){
		if(IsInteger(date.year)){
			if(date.month >= 1.0 && date.month <= 12.0){
				if(IsInteger(date.month)){
					daysInMonth = GetDaysInMonth(date.year)
					daysInThisMonth = daysInMonth[Int(date.month)]
					if(date.day >= 1.0 && date.day <= daysInThisMonth){
						if(IsInteger(date.day)){
							valid = true
						}else{
							valid = false
							message.stringx = characterArray("Day must be an integer.").ca
						}
					}else{
						valid = false
						message.stringx = characterArray("The month does not have the given day number.").ca
					}
				}else{
					valid = false
					message.stringx = characterArray("Month must be an integer.").ca
				}
			}else{
				valid = false
				message.stringx = characterArray("Month must be between 1 and 12, inclusive.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("Year must be an integer.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("Gregorian calendar was not in general use before 1752.").ca
	}

	return valid
}


func AddDaysToDate(_ date : inout Date, _ days : Double, _ message : inout StringReference) -> Bool{
	var days = days;
	var n : Double
	var success : Bool
	var dateReference : DateReference
	var daysRef : NumberReference

	daysRef = NumberReference()
	success = DateToDaysWithCheck(&date, &daysRef, &message)

	if(success){
		n = daysRef.numberValue
		n = n + days

		dateReference = DateReference()
		success = DayToDateWithCheck(n, &dateReference, &message)
		if(success){
			AssignDate(&date, &dateReference.date)
		}
	}

	return success
}


func AssignDate(_ a : inout Date, _ b : inout Date) -> Void{
	a.year = b.year
	a.month = b.month
	a.day = b.day
}


func AddMonthsToDate(_ date : inout Date, _ months : Double, _ message : inout StringReference) -> Bool{
	var months = months;
	var i : Double
	var success : Bool
	var backup : Date

	backup = CopyDate(&date).ref

	if(months > 0.0){
		i = 0.0
		while(i < months){
			date.month = date.month + 1.0

			if(date.month == 13.0){
				date.month = 1.0
				date.year = date.year + 1.0
			}
			i = i + 1.0
		}
	}
	if(months < 0.0){
		i = 0.0
		while(i < -months){
			date.month = date.month - 1.0

			if(date.month == 0.0){
				date.month = 12.0
				date.year = date.year - 1.0
			}
			i = i + 1.0
		}
	}

	success = IsValidDate(&date, &message)

	if(success){
	}else{
		/* Restore old date*/
		AssignDate(&date, &backup)
	}

	return success
}


func DateToStringISO8601WithCheck(_ date : inout Date, _ datestr : inout StringReference, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = IsValidDate(&date, &message)

	if(success){
		if(date.year <= 9999.0){
			datestr.stringx = DateToStringISO8601(&date)
		}else{
			message.stringx = characterArray("This library works from 1752 to 9999.").ca
		}
	}

	return success
}


func DateToStringISO8601(_ date : inout Date) -> [Character]{
	var str : [Character]

	str = Array(repeating:Character(" "), count: Int(10))

	str[Int(0)] = cDecimalDigitToCharacter(floor(date.year/1000.0))
	str[Int(1)] = cDecimalDigitToCharacter(floor((date.year.truncatingRemainder(dividingBy:1000.0))/100.0))
	str[Int(2)] = cDecimalDigitToCharacter(floor((date.year.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(3)] = cDecimalDigitToCharacter(floor(date.year.truncatingRemainder(dividingBy:10.0)))

	str[Int(4)] = "-"

	str[Int(5)] = cDecimalDigitToCharacter(floor((date.month.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(6)] = cDecimalDigitToCharacter(floor(date.month.truncatingRemainder(dividingBy:10.0)))

	str[Int(7)] = "-"

	str[Int(8)] = cDecimalDigitToCharacter(floor((date.day.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(9)] = cDecimalDigitToCharacter(floor(date.day.truncatingRemainder(dividingBy:10.0)))

	return str
}


func DateFromStringISO8601(_ str : inout [Character]) -> DateReferenceClass{
	var date : Date
	var n : Double

	date = Date()

	n = cCharacterToDecimalDigit(str[Int(0)])*1000.0
	n = n + cCharacterToDecimalDigit(str[Int(1)])*100.0
	n = n + cCharacterToDecimalDigit(str[Int(2)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(3)])*1.0

	date.year = n

	n = cCharacterToDecimalDigit(str[Int(5)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(6)])*1.0

	date.month = n

	n = cCharacterToDecimalDigit(str[Int(8)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(9)])*1.0

	date.day = n

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func DateFromStringISO8601WithCheck(_ str : inout [Character], _ dateRef : inout DateReference, _ message : inout StringReference) -> Bool{
	var valid : Bool

	valid = IsValidDateISO8601(&str, &message)

	if(valid){
		dateRef.date = DateFromStringISO8601(&str).ref
	}

	return valid
}


func IsValidDateISO8601(_ str : inout [Character], _ message : inout StringReference) -> Bool{
	var valid : Bool

	if(Double(str.count) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0){

		if(cIsNumber(str[Int(0)]) && cIsNumber(str[Int(1)]) && cIsNumber(str[Int(2)]) && cIsNumber(str[Int(3)]) && cIsNumber(str[Int(5)]) && cIsNumber(str[Int(6)]) && cIsNumber(str[Int(8)]) && cIsNumber(str[Int(9)])){
			if(str[Int(4)] == "-" && str[Int(7)] == "-"){
				valid = true
			}else{
				valid = false
				message.stringx = characterArray("ISO8601 date must use \'-\' in positions 5 and 8.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("ISO8601 date must be exactly 10 characters long.").ca
	}

	return valid
}


func DateEquals(_ a : inout Date, _ b : inout Date) -> Bool{
	return a.year == b.year && a.month == b.month && a.day == b.day
}


func CopyDate(_ a : inout Date) -> DateReferenceClass{
	var b : Date

	b = CreateDate(a.year, a.month, a.day).ref

	var returnReference = DateReferenceClass()
	returnReference.ref = b
	return returnReference
}


func GetSecondsFromDate(_ date : inout Date) -> Double{
	var seconds, days, secondsInMinute, secondsInHour, secondsInDay : Double
	var dayNumberReferenceReference : NumberReference
	var message : StringReference
	var success : Bool

	seconds = 0.0
	dayNumberReferenceReference = NumberReference()
	message = StringReference()

	success = DateToDaysWithCheck(&date, &dayNumberReferenceReference, &message)
	if(success){
		days = dayNumberReferenceReference.numberValue

		secondsInMinute = 60.0
		secondsInHour = 60.0*secondsInMinute
		secondsInDay = 24.0*secondsInHour

		seconds = seconds + secondsInDay*days
	}

	delete(dayNumberReferenceReference)
	delete(message)

	return seconds
}


func DateIsInInterval(_ interval : inout Interval, _ date : inout Date) -> Bool{
	var from, to, day : Double

	from = DateToDays(&interval.first)
	to = DateToDays(&interval.last)
	day = DateToDays(&date)

	return day >= from && day <= to
}


func DateLessThan(_ a : inout Date, _ b : inout Date) -> Bool{
	var less : Bool

	less = false

	if(a.year < b.year){
		less = true
	}else if(a.year == b.year){
		if(a.month < b.month){
			less = true
		}else if(a.month == b.month){
			if(a.day < b.day){
				less = true
			}else{
			}
		}
	}

	return less
}


func CreateDateTimeTimezone(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double, _ timezoneOffsetSeconds : Double) -> DateTimeTimezoneReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var timezoneOffsetSeconds = timezoneOffsetSeconds;
	var dateTimeTimezone : DateTimeTimezone

	dateTimeTimezone = DateTimeTimezone()

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds).ref
	dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = dateTimeTimezone
	return returnReference
}


func CreateDateTimeTimezoneInHoursAndMinutes(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double, _ timezoneOffsetHours : Double, _ timezoneOffsetMinutes : Double) -> DateTimeTimezoneReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var timezoneOffsetHours = timezoneOffsetHours;
	var timezoneOffsetMinutes = timezoneOffsetMinutes;
	var dateTimeTimezone : DateTimeTimezone

	dateTimeTimezone = DateTimeTimezone()

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds).ref
	dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes)

	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = dateTimeTimezone
	return returnReference
}


func GetDateFromDateTimeTimeZone(_ dateTimeTimezone : inout DateTimeTimezone, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var dateTime : DateTime

	dateTime = dateTimeTimezone.dateTime

	return AddSecondsToDateTimeWithCheck(&dateTime, -dateTimeTimezone.timezoneOffsetSeconds, &dateTimeReference, &message)
}


func CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(_ dateTime : inout DateTime, _ timezoneOffsetSeconds : Double, _ dateTimeTimezoneReference : inout DateTimeTimezoneReference, _ message : inout StringReference) -> Bool{
	var timezoneOffsetSeconds = timezoneOffsetSeconds;
	var success : Bool
	var adjustedDateTimeReference : DateTimeReference
	var dateTimeTimezone : DateTimeTimezone

	adjustedDateTimeReference = DateTimeReference()
	dateTimeTimezone = DateTimeTimezone()

	success = AddSecondsToDateTime(&dateTime, timezoneOffsetSeconds, &adjustedDateTimeReference, &message)

	if(success){
		dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

		dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone
	}

	return success
}


func CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(_ dateTime : inout DateTime, _ timezoneOffsetHours : Double, _ timezoneOffsetMinutes : Double, _ dateTimeTimezoneReference : inout DateTimeTimezoneReference, _ message : inout StringReference) -> Bool{
	var timezoneOffsetHours = timezoneOffsetHours;
	var timezoneOffsetMinutes = timezoneOffsetMinutes;
	return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(&dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), &dateTimeTimezoneReference, &message)
}


func GetDateTimeTimezoneFromSeconds(_ dateTimeTzRef : inout DateTimeTimezoneReference, _ seconds : Double, _ offset : Double, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var offset = offset;
	var success : Bool
	var dateTimeRef : DateTimeReference

	dateTimeRef = DateTimeReference()
	success = GetDateTimeFromSeconds(seconds, &dateTimeRef, &message)

	if(success){
		success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(&dateTimeRef.dateTime, offset, &dateTimeTzRef, &message)
	}

	return success
}


func CreateDateTime(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double) -> DateTimeReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var dateTime : DateTime

	dateTime = DateTime()

	dateTime.date = CreateDate(year, month, day).ref
	dateTime.hours = hours
	dateTime.minutes = minutes
	dateTime.seconds = seconds

	var returnReference = DateTimeReferenceClass()
	returnReference.ref = dateTime
	return returnReference
}


func GetDateTimeFromSeconds(_ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var dateTime : DateTime
	var secondsInMinute, secondsInHour, secondsInDay, days, remainder : Double
	var date : Date
	var dateReference : DateReference
	var success : Bool

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute
	secondsInDay = 24.0*secondsInHour
	days = floor(seconds/secondsInDay)
	remainder = seconds - days*secondsInDay
	dateReference = DateReference()

	success = DayToDateWithCheck(days, &dateReference, &message)
	if(success){
		date = dateReference.date

		dateTime = DateTime()
		dateTime.date = date
		dateTime.hours = floor(remainder/secondsInHour)
		remainder = remainder - dateTime.hours*secondsInHour
		dateTime.minutes = floor(remainder/secondsInMinute)
		remainder = remainder - dateTime.minutes*secondsInMinute
		dateTime.seconds = remainder

		dateTimeReference.dateTime = dateTime
	}

	return success
}


func GetSecondsFromDateTime(_ dateTime : inout DateTime) -> Double{
	var seconds, secondsInMinute, secondsInHour : Double

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute

	seconds = GetSecondsFromDate(&dateTime.date)
	seconds = seconds + secondsInHour*dateTime.hours
	seconds = seconds + secondsInMinute*dateTime.minutes
	seconds = seconds + dateTime.seconds

	return seconds
}


func GetSecondsFromMinutes(_ minutes : Double) -> Double{
	var minutes = minutes;
	return minutes*60.0
}


func GetSecondsFromHours(_ hours : Double) -> Double{
	var hours = hours;
	return GetSecondsFromMinutes(hours*60.0)
}


func GetSecondsFromDays(_ days : Double) -> Double{
	var days = days;
	return GetSecondsFromHours(days*24.0)
}


func GetSecondsFromWeeks(_ weeks : Double) -> Double{
	var weeks = weeks;
	return GetSecondsFromDays(weeks*7.0)
}


func GetMinutesFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return seconds/60.0
}


func GetHoursFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetMinutesFromSeconds(seconds)/60.0
}


func GetDaysFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetHoursFromSeconds(seconds)/24.0
}


func GetWeeksFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetDaysFromSeconds(seconds)/7.0
}


func GetDateFromDateTime(_ dateTime : inout DateTime) -> DateReferenceClass{
	var returnReference = DateReferenceClass()
	returnReference.ref = dateTime.date
	return returnReference
}


func AddSecondsToDateTimeWithCheck(_ dateTime : inout DateTime, _ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var secondsInDateTime : Double
	var success : Bool

	if(IsValidDateTime(&dateTime, &message)){
		secondsInDateTime = GetSecondsFromDateTime(&dateTime)
		secondsInDateTime = secondsInDateTime + seconds

		success = GetDateTimeFromSeconds(secondsInDateTime, &dateTimeReference, &message)
	}else{
		success = false
	}

	return success
}


func AddSecondsToDateTime(_ dateTime : inout DateTime, _ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var secondsInDateTime : Double

	secondsInDateTime = GetSecondsFromDateTime(&dateTime)
	secondsInDateTime = secondsInDateTime + seconds

	return GetDateTimeFromSeconds(secondsInDateTime, &dateTimeReference, &message)
}


func AddMinutesToDateTime(_ dateTime : inout DateTime, _ minutes : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var minutes = minutes;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromMinutes(minutes), &dateTimeReference, &message)
}


func AddHoursToDateTime(_ dateTime : inout DateTime, _ hours : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var hours = hours;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromHours(hours), &dateTimeReference, &message)
}


func AddDaysToDateTime(_ dateTime : inout DateTime, _ days : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var days = days;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromDays(days), &dateTimeReference, &message)
}


func AddWeeksToDateTime(_ dateTime : inout DateTime, _ weeks : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var weeks = weeks;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromWeeks(weeks), &dateTimeReference, &message)
}


func DateTimeToStringISO8601WithCheck(_ datetime : inout DateTime, _ dateStr : inout StringReference, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = DateToStringISO8601WithCheck(&datetime.date, &dateStr, &message)

	if(success){
		delete(dateStr.stringx)

		success = IsValidDateTime(&datetime, &message)
		if(success){
			dateStr.stringx = DateTimeToStringISO8601(&datetime)
		}
	}

	return success
}


func IsValidDateTime(_ datetime : inout DateTime, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = IsValidDate(&datetime.date, &message)

	if(success){
		if(datetime.hours <= 23.0 && datetime.hours >= 0.0){
			if(datetime.minutes <= 59.0 && datetime.minutes >= 0.0){
				if(datetime.seconds <= 59.0 && datetime.seconds >= 0.0){
					success = true
				}else{
					success = false
					message.stringx = characterArray("Seconds must be between 0 and 59.").ca
				}
			}else{
				success = false
				message.stringx = characterArray("Minutes must be between 0 and 59.").ca
			}
		}else{
			success = false
			message.stringx = characterArray("Hours must be between 0 and 23.").ca
		}
	}

	return success
}


func DateTimeToStringISO8601(_ datetime : inout DateTime) -> [Character]{
	var datestr, str : [Character]
	var i : Double

	str = Array(repeating:Character(" "), count: Int(19))

	datestr = DateToStringISO8601(&datetime.date)
	i = 0.0
	while(i < Double(datestr.count)){
		str[Int(i)] = datestr[Int(i)]
		i = i + 1.0
	}

	str[Int(10)] = "T"
	str[Int(11)] = cDecimalDigitToCharacter(floor((datetime.hours.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(12)] = cDecimalDigitToCharacter(floor(datetime.hours.truncatingRemainder(dividingBy:10.0)))

	str[Int(13)] = ":"

	str[Int(14)] = cDecimalDigitToCharacter(floor((datetime.minutes.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(15)] = cDecimalDigitToCharacter(floor(datetime.minutes.truncatingRemainder(dividingBy:10.0)))

	str[Int(16)] = ":"

	str[Int(17)] = cDecimalDigitToCharacter(floor((datetime.seconds.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(18)] = cDecimalDigitToCharacter(floor(datetime.seconds.truncatingRemainder(dividingBy:10.0)))

	return str
}


func DateTimeFromStringISO8601(_ str : inout [Character]) -> DateTimeReferenceClass{
	var dateTime : DateTime
	var n : Double

	dateTime = DateTime()

	dateTime.date = DateFromStringISO8601(&str).ref

	n = cCharacterToDecimalDigit(str[Int(11)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(12)])*1.0

	dateTime.hours = n

	n = cCharacterToDecimalDigit(str[Int(14)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(15)])*1.0

	dateTime.minutes = n

	n = cCharacterToDecimalDigit(str[Int(17)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(18)])*1.0

	dateTime.seconds = n

	var returnReference = DateTimeReferenceClass()
	returnReference.ref = dateTime
	return returnReference
}


func DateTimeFromStringISO8601WithCheck(_ str : inout [Character], _ dateTimeRef : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var valid : Bool

	valid = IsValidDateTimeISO8601(&str, &message)

	if(valid){
		dateTimeRef.dateTime = DateTimeFromStringISO8601(&str).ref
	}

	return valid
}


func IsValidDateTimeISO8601(_ str : inout [Character], _ message : inout StringReference) -> Bool{
	var valid : Bool

	if(Double(str.count) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0){

		if(cIsNumber(str[Int(0)]) && cIsNumber(str[Int(1)]) && cIsNumber(str[Int(2)]) && cIsNumber(str[Int(3)]) && cIsNumber(str[Int(5)]) && cIsNumber(str[Int(6)]) && cIsNumber(str[Int(8)]) && cIsNumber(str[Int(9)]) && cIsNumber(str[Int(11)]) && cIsNumber(str[Int(12)]) && cIsNumber(str[Int(14)]) && cIsNumber(str[Int(15)]) && cIsNumber(str[Int(17)]) && cIsNumber(str[Int(18)])){
			if(str[Int(4)] == "-" && str[Int(7)] == "-" && str[Int(10)] == "T" && str[Int(13)] == ":" && str[Int(16)] == ":"){
				valid = true
			}else{
				valid = false
				message.stringx = characterArray("ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("ISO8601 date must be exactly 19 characters long.").ca
	}

	return valid
}


func DateTimeEquals(_ a : inout DateTime, _ b : inout DateTime) -> Bool{
	return DateEquals(&a.date, &b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds
}


func FreeDateTime(_ datetime : inout DateTime) -> Void{
	delete(datetime.date)
	delete(datetime)
}


func CreateFixedPoint30d(_ digitsBeforeDecimalPoint : Double, _ digitsAfterDecimalPoint : Double) -> FixedPoint30dReferenceClass{
	var digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
	var digitsAfterDecimalPoint = digitsAfterDecimalPoint;
	var fp : FixedPoint30d

	fp = FixedPoint30d()
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.part1 = 0.0
	fp.part2 = 0.0

	var returnReference = FixedPoint30dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func CreateFixedPoint15d(_ digitsBeforeDecimalPoint : Double, _ digitsAfterDecimalPoint : Double) -> FixedPoint15dReferenceClass{
	var digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
	var digitsAfterDecimalPoint = digitsAfterDecimalPoint;
	var fp : FixedPoint15d

	fp = FixedPoint15d()
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.number = 0.0

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func ToNumber15d(_ n : inout FixedPoint15d) -> Double{
	return n.number
}


func Number15d(_ number : Double) -> FixedPoint15dReferenceClass{
	var number = number;
	var fp : FixedPoint15d

	fp = FixedPoint15d()
	fp.digitsBeforeDecimalPoint = 7.0
	fp.digitsAfterDecimalPoint = 7.0
	fp.number = number

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func Assign15d(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var success : Bool

	success = !WillOverflow15d(&fp, number)
	success = success && FixedPointIsValid15d(&fp)

	if(success){
		fp.number = number
		fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint)
	}

	return success
}


func Assign15dFloor(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var success : Bool

	success = !WillOverflow15d(&fp, number)
	success = success && FixedPointIsValid15d(&fp)

	if(success){
		fp.number = number
		fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint)
	}

	return success
}


func FixedPointIsValid15d(_ fp : inout FixedPoint15d) -> Bool{
	var valid : Bool

	if(IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)){
		if(fp.digitsBeforeDecimalPoint >= 0.0 && fp.digitsBeforeDecimalPoint <= 15.0){
			if(fp.digitsAfterDecimalPoint >= 0.0 && fp.digitsAfterDecimalPoint <= 15.0){
				if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15.0){
					if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0.0){
						valid = true
					}else{
						valid = false
					}
				}else{
					valid = false
				}
			}else{
				valid = false
			}
		}else{
			valid = false
		}
	}else{
		valid = false
	}

	return valid
}


func WillOverflow15d(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var overflow : Bool

	if(abs(number) < pow(10.0, fp.digitsBeforeDecimalPoint)){
		overflow = false
	}else{
		overflow = true
	}

	return overflow
}


func FloorToDigits(_ value : Double, _ digits : Double) -> Double{
	var value = value;
	var digits = digits;
	return floor(value*pow(10.0, digits))/pow(10.0, digits)
}


func ToString15d(_ fp : inout FixedPoint15d) -> [Character]{
	var stringx : [Character]
	var digits : Double
	var digitPosition : Double
	var i, d, decimalx : Double
	var characterReference : CharacterReference

	stringx = Array(repeating:Character(" "), count: Int(1.0 + fp.digitsBeforeDecimalPoint + 1.0 + fp.digitsAfterDecimalPoint))

	decimalx = fp.number*pow(10.0, fp.digitsAfterDecimalPoint)

	if(decimalx < 0.0){
		decimalx = -decimalx
		stringx[Int(0)] = "-"
	}else{
		stringx[Int(0)] = "+"
	}

	decimalx = Roundx(decimalx)

	characterReference = CharacterReference()

	digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint
	digitPosition = 1.0

	i = 0.0
	while(i < digits){
		if(i == fp.digitsBeforeDecimalPoint){
			stringx[Int(digitPosition)] = "."

			digitPosition = digitPosition + 1.0
		}

		d = floor(decimalx/pow(10.0, digits - i - 1.0))
		d = d.truncatingRemainder(dividingBy:10.0)

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, &characterReference)
		stringx[Int(digitPosition)] = characterReference.characterValue

		digitPosition = digitPosition + 1.0
		i = i + 1.0
	}

	delete(characterReference)

	return stringx
}


func Add15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number + c.number)
}


func Subtract15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number - c.number)
}


func Multiply15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number*c.number)
}


func DivideFloored15d(_ q : inout FixedPoint15d, _ r : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool
	var x, xDivisor, xDividend : Double
	var t : FixedPoint15d

	t = Copy15d(&r).ref

	if(b.number != 0.0){
		xDivisor = Roundx(a.number*pow(10.0, q.digitsAfterDecimalPoint)*pow(10.0, q.digitsAfterDecimalPoint))
		xDividend = Roundx(b.number*pow(10.0, q.digitsAfterDecimalPoint))
		x = floor(xDivisor/xDividend)
		x = x/pow(10.0, q.digitsAfterDecimalPoint)
		success = Assign15d(&q, x)
		Multiply15d(&t, &q, &b)
		Subtract15d(&r, &a, &t)
	}else{
		success = false
	}

	delete(t)

	return success
}


func Copy15d(_ r : inout FixedPoint15d) -> FixedPoint15dReferenceClass{
	var t : FixedPoint15d

	t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint).ref
	t.number = r.number

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = t
	return returnReference
}


func Negate15d(_ a : inout FixedPoint15d) -> Void{
	a.number = -a.number
}


func Positive15d(_ a : inout FixedPoint15d) -> Void{
	a.number = +a.number
}


func Factorial15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= 0.0){
		success = Assign15d(&x, Factorial(x.number))
	}else{
		success = false
	}

	return success
}


func Round15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Roundx(x.number))
}


func BankersRound15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, BankersRound(x.number))
}


func Ceil15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Ceil(x.number))
}


func Floor15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, floor(x.number))
}


func Truncate15d(_ x : inout FixedPoint15d) -> Void{
	x.number = Truncate(x.number)
}


func Absolute15d(_ x : inout FixedPoint15d) -> Void{
	x.number = abs(x.number)
}


func Logarithm15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number > 0.0){
		success = Assign15d(&x, Logarithm(x.number))
	}else{
		success = false
	}

	return success
}


func NaturalLogarithm15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number > 0.0){
		success = Assign15d(&x, NaturalLogarithm(x.number))
	}else{
		success = false
	}

	return success
}


func Sin15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Sinx(x.number))
}


func Cos15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Cosx(x.number))
}


func Tan15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Tanx(x.number))
}


func Asin15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= -1.0 && x.number <= 1.0){
		success = Assign15d(&x, Asinx(x.number))
	}else{
		success = false
	}

	return success
}


func Acos15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= -1.0 && x.number <= 1.0){
		success = Assign15d(&x, Acosx(x.number))
	}else{
		success = false
	}

	return success
}


func Atan15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Atanx(x.number))
}


func Atan2_15d(_ a : inout FixedPoint15d, _ y : inout FixedPoint15d, _ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, Atan2(y.number, x.number))
}


func Squareroot15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= 0.0){
		success = Assign15d(&x, sqrt(x.number))
	}else{
		success = false
	}

	return success
}


func Exp15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Expx(x.number))
}


func DivisibleBy15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return ((a.number.truncatingRemainder(dividingBy:b.number)) == 0.0)
}


func Combinations15d(_ x : inout FixedPoint15d, _ n : inout FixedPoint15d, _ k : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(n.number) && IsInteger(k.number)){
		if(n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number){
			success = Assign15d(&x, Combinations(n.number, k.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Permutations15d(_ x : inout FixedPoint15d, _ n : inout FixedPoint15d, _ k : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(n.number) && IsInteger(k.number)){
		if(n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number){
			success = Assign15d(&x, Permutations(n.number, k.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Equals15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var p, an, bn : Double
	var equals : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	p = max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint)

	equals = EpsilonCompare(an, bn, pow(10.0, -p))

	return equals
}


func GreaterThan15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	return an > bn
}


func LessThan15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	return an < bn
}


func GreaterThanOrEqual15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double
	var equal : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	equal = Equals15d(&a, &b)

	return an > bn || equal
}


func LessThanOrEqual15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double
	var equal : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	equal = Equals15d(&a, &b)

	return an < bn || equal
}


func EpsilonCompare15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ epsilon : inout FixedPoint15d) -> Bool{
	return EpsilonCompare(a.number, b.number, epsilon.number)
}


func GreatestCommonDivisor15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number >= 0.0 && b.number >= 0.0){
			success = Assign15d(&x, GreatestCommonDivisor(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func GCDWithSubtraction15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number >= 0.0 && b.number >= 0.0){
			success = Assign15d(&x, GCDWithSubtraction(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func IsInteger15d(_ a : inout FixedPoint15d) -> Bool{
	return IsInteger(a.number)
}


func LeastCommonMultiple15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number != 0.0 && b.number != 0.0){
			success = Assign15d(&x, LeastCommonMultiple(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Sign15d(_ a : inout FixedPoint15d) -> Double{
	return Sign(a.number)
}


func Max15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Max(a.number, b.number))
}


func Min15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Min(a.number, b.number))
}


func Power15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(a.number != 0.0 || b.number != 0.0){
		if(!(a.number < 0.0 && !IsInteger(b.number))){
			success = Assign15d(&x, Power(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func FormatToString15d(_ fp : inout FixedPoint15d, _ digitsAfter : Double) -> [Character]{
	var digitsAfter = digitsAfter;
	var result : [Character]

	result = FormatToStringWithSymbols15d(&fp, digitsAfter, &characterArray("").ca, &characterArray(".").ca)

	return result
}


func FormatToStringWithSymbols15d(_ fp : inout FixedPoint15d, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var digitsAfter = digitsAfter;
	var stringx : [Character]
	var i, j, p, d, t, sign, extra, decimalx, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars : Double
	var characterReference : CharacterReference

	characterReference = CharacterReference()

	decimalx = Roundx(fp.number*pow(10.0, digitsAfter))

	sign = 0.0
	if(decimalx < 0.0){
		sign = 1.0
		decimalx = -decimalx
	}

	if(decimalx != 0.0){
		digits = floor(log10(decimalx) + 1.0)
	}else{
		digits = 1.0
	}
	digitsBefore = digits - digitsAfter

	if(digitsBefore <= 0.0){
		digitsBefore = 0.0
		thousandsTimes = 0.0
		digits = digitsAfter + 1.0
	}else{
		thousandsTimes = floor((digitsBefore - 1.0)/3.0)
	}
	thousandsChars = thousandsTimes*Double(thousandsSeparator.count)

	if(digitsAfter == 0.0){
		decimalPointChars = 0.0
	}else{
		decimalPointChars = Double(decimalPoint.count)
	}

	stringx = Array(repeating:Character(" "), count: Int(sign + digits + thousandsChars + decimalPointChars))
	p = 0.0

	if(sign > 0.0){
		stringx[Int(p)] = "-"
		p = p + 1.0
	}

	i = 0.0
	while(i < digits){
		if(i == digitsBefore){
			if(i == 0.0){
				stringx[Int(p)] = "0"
				p = p + 1.0
				digits = digits - 1.0
			}

			j = 0.0
			while(j < Double(decimalPoint.count)){
				stringx[Int(p)] = decimalPoint[Int(j)]
				p = p + 1.0
				j = j + 1.0
			}
		}

		if(i < digitsBefore){
			if((digitsBefore - i).truncatingRemainder(dividingBy:3.0) == 0.0 && i != 0.0){
				j = 0.0
				while(j < Double(thousandsSeparator.count)){
					stringx[Int(p)] = thousandsSeparator[Int(j)]
					p = p + 1.0
					j = j + 1.0
				}
			}
		}

		d = floor(decimalx/pow(10.0, digits - i - 1.0))
		d = d.truncatingRemainder(dividingBy:10.0)

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, &characterReference)
		stringx[Int(p)] = characterReference.characterValue

		p = p + 1.0
		i = i + 1.0
	}

	/* System.out.println(new String(string));*/
	return stringx
}


func NumberToHumanReadable(_ n : Double, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var n = n;
	var digitsAfter = digitsAfter;
	var str : [Character]
	var u : Character
	var d, p3 : Double

	if(abs(n) < 1.0){
		str = CreateStringDecimalFromNumber(n)
	}else{
		d = log10(n)

		p3 = min(floor(d/3.0), 8.0)

		if(p3 == 0.0){
			u = "B"
		}else if(p3 == 1.0){
			u = "K"
		}else if(p3 == 2.0){
			u = "M"
		}else if(p3 == 3.0){
			u = "G"
		}else if(p3 == 4.0){
			u = "T"
		}else if(p3 == 5.0){
			u = "P"
		}else if(p3 == 6.0){
			u = "E"
		}else if(p3 == 7.0){
			u = "Z"
		}else{
			u = "Y"
		}

		if(p3 > 1.0){
			n = n/pow(10.0, p3*3.0)
		}

		str = FormatToStringWithSymbols15d(&Number15d(n).ref, digitsAfter, &thousandsSeparator, &decimalPoint)

		if(p3 > 1.0){
			str = strAppendCharacter(&str, u)
		}
	}

	return str
}


func NumberToHumanReadableBinaryPrefix(_ n : Double, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var n = n;
	var digitsAfter = digitsAfter;
	var str : [Character]
	var u : [Character]
	var d, p3 : Double

	if(abs(n) < 1.0){
		str = CreateStringDecimalFromNumber(n)
	}else{
		d = floor(log(n)/log(2.0)) + 1.0

		p3 = min(floor(d/10.0), 8.0)

		if(p3 == 0.0){
			u = characterArray("B").ca
		}else if(p3 == 1.0){
			u = characterArray("Ki").ca
		}else if(p3 == 2.0){
			u = characterArray("Mi").ca
		}else if(p3 == 3.0){
			u = characterArray("Gi").ca
		}else if(p3 == 4.0){
			u = characterArray("Ti").ca
		}else if(p3 == 5.0){
			u = characterArray("Pi").ca
		}else if(p3 == 6.0){
			u = characterArray("Ei").ca
		}else if(p3 == 7.0){
			u = characterArray("Zi").ca
		}else{
			u = characterArray("Yi").ca
		}

		if(p3 > 1.0){
			n = n/pow(2.0, p3*10.0)
		}

		str = FormatToStringWithSymbols15d(&Number15d(n).ref, digitsAfter, &thousandsSeparator, &decimalPoint)

		if(p3 > 1.0){
			str = strAppendString(&str, &u)
		}
	}

	return str
}


func AddNumber(_ list : inout [Double], _ a : Double) -> [Double]{
	var a = a;
	var newlist : [Double]
	var i : Double

	newlist = Array(repeating:Double(), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Void{
	var i = i;
	list.numberArray = AddNumber(&list.numberArray, i)
}


func RemoveNumber(_ list : inout [Double], _ n : Double) -> [Double]{
	var n = n;
	var newlist : [Double]
	var i : Double

	newlist = Array(repeating:Double(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Double{
	var i = i;
	return list.numberArray[Int(i)]
}


func RemoveNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Void{
	var i = i;
	list.numberArray = RemoveNumber(&list.numberArray, i)
}


func AddString(_ list : inout [StringReference], _ a : inout StringReference) -> [StringReference]{
	var newlist : [StringReference]
	var i : Double

	newlist = Array(repeating:StringReference(), count: Int(Double(list.count) + 1.0))

	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddStringRef(_ list : inout StringArrayReference, _ i : inout StringReference) -> Void{
	list.stringArray = AddString(&list.stringArray, &i)
}


func RemoveString(_ list : inout [StringReference], _ n : Double) -> [StringReference]{
	var n = n;
	var newlist : [StringReference]
	var i : Double

	newlist = Array(repeating:StringReference(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetStringRef(_ list : inout StringArrayReference, _ i : Double) -> StringReferenceReferenceClass{
	var i = i;
	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = list.stringArray[Int(i)]
	return returnReference
}


func RemoveStringRef(_ list : inout StringArrayReference, _ i : Double) -> Void{
	var i = i;
	list.stringArray = RemoveString(&list.stringArray, i)
}


func CreateDynamicArrayCharacters() -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = Array(repeating:Character(" "), count: Int(10))
	da.length = 0.0

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func CreateDynamicArrayCharactersWithInitialCapacity(_ capacity : Double) -> DynamicArrayCharactersReferenceClass{
	var capacity = capacity;
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = Array(repeating:Character(" "), count: Int(capacity))
	da.length = 0.0

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayAddCharacter(_ da : inout DynamicArrayCharacters, _ value : Character) -> Void{
	var value = value;
	if(da.length == Double(da.array.count)){
		DynamicArrayCharactersIncreaseSize(&da)
	}

	da.array[Int(da.length)] = value
	da.length = da.length + 1.0
}


func DynamicArrayAddString(_ da : inout DynamicArrayCharacters, _ str : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(str.count)){
		DynamicArrayAddCharacter(&da, str[Int(i)])
		i = i + 1.0
	}
}


func DynamicArrayCharactersIncreaseSize(_ da : inout DynamicArrayCharacters) -> Void{
	var newLength, i : Double
	var newArray : [Character]

	newLength = round(Double(da.array.count)*3.0/2.0)
	newArray = Array(repeating:Character(" "), count: Int(newLength))

	i = 0.0
	while(i < Double(da.array.count)){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayCharactersDecreaseSizeNecessary(_ da : inout DynamicArrayCharacters) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(da.length > 10.0){
		needsDecrease = da.length <= round(Double(da.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func DynamicArrayCharactersDecreaseSize(_ da : inout DynamicArrayCharacters) -> Void{
	var newLength, i : Double
	var newArray : [Character]

	newLength = round(Double(da.array.count)*2.0/3.0)
	newArray = Array(repeating:Character(" "), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayCharactersIndex(_ da : inout DynamicArrayCharacters, _ index : Double) -> Character{
	var index = index;
	return da.array[Int(index)]
}


func DynamicArrayCharactersLength(_ da : inout DynamicArrayCharacters) -> Double{
	return da.length
}


func DynamicArrayInsertCharacter(_ da : inout DynamicArrayCharacters, _ index : Double, _ value : Character) -> Void{
	var index = index;
	var value = value;
	var i : Double

	if(da.length == Double(da.array.count)){
		DynamicArrayCharactersIncreaseSize(&da)
	}

	i = da.length
	while(i > index){
		da.array[Int(i)] = da.array[Int(i - 1.0)]
		i = i - 1.0
	}

	da.array[Int(index)] = value

	da.length = da.length + 1.0
}


func DynamicArrayCharacterSet(_ da : inout DynamicArrayCharacters, _ index : Double, _ value : Character) -> Bool{
	var index = index;
	var value = value;
	var success : Bool

	if(index < da.length){
		da.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func DynamicArrayRemoveCharacter(_ da : inout DynamicArrayCharacters, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < da.length - 1.0){
		da.array[Int(i)] = da.array[Int(i + 1.0)]
		i = i + 1.0
	}

	da.length = da.length - 1.0

	if(DynamicArrayCharactersDecreaseSizeNecessary(&da)){
		DynamicArrayCharactersDecreaseSize(&da)
	}
}


func FreeDynamicArrayCharacters(_ da : inout DynamicArrayCharacters) -> Void{
	delete(da.array)
	delete(da)
}


func DynamicArrayCharactersToArray(_ da : inout DynamicArrayCharacters) -> [Character]{
	var array : [Character]
	var i : Double

	array = Array(repeating:Character(" "), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		array[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ArrayToDynamicArrayCharactersWithOptimalSize(_ array : inout [Character]) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters
	var i : Double
	var c, n, newCapacity : Double

	c = Double(array.count)
	n = (log(c) - 1.0)/log(3.0/2.0)
	newCapacity = ceil(10.0*pow(3.0/2.0, n))

	da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(array.count)){
		da.array[Int(i)] = array[Int(i)]
		i = i + 1.0
	}

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func ArrayToDynamicArrayCharacters(_ array : inout [Character]) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = arraysCopyString(&array)
	da.length = Double(array.count)

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayCharactersEqual(_ a : inout DynamicArrayCharacters, _ b : inout DynamicArrayCharacters) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(a.length == b.length){
		i = 0.0
		while(i < a.length && equal){
			if(a.array[Int(i)] != b.array[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func DynamicArrayCharactersToLinkedList(_ da : inout DynamicArrayCharacters) -> LinkedListCharactersReferenceClass{
	var ll : LinkedListCharacters
	var i : Double

	ll = CreateLinkedListCharacter().ref

	i = 0.0
	while(i < da.length){
		LinkedListAddCharacter(&ll, da.array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListToDynamicArrayCharacters(_ ll : inout LinkedListCharacters) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters
	var i : Double
	var node : LinkedListNodeCharacters

	node = ll.first

	da = DynamicArrayCharacters()
	da.length = LinkedListCharactersLength(&ll)

	da.array = Array(repeating:Character(" "), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		da.array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func AddBoolean(_ list : inout [Bool], _ a : Bool) -> [Bool]{
	var a = a;
	var newlist : [Bool]
	var i : Double

	newlist = Array(repeating:Bool(), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddBooleanRef(_ list : inout BooleanArrayReference, _ i : Bool) -> Void{
	var i = i;
	list.booleanArray = AddBoolean(&list.booleanArray, i)
}


func RemoveBoolean(_ list : inout [Bool], _ n : Double) -> [Bool]{
	var n = n;
	var newlist : [Bool]
	var i : Double

	newlist = Array(repeating:Bool(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetBooleanRef(_ list : inout BooleanArrayReference, _ i : Double) -> Bool{
	var i = i;
	return list.booleanArray[Int(i)]
}


func RemoveDecimalRef(_ list : inout BooleanArrayReference, _ i : Double) -> Void{
	var i = i;
	list.booleanArray = RemoveBoolean(&list.booleanArray, i)
}


func CreateLinkedListString() -> LinkedListStringsReferenceClass{
	var ll : LinkedListStrings

	ll = LinkedListStrings()
	ll.first = LinkedListNodeStrings()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListStringsReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListAddString(_ ll : inout LinkedListStrings, _ value : inout [Character]) -> Void{
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeStrings()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListStringsToArray(_ ll : inout LinkedListStrings) -> [StringReference]{
	var array : [StringReference]
	var length, i : Double
	var node : LinkedListNodeStrings

	node = ll.first

	length = LinkedListStringsLength(&ll)

	array = Array(repeating:StringReference(), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = StringReference()
		array[Int(i)].stringx = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func LinkedListStringsLength(_ ll : inout LinkedListStrings) -> Double{
	var l : Double
	var node : LinkedListNodeStrings

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func FreeLinkedListString(_ ll : inout LinkedListStrings) -> Void{
	var node, prev : LinkedListNodeStrings

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func LinkedListInsertString(_ ll : inout LinkedListStrings, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var i : Double
	var node, tmp : LinkedListNodeStrings

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeStrings()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeStrings()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func CreateLinkedListNumbers() -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers

	ll = LinkedListNumbers()
	ll.first = LinkedListNodeNumbers()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func CreateLinkedListNumbersArray(_ length : Double) -> [LinkedListNumbers]{
	var length = length;
	var lls : [LinkedListNumbers]
	var i : Double

	lls = Array(repeating:LinkedListNumbers(), count: Int(length))
	i = 0.0
	while(i < Double(lls.count)){
		lls[Int(i)] = CreateLinkedListNumbers().ref
		i = i + 1.0
	}

	return lls
}


func LinkedListAddNumber(_ ll : inout LinkedListNumbers, _ value : Double) -> Void{
	var value = value;
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeNumbers()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListNumbersLength(_ ll : inout LinkedListNumbers) -> Double{
	var l : Double
	var node : LinkedListNodeNumbers

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func LinkedListNumbersIndex(_ ll : inout LinkedListNumbers, _ index : Double) -> Double{
	var index = index;
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first
	i = 0.0
	while(i < index){
		node = node.next
		i = i + 1.0
	}

	return node.value
}


func LinkedListInsertNumber(_ ll : inout LinkedListNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node, tmp : LinkedListNodeNumbers

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeNumbers()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeNumbers()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func LinkedListSet(_ ll : inout LinkedListNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first
	i = 0.0
	while(i < index){
		node = node.next
		i = i + 1.0
	}

	node.next.value = value
}


func LinkedListRemoveNumber(_ ll : inout LinkedListNumbers, _ index : Double) -> Void{
	var index = index;
	var i : Double
	var node, prev : LinkedListNodeNumbers

	node = ll.first
	prev = ll.first

	i = 0.0
	while(i < index){
		prev = node
		node = node.next
		i = i + 1.0
	}

	if(index == 0.0){
		ll.first = prev.next
	}
	if(!prev.next.end){
		prev.next = prev.next.next
	}
}


func FreeLinkedListNumbers(_ ll : inout LinkedListNumbers) -> Void{
	var node, prev : LinkedListNodeNumbers

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func FreeLinkedListNumbersArray(_ lls : inout [LinkedListNumbers]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(lls.count)){
		FreeLinkedListNumbers(&lls[Int(i)])
		i = i + 1.0
	}
	delete(lls)
}


func LinkedListNumbersToArray(_ ll : inout LinkedListNumbers) -> [Double]{
	var array : [Double]
	var length, i : Double
	var node : LinkedListNodeNumbers

	node = ll.first

	length = LinkedListNumbersLength(&ll)

	array = Array(repeating:Double(), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func ArrayToLinkedListNumbers(_ array : inout [Double]) -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers
	var i : Double

	ll = CreateLinkedListNumbers().ref

	i = 0.0
	while(i < Double(array.count)){
		LinkedListAddNumber(&ll, array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListNumbersEqual(_ a : inout LinkedListNumbers, _ b : inout LinkedListNumbers) -> Bool{
	var equal, done : Bool
	var an, bn : LinkedListNodeNumbers

	an = a.first
	bn = b.first

	equal = true
	done = false
	while(equal && !done){
		if(an.end == bn.end){
			if(an.end){
				done = true
			}else if(an.value == bn.value){
				an = an.next
				bn = bn.next
			}else{
				equal = false
			}
		}else{
			equal = false
		}
	}

	return equal
}


func CreateLinkedListCharacter() -> LinkedListCharactersReferenceClass{
	var ll : LinkedListCharacters

	ll = LinkedListCharacters()
	ll.first = LinkedListNodeCharacters()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListAddCharacter(_ ll : inout LinkedListCharacters, _ value : Character) -> Void{
	var value = value;
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeCharacters()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListCharactersToArray(_ ll : inout LinkedListCharacters) -> [Character]{
	var array : [Character]
	var length, i : Double
	var node : LinkedListNodeCharacters

	node = ll.first

	length = LinkedListCharactersLength(&ll)

	array = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func LinkedListCharactersLength(_ ll : inout LinkedListCharacters) -> Double{
	var l : Double
	var node : LinkedListNodeCharacters

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func FreeLinkedListCharacter(_ ll : inout LinkedListCharacters) -> Void{
	var node, prev : LinkedListNodeCharacters

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func LinkedListCharactersAddString(_ ll : inout LinkedListCharacters, _ str : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(str.count)){
		LinkedListAddCharacter(&ll, str[Int(i)])
		i = i + 1.0
	}
}


func LinkedListInsertCharacter(_ ll : inout LinkedListCharacters, _ index : Double, _ value : Character) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node, tmp : LinkedListNodeCharacters

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeCharacters()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeCharacters()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func CreateDynamicArrayNumbers() -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = Array(repeating:Double(), count: Int(10))
	da.length = 0.0

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func CreateDynamicArrayNumbersWithInitialCapacity(_ capacity : Double) -> DynamicArrayNumbersReferenceClass{
	var capacity = capacity;
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = Array(repeating:Double(), count: Int(capacity))
	da.length = 0.0

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayAddNumber(_ da : inout DynamicArrayNumbers, _ value : Double) -> Void{
	var value = value;
	if(da.length == Double(da.array.count)){
		DynamicArrayNumbersIncreaseSize(&da)
	}

	da.array[Int(da.length)] = value
	da.length = da.length + 1.0
}


func DynamicArrayNumbersIncreaseSize(_ da : inout DynamicArrayNumbers) -> Void{
	var newLength, i : Double
	var newArray : [Double]

	newLength = round(Double(da.array.count)*3.0/2.0)
	newArray = Array(repeating:Double(), count: Int(newLength))

	i = 0.0
	while(i < Double(da.array.count)){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayNumbersDecreaseSizeNecessary(_ da : inout DynamicArrayNumbers) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(da.length > 10.0){
		needsDecrease = da.length <= round(Double(da.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func DynamicArrayNumbersDecreaseSize(_ da : inout DynamicArrayNumbers) -> Void{
	var newLength, i : Double
	var newArray : [Double]

	newLength = round(Double(da.array.count)*2.0/3.0)
	newArray = Array(repeating:Double(), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayNumbersIndex(_ da : inout DynamicArrayNumbers, _ index : Double) -> Double{
	var index = index;
	return da.array[Int(index)]
}


func DynamicArrayNumbersLength(_ da : inout DynamicArrayNumbers) -> Double{
	return da.length
}


func DynamicArrayInsertNumber(_ da : inout DynamicArrayNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double

	if(da.length == Double(da.array.count)){
		DynamicArrayNumbersIncreaseSize(&da)
	}

	i = da.length
	while(i > index){
		da.array[Int(i)] = da.array[Int(i - 1.0)]
		i = i - 1.0
	}

	da.array[Int(index)] = value

	da.length = da.length + 1.0
}


func DynamicArrayNumberSet(_ da : inout DynamicArrayNumbers, _ index : Double, _ value : Double) -> Bool{
	var index = index;
	var value = value;
	var success : Bool

	if(index < da.length){
		da.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func DynamicArrayRemoveNumber(_ da : inout DynamicArrayNumbers, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < da.length - 1.0){
		da.array[Int(i)] = da.array[Int(i + 1.0)]
		i = i + 1.0
	}

	da.length = da.length - 1.0

	if(DynamicArrayNumbersDecreaseSizeNecessary(&da)){
		DynamicArrayNumbersDecreaseSize(&da)
	}
}


func FreeDynamicArrayNumbers(_ da : inout DynamicArrayNumbers) -> Void{
	delete(da.array)
	delete(da)
}


func DynamicArrayNumbersToArray(_ da : inout DynamicArrayNumbers) -> [Double]{
	var array : [Double]
	var i : Double

	array = Array(repeating:Double(), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		array[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ArrayToDynamicArrayNumbersWithOptimalSize(_ array : inout [Double]) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers
	var i : Double
	var c, n, newCapacity : Double

	/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */
	c = Double(array.count)
	n = (log(c) - 1.0)/log(3.0/2.0)
	newCapacity = ceil(10.0*pow(3.0/2.0, n))

	da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(array.count)){
		da.array[Int(i)] = array[Int(i)]
		i = i + 1.0
	}

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func ArrayToDynamicArrayNumbers(_ array : inout [Double]) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = arraysCopyNumberArray(&array)
	da.length = Double(array.count)

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayNumbersEqual(_ a : inout DynamicArrayNumbers, _ b : inout DynamicArrayNumbers) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(a.length == b.length){
		i = 0.0
		while(i < a.length && equal){
			if(a.array[Int(i)] != b.array[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func DynamicArrayNumbersToLinkedList(_ da : inout DynamicArrayNumbers) -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers
	var i : Double

	ll = CreateLinkedListNumbers().ref

	i = 0.0
	while(i < da.length){
		LinkedListAddNumber(&ll, da.array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListToDynamicArrayNumbers(_ ll : inout LinkedListNumbers) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first

	da = DynamicArrayNumbers()
	da.length = LinkedListNumbersLength(&ll)

	da.array = Array(repeating:Double(), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		da.array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayNumbersIndexOf(_ arr : inout DynamicArrayNumbers, _ n : Double, _ foundReference : inout BooleanReference) -> Double{
	var n = n;
	var found : Bool
	var i : Double

	found = false
	i = 0.0
	while(i < arr.length && !found){
		if(arr.array[Int(i)] == n){
			found = true
		}
		i = i + 1.0
	}
	if(!found){
		i = -1.0
	}else{
		i = i - 1.0
	}

	foundReference.booleanValue = found

	return i
}


func DynamicArrayNumbersIsInArray(_ arr : inout DynamicArrayNumbers, _ n : Double) -> Bool{
	var n = n;
	var found : Bool
	var i : Double

	found = false
	i = 0.0
	while(i < arr.length && !found){
		if(arr.array[Int(i)] == n){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func AddCharacter(_ list : inout [Character], _ a : Character) -> [Character]{
	var a = a;
	var newlist : [Character]
	var i : Double

	newlist = Array(repeating:Character(" "), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddCharacterRef(_ list : inout StringReference, _ i : Character) -> Void{
	var i = i;
	list.stringx = AddCharacter(&list.stringx, i)
}


func RemoveCharacter(_ list : inout [Character], _ n : Double) -> [Character]{
	var n = n;
	var newlist : [Character]
	var i : Double

	newlist = Array(repeating:Character(" "), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}

	return newlist
}


func GetCharacterRef(_ list : inout StringReference, _ i : Double) -> Character{
	var i = i;
	return list.stringx[Int(i)]
}


func RemoveCharacterRef(_ list : inout StringReference, _ i : Double) -> Void{
	var i = i;
	list.stringx = RemoveCharacter(&list.stringx, i)
}


func GetAccrualAmount(_ total : Double, _ fromYear : Double, _ fromMonth : Double, _ fromDay : Double, _ toYear : Double, _ toMonth : Double, _ toDay : Double, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var total = total;
	var fromYear = fromYear;
	var fromMonth = fromMonth;
	var fromDay = fromDay;
	var toYear = toYear;
	var toMonth = toMonth;
	var toDay = toDay;
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var from, to : Date
	var amount : Double

	from = CreateDate(fromYear, fromMonth, fromDay).ref
	to = CreateDate(toYear, toMonth, toDay).ref

	amount = GetAccrualAmountWithDates(total, &from, &to, yearOfInterest, monthOfInterest)

	return amount
}


func GetAccruals(_ total : Double, _ fromYear : Double, _ fromMonth : Double, _ fromDay : Double, _ toYear : Double, _ toMonth : Double, _ toDay : Double) -> [Double]{
	var total = total;
	var fromYear = fromYear;
	var fromMonth = fromMonth;
	var fromDay = fromDay;
	var toYear = toYear;
	var toMonth = toMonth;
	var toDay = toDay;
	var from, to : Date
	var amounts : [Double]

	from = CreateDate(fromYear, fromMonth, fromDay).ref
	to = CreateDate(toYear, toMonth, toDay).ref

	amounts = GetAccrualsWithDates(total, &from, &to)

	return amounts
}


func GetAccrualsWithDates(_ total : Double, _ from : inout Date, _ to : inout Date) -> [Double]{
	var total = total;
	var entry : Double
	var done, success : Bool
	var dateOfInterest : Date
	var list : LinkedListNumbers
	var result : [Double]
	var message : StringReference

	list = CreateLinkedListNumbers().ref
	message = StringReference()

	done = false
	dateOfInterest = Date()
	AssignDate(&dateOfInterest, &from)
	while(!done){
		if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
			done = true
		}

		entry = GetAccrualAmountWithDates(total, &from, &to, dateOfInterest.year, dateOfInterest.month)
		LinkedListAddNumber(&list, entry)
		success = AddMonthsToDate(&dateOfInterest, 1.0, &message)
	}

	result = LinkedListNumbersToArray(&list)
	FreeLinkedListNumbers(&list)

	return result
}


func GetAccrualAmountWithDates(_ total : Double, _ from : inout Date, _ to : inout Date, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var total = total;
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var unadjustedAmount, adjustment, days, daysToAdjust, n : Double
	var adjustTo : Date
	var valuePerDay, divisibleRemaining, divisibleTotal, amount : FixedPoint15d
	var message : StringReference

	message = StringReference()

	valuePerDay = CreateFixedPoint15d(13.0, 2.0).ref
	divisibleRemaining = CreateFixedPoint15d(13.0, 2.0).ref
	divisibleTotal = CreateFixedPoint15d(13.0, 2.0).ref
	amount = CreateFixedPoint15d(13.0, 2.0).ref

	days = DaysBetweenDates(&from, &to) + 1.0

	/* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining*/
	DivideFloored15d(&valuePerDay, &divisibleRemaining, &Number15d(total).ref, &Number15d(days).ref)

	Multiply15d(&divisibleTotal, &valuePerDay, &Number15d(days).ref)
	unadjustedAmount = GetUnadjustedAccrualAmountWithDates(&divisibleTotal, &from, &to, yearOfInterest, monthOfInterest)

	if(!Equals15d(&divisibleRemaining, &Number15d(0.0).ref)){
		daysToAdjust = Roundx(ToNumber15d(&divisibleRemaining)*100.0)
		adjustTo = Date()
		AssignDate(&adjustTo, &from)
		AddDaysToDate(&adjustTo, daysToAdjust - 1.0, &message)

		adjustment = GetUnadjustedAccrualAmountWithDates(&divisibleRemaining, &from, &adjustTo, yearOfInterest, monthOfInterest)

		delete(adjustTo)
	}else{
		adjustment = 0.0
	}

	Add15d(&amount, &Number15d(unadjustedAmount).ref, &Number15d(adjustment).ref)

	n = ToNumber15d(&amount)

	delete(valuePerDay)
	delete(divisibleRemaining)
	delete(divisibleTotal)
	delete(amount)

	return n
}


func GetUnadjustedAccrualAmountWithDates(_ total : inout FixedPoint15d, _ from : inout Date, _ to : inout Date, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var days, daysInMonthOfInterest, n : Double
	var lastDayInMonth, firstDateInMonth : Date
	var daysInMonth : [Double]
	var valuePerDay, value, remainder : FixedPoint15d
	var success : Bool

	value = CreateFixedPoint15d(13.0, 2.0).ref
	valuePerDay = CreateFixedPoint15d(13.0, 2.0).ref
	remainder = CreateFixedPoint15d(13.0, 2.0).ref

	days = DaysBetweenDates(&from, &to) + 1.0
	/* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...*/
	success = DivideFloored15d(&valuePerDay, &remainder, &total, &Number15d(days).ref)

	if(success){
		daysInMonth = GetDaysInMonth(yearOfInterest)

		if(yearOfInterest < from.year){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest == from.year && monthOfInterest < from.month){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest > to.year){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest == to.year && monthOfInterest > to.month){
			Assign15d(&value, 0.0)
		}else{
if(from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
				daysInMonthOfInterest = days
			}else if(from.year == yearOfInterest && from.month == monthOfInterest){
				lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[Int(monthOfInterest)]).ref
				daysInMonthOfInterest = DaysBetweenDates(&from, &lastDayInMonth) + 1.0
			}else if(to.year == yearOfInterest && to.month == monthOfInterest){
				firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0).ref
				daysInMonthOfInterest = DaysBetweenDates(&firstDateInMonth, &to) + 1.0
			}else{
				daysInMonthOfInterest = daysInMonth[Int(monthOfInterest)]
			}

			/* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value*/
			Multiply15d(&value, &valuePerDay, &Number15d(daysInMonthOfInterest).ref)
		}

		delete(daysInMonth)
	}

	n = ToNumber15d(&value)

	delete(value)
	delete(valuePerDay)
	delete(remainder)

	return n
}


func CreateNewArrayData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isArray = true
	data.isStruture = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.array = CreateArray().ref

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateNewStructData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.structure = CreateStructure().ref

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStructure() -> StructureReferenceClass{
	var st : Structure

	st = Structure()
	st.keys = CreateArray().ref
	st.values = CreateArray().ref

	var returnReference = StructureReferenceClass()
	returnReference.ref = st
	return returnReference
}


func CreateNumberData(_ n : Double) -> DataReferenceClass{
	var n = n;
	var data : Data

	data = Data()
	data.isNumber = true
	data.isStruture = false
	data.isArray = false
	data.isBoolean = false
	data.isString = false
	data.number = n

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateBooleanData(_ b : Bool) -> DataReferenceClass{
	var b = b;
	var data : Data

	data = Data()
	data.isBoolean = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isString = false
	data.booleanx = b

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStringData(_ stringx : inout [Character]) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.stringx = stringx

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStructData(_ structure : inout Structure) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = false
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.structure = structure

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateArrayData(_ array : inout Arrayx) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = false
	data.isStruture = false
	data.isArray = true
	data.isNumber = false
	data.isBoolean = false
	data.array = array

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateNoTypeData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func AddStructToArray(_ ar : inout Arrayx, _ st : inout Structure) -> Void{
	var data : Data

	data = CreateNewStructData().ref
	delete(data.structure)
	data.structure = st

	ArrayAdd(&ar, &data)
}


func AddArrayToArray(_ ar : inout Arrayx, _ ar2 : inout Arrayx) -> Void{
	var data : Data

	data = CreateNewArrayData().ref
	delete(data.array)
	data.array = ar2

	ArrayAdd(&ar, &data)
}


func AddNumberToArray(_ ar : inout Arrayx, _ n : Double) -> Void{
	var n = n;
	ArrayAdd(&ar, &CreateNumberData(n).ref)
}


func AddBooleanToArray(_ ar : inout Arrayx, _ b : Bool) -> Void{
	var b = b;
	ArrayAdd(&ar, &CreateBooleanData(b).ref)
}


func AddStringToArray(_ ar : inout Arrayx, _ str : inout [Character]) -> Void{
	ArrayAdd(&ar, &CreateStringData(&str).ref)
}


func AddDataToArray(_ ar : inout Arrayx, _ data : inout Data) -> Void{
	ArrayAdd(&ar, &data)
}


func StructKeys(_ st : inout Structure) -> Double{
	return ArrayLength(&st.keys)
}


func StructHasKey(_ st : inout Structure, _ key : inout [Character]) -> Bool{
	var i : Double
	var hasKey : Bool

	hasKey = false
	i = 0.0
	while(i < StructKeys(&st)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			hasKey = true
		}
		i = i + 1.0
	}

	return hasKey
}


func StructKeyIndex(_ st : inout Structure, _ key : inout [Character]) -> Double{
	var i : Double
	var index : Double

	index = -1.0
	i = 0.0
	while(i < StructKeys(&st)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			index = i
		}
		i = i + 1.0
	}

	return index
}


func GetStructKeys(_ st : inout Structure) -> [StringReference]{
	var keys : [StringReference]
	var nr, i : Double

	nr = StructKeys(&st)

	keys = Array(repeating:StringReference(), count: Int(nr))

	i = 0.0
	while(i < nr){
		keys[Int(i)] = StringReference()
		keys[Int(i)].stringx = arraysCopyString(&st.keys.array[Int(i)].stringx)
		i = i + 1.0
	}

	return keys
}


func GetStructFromStruct(_ st : inout Structure, _ key : inout [Character]) -> StructureReferenceClass{
	var i : Double
	var r : Structure

	r = Structure()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].structure
		}
		i = i + 1.0
	}

	var returnReference = StructureReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetArrayFromStruct(_ st : inout Structure, _ key : inout [Character]) -> ArrayxReferenceClass{
	var i : Double
	var r : Arrayx

	r = Arrayx()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].array
		}
		i = i + 1.0
	}

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetNumberFromStruct(_ st : inout Structure, _ key : inout [Character]) -> Double{
	var i, r : Double

	r = 0.0
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].number
		}
		i = i + 1.0
	}

	return r
}


func GetBooleanFromStruct(_ st : inout Structure, _ key : inout [Character]) -> Bool{
	var i : Double
	var r : Bool

	r = false
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].booleanx
		}
		i = i + 1.0
	}

	return r
}


func GetStringFromStruct(_ st : inout Structure, _ key : inout [Character]) -> [Character]{
	var i : Double
	var r : [Character]

	r = characterArray("").ca
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].stringx
		}
		i = i + 1.0
	}

	return r
}


func GetDataFromStruct(_ st : inout Structure, _ key : inout [Character]) -> DataReferenceClass{
	var i : Double
	var r : Data

	r = Data()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			delete(r)
			r = st.values.array[Int(i)]
		}
		i = i + 1.0
	}

	var returnReference = DataReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetDataFromStructWithCheck(_ st : inout Structure, _ key : inout [Character], _ foundRef : inout BooleanReference) -> DataReferenceClass{
	var i : Double
	var r : Data

	r = Data()
	foundRef.booleanValue = false
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			delete(r)
			foundRef.booleanValue = true
			r = st.values.array[Int(i)]
		}
		i = i + 1.0
	}

	var returnReference = DataReferenceClass()
	returnReference.ref = r
	return returnReference
}


func AddStructToStruct(_ st : inout Structure, _ key : inout [Character], _ structx : inout Structure) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].structure)
		st.values.array[Int(i)].structure = structx
	}else{
		AddStringToArray(&st.keys, &key)
		AddStructToArray(&st.values, &structx)
	}
}


func AddArrayToStruct(_ st : inout Structure, _ key : inout [Character], _ ar : inout Arrayx) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].array)
		st.values.array[Int(i)].array = ar
	}else{
		AddStringToArray(&st.keys, &key)
		AddArrayToArray(&st.values, &ar)
	}
}


func AddNumberToStruct(_ st : inout Structure, _ key : inout [Character], _ n : Double) -> Void{
	var n = n;
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		st.values.array[Int(i)].number = n
	}else{
		AddStringToArray(&st.keys, &key)
		AddNumberToArray(&st.values, n)
	}
}


func AddBooleanToStruct(_ st : inout Structure, _ key : inout [Character], _ b : Bool) -> Void{
	var b = b;
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		st.values.array[Int(i)].booleanx = b
	}else{
		AddStringToArray(&st.keys, &key)
		AddBooleanToArray(&st.values, b)
	}
}


func AddStringToStruct(_ st : inout Structure, _ key : inout [Character], _ value : inout [Character]) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].stringx)
		st.values.array[Int(i)].stringx = value
	}else{
		AddStringToArray(&st.keys, &key)
		AddStringToArray(&st.values, &value)
	}
}


func AddDataToStruct(_ st : inout Structure, _ key : inout [Character], _ data : inout Data) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		FreeData(&st.values.array[Int(i)])
		st.values.array[Int(i)] = data
	}else{
		AddStringToArray(&st.keys, &key)
		AddDataToArray(&st.values, &data)
	}
}


func FreeData(_ data : inout Data) -> Void{
	var i : Double
	var st : Structure

	if(data.isStruture){
		st = data.structure
		i = 0.0
		while(i < StructKeys(&st)){
			FreeData(&ArrayIndex(&st.keys, i).ref)
			FreeData(&ArrayIndex(&st.values, i).ref)
			i = i + 1.0
		}
		delete(st)
	}else if(data.isArray){
		FreeArray(&data.array)
	}

	delete(data)
}


func FreeArray(_ array : inout Arrayx) -> Void{
	var i : Double

	i = 0.0
	while(i < ArrayLength(&array)){
		FreeData(&array.array[Int(i)])
		i = i + 1.0
	}

	delete(array.array)
	delete(array)
}


func DataTypeEquals(_ a : inout Data, _ b : inout Data) -> Bool{
	var equal : Bool

	equal = true
	equal = equal && a.isStruture == b.isStruture
	equal = equal && a.isArray == b.isArray
	equal = equal && a.isNumber == b.isNumber
	equal = equal && a.isBoolean == b.isBoolean
	equal = equal && a.isString == b.isString

	return equal
}


func IsStructure(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isStruture
	if(a.isArray || a.isNumber || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsArray(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isArray
	if(a.isStruture || a.isNumber || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsNumber(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isNumber
	if(a.isStruture || a.isArray || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsBoolean(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isBoolean
	if(a.isStruture || a.isArray || a.isNumber || a.isString){
		itis = false
	}

	return itis
}


func IsString(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isString
	if(a.isStruture || a.isArray || a.isNumber || a.isBoolean){
		itis = false
	}

	return itis
}


func IsNoType(_ a : inout Data) -> Bool{
	var itis : Bool

	if(!a.isString && !a.isStruture && !a.isArray && !a.isNumber && !a.isBoolean){
		itis = true
	}else{
		itis = false
	}

	return itis
}


func CreateArray() -> ArrayxReferenceClass{
	var array : Arrayx

	array = Arrayx()
	array.array = Array(repeating:Data(), count: Int(10))
	array.length = 0.0

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array
	return returnReference
}


func CreateArrayWithInitialCapacity(_ capacity : Double) -> ArrayxReferenceClass{
	var capacity = capacity;
	var array : Arrayx

	array = Arrayx()
	array.array = Array(repeating:Data(), count: Int(capacity))
	array.length = 0.0

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array
	return returnReference
}


func ArrayAdd(_ array : inout Arrayx, _ value : inout Data) -> Void{
	if(array.length == Double(array.array.count)){
		ArrayIncreaseSize(&array)
	}

	array.array[Int(array.length)] = value
	array.length = array.length + 1.0
}


func ArrayAddString(_ array : inout Arrayx, _ value : inout [Character]) -> Void{
	var data : Data

	data = CreateStringData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddBoolean(_ array : inout Arrayx, _ value : Bool) -> Void{
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddNumber(_ array : inout Arrayx, _ value : Double) -> Void{
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddStruct(_ array : inout Arrayx, _ value : inout Structure) -> Void{
	var data : Data

	data = CreateStructData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddArray(_ array : inout Arrayx, _ value : inout Arrayx) -> Void{
	var data : Data

	data = CreateArrayData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayIncreaseSize(_ array : inout Arrayx) -> Void{
	var newLength, i : Double
	var newArray : [Data]

	newLength = round(Double(array.array.count)*3.0/2.0)
	newArray = Array(repeating:Data(), count: Int(newLength))

	i = 0.0
	while(i < Double(array.array.count)){
		newArray[Int(i)] = array.array[Int(i)]
		i = i + 1.0
	}

	delete(array.array)

	array.array = newArray
}


func ArrayDecreaseSizeNecessary(_ array : inout Arrayx) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(array.length > 10.0){
		needsDecrease = array.length <= round(Double(array.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func ArrayDecreaseSize(_ array : inout Arrayx) -> Void{
	var newLength, i : Double
	var newArray : [Data]

	newLength = round(Double(array.array.count)*2.0/3.0)
	newArray = Array(repeating:Data(), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = array.array[Int(i)]
		i = i + 1.0
	}

	delete(array.array)

	array.array = newArray
}


func ArrayIndex(_ array : inout Arrayx, _ index : Double) -> DataReferenceClass{
	var index = index;
	var returnReference = DataReferenceClass()
	returnReference.ref = array.array[Int(index)]
	return returnReference
}


func ArrayIndexArray(_ array : inout Arrayx, _ index : Double) -> ArrayxReferenceClass{
	var index = index;
	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array.array[Int(index)].array
	return returnReference
}


func ArrayIndexStruct(_ array : inout Arrayx, _ index : Double) -> StructureReferenceClass{
	var index = index;
	var returnReference = StructureReferenceClass()
	returnReference.ref = array.array[Int(index)].structure
	return returnReference
}


func ArrayIndexBoolean(_ array : inout Arrayx, _ index : Double) -> Bool{
	var index = index;
	return array.array[Int(index)].booleanx
}


func ArrayIndexString(_ array : inout Arrayx, _ index : Double) -> [Character]{
	var index = index;
	return array.array[Int(index)].stringx
}


func ArrayIndexNumber(_ array : inout Arrayx, _ index : Double) -> Double{
	var index = index;
	return array.array[Int(index)].number
}


func ArrayLength(_ array : inout Arrayx) -> Double{
	return array.length
}


func ArrayInsert(_ array : inout Arrayx, _ index : Double, _ value : inout Data) -> Void{
	var index = index;
	var i : Double

	if(array.length == Double(array.array.count)){
		ArrayIncreaseSize(&array)
	}

	i = array.length
	while(i > index){
		array.array[Int(i)] = array.array[Int(i - 1.0)]
		i = i - 1.0
	}

	array.array[Int(index)] = value

	array.length = array.length + 1.0
}


func ArrayInsertString(_ array : inout Arrayx, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var data : Data

	data = CreateStringData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertBoolean(_ array : inout Arrayx, _ index : Double, _ value : Bool) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertNumber(_ array : inout Arrayx, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertStruct(_ array : inout Arrayx, _ index : Double, _ value : inout Structure) -> Void{
	var index = index;
	var data : Data

	data = CreateStructData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertArray(_ array : inout Arrayx, _ index : Double, _ value : inout Arrayx) -> Void{
	var index = index;
	var data : Data

	data = CreateArrayData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArraySet(_ array : inout Arrayx, _ index : Double, _ value : inout Data) -> Bool{
	var index = index;
	var success : Bool

	if(index < array.length){
		array.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func ArraySetString(_ array : inout Arrayx, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var data : Data

	data = CreateStringData(&value).ref

	ArraySet(&array, index, &data)
}


func ArraySetBoolean(_ array : inout Arrayx, _ index : Double, _ value : Bool) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArraySet(&array, index, &data)
}


func ArraySetNumber(_ array : inout Arrayx, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArraySet(&array, index, &data)
}


func ArraySetStruct(_ array : inout Arrayx, _ index : Double, _ value : inout Structure) -> Void{
	var index = index;
	var data : Data

	data = CreateStructData(&value).ref

	ArraySet(&array, index, &data)
}


func ArraySetArray(_ array : inout Arrayx, _ index : Double, _ value : inout Arrayx) -> Void{
	var index = index;
	var data : Data

	data = CreateArrayData(&value).ref

	ArraySet(&array, index, &data)
}


func ArrayRemove(_ array : inout Arrayx, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < array.length - 1.0){
		array.array[Int(i)] = array.array[Int(i + 1.0)]
		i = i + 1.0
	}

	array.length = array.length - 1.0

	if(ArrayDecreaseSizeNecessary(&array)){
		ArrayDecreaseSize(&array)
	}
}


func ToStaticArray(_ arc : inout Arrayx) -> [Data]{
	var array : [Data]
	var i : Double

	array = Array(repeating:Data(), count: Int(arc.length))

	i = 0.0
	while(i < arc.length){
		array[Int(i)] = arc.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ToStaticNumberArray(_ array : inout Arrayx) -> [Double]{
	var result : [Double]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.number
		i = i + 1.0
	}

	return result
}


func ToStaticBooleanArray(_ array : inout Arrayx) -> [Bool]{
	var result : [Bool]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Bool(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.booleanx
		i = i + 1.0
	}

	return result
}


func ToStaticStringArray(_ array : inout Arrayx) -> [StringReference]{
	var result : [StringReference]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:StringReference(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = StringReference()
		result[Int(i)].stringx = ArrayIndex(&array, i).ref.stringx
		i = i + 1.0
	}

	return result
}


func ToStaticArrayArray(_ array : inout Arrayx) -> [Arrayx]{
	var result : [Arrayx]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Arrayx(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.array
		i = i + 1.0
	}

	return result
}


func ToStaticStructArray(_ array : inout Arrayx) -> [Structure]{
	var result : [Structure]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Structure(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.structure
		i = i + 1.0
	}

	return result
}


func StaticArrayToArrayWithOptimalSize(_ src : inout [Data]) -> ArrayxReferenceClass{
	var dst : Arrayx
	var i : Double
	var c, n, newCapacity : Double

	/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */

	c = Double(src.count)
	n = (log(c) - 1.0)/log(3.0/2.0)

	newCapacity = ceil(10.0*pow(3.0/2.0, ceil(n)))

	dst = CreateArrayWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(src.count)){
		dst.array[Int(i)] = src[Int(i)]
		i = i + 1.0
	}

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func StaticArrayToArray(_ src : inout [Data]) -> ArrayxReferenceClass{
	var i : Double
	var dst : Arrayx

	dst = CreateArrayWithInitialCapacity(Double(src.count)).ref
	i = 0.0
	while(i < Double(src.count)){
		dst.array[Int(i)] = src[Int(i)]
		i = i + 1.0
	}
	dst.length = Double(src.count)

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func ArrayAddAll(_ backups : inout Arrayx, _ from : inout Arrayx) -> Void{
	var i : Double
	var data : Data

	i = 0.0
	while(i < ArrayLength(&from)){
		data = ArrayIndex(&from, i).ref
		AddDataToArray(&backups, &data)
		i = i + 1.0
	}
}


func SortStringArray(_ a : inout Arrayx) -> Bool{
	return SortStringArrayWithOptions(&a, true)
}


func SortStringArrayDescending(_ a : inout Arrayx) -> Bool{
	return SortStringArrayWithOptions(&a, false)
}


func SortStringArrayWithOptions(_ a : inout Arrayx, _ asc : Bool) -> Bool{
	var asc = asc;
	var success : Bool
	var i, j, len, cmp : Double
	var swapped, swap : Bool
	var tmp : [Character]
	var da, db : Data

	len = ArrayLength(&a)
	success = true
	i = 0.0
	while(i < len && success){
		if(IsString(&ArrayIndex(&a, i).ref)){
		}else{
			success = false
		}
		i = i + 1.0
	}

	if(success){
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped){
			swapped = false
			j = 0.0
			while(j < len - i - 1.0){
				da = a.array[Int(j)]
				db = a.array[Int(j + 1.0)]

				cmp = StringOrder(&da.stringx, &db.stringx)
				if(asc){
					swap = cmp < 0.0
				}else{
					swap = cmp > 0.0
				}

				if(swap){
					tmp = da.stringx
					da.stringx = db.stringx
					db.stringx = tmp
					swapped = true
				}
				j = j + 1.0
			}
			i = i + 1.0
		}
	}

	return success
}


func StringOrder(_ a : inout [Character], _ b : inout [Character]) -> Double{
	var order, minimum, i, ac, bc : Double
	var done : Bool

	minimum = min(Double(a.count), Double(b.count))

	done = false
	order = 0.0
	i = 0.0
	while(i < minimum && !done){
		ac = charToDouble(a[Int(i)])
		bc = charToDouble(b[Int(i)])

		if(ac < bc){
			done = true
			order = 1.0
		}else if(ac > bc){
			done = true
			order = -1.0
		}
		i = i + 1.0
	}

	if(!done){
		if(Double(a.count) < Double(b.count)){
			order = 1.0
		}else if(Double(a.count) > Double(b.count)){
			order = -1.0
		}
	}

	return order
}


func SortNumberArray(_ a : inout Arrayx) -> Bool{
	return SortNumberArrayWithOptions(&a, true)
}


func SortNumberArrayDescending(_ a : inout Arrayx) -> Bool{
	return SortNumberArrayWithOptions(&a, false)
}


func SortNumberArrayWithOptions(_ a : inout Arrayx, _ asc : Bool) -> Bool{
	var asc = asc;
	var success : Bool
	var i, j, len : Double
	var swapped, swap : Bool
	var tmp : Double
	var da, db : Data

	len = ArrayLength(&a)
	success = true
	i = 0.0
	while(i < len && success){
		if(IsNumber(&ArrayIndex(&a, i).ref)){
		}else{
			success = false
		}
		i = i + 1.0
	}

	if(success){
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped){
			swapped = false
			j = 0.0
			while(j < len - i - 1.0){
				da = a.array[Int(j)]
				db = a.array[Int(j + 1.0)]

				if(asc){
					swap = da.number > db.number
				}else{
					swap = da.number < db.number
				}

				if(swap){
					tmp = da.number
					da.number = db.number
					db.number = tmp
					swapped = true
				}
				j = j + 1.0
			}
			i = i + 1.0
		}
	}

	return success
}


func SortStructArrayByNumberKey(_ a : inout Arrayx, _ key : inout [Character]) -> Bool{
	return SortStructArrayByNumberKeyWithOptions(&a, &key, true)
}


func SortStructArrayByNumberKeyDescending(_ a : inout Arrayx, _ key : inout [Character]) -> Bool{
	return SortStructArrayByNumberKeyWithOptions(&a, &key, false)
}


func SortStructArrayByNumberKeyWithOptions(_ a : inout Arrayx, _ key : inout [Character], _ asc : Bool) -> Bool{
	var asc = asc;
	var success : Bool
	var i, j, len : Double
	var swapped, swap : Bool
	var tmp : Structure
	var na, nb : Double
	var da, db : Data

	len = ArrayLength(&a)
	success = true
	i = 0.0
	while(i < len && success){
		da = ArrayIndex(&a, i).ref
		if(IsStructure(&da)){
			if(StructHasKey(&da.structure, &key)){
				da = GetDataFromStruct(&da.structure, &key).ref
				if(IsNumber(&da)){
				}else{
					success = false
				}
			}else{
				success = false
			}
		}else{
			success = false
		}
		i = i + 1.0
	}

	if(success){
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped){
			swapped = false
			j = 0.0
			while(j < len - i - 1.0){
				da = ArrayIndex(&a, j).ref
				db = ArrayIndex(&a, j + 1.0).ref

				na = GetNumberFromStruct(&da.structure, &key)
				nb = GetNumberFromStruct(&db.structure, &key)

				if(asc){
					swap = na > nb
				}else{
					swap = na < nb
				}

				if(swap){
					tmp = da.structure
					da.structure = db.structure
					db.structure = tmp
					swapped = true
				}
				j = j + 1.0
			}
			i = i + 1.0
		}
	}

	return success
}


func SortStructArrayByStringKey(_ a : inout Arrayx, _ key : inout [Character]) -> Bool{
	return SortStructArrayByStringKeyWithOptions(&a, &key, true)
}


func SortStructArrayByStringKeyDescending(_ a : inout Arrayx, _ key : inout [Character]) -> Bool{
	return SortStructArrayByStringKeyWithOptions(&a, &key, false)
}


func SortStructArrayByStringKeyWithOptions(_ a : inout Arrayx, _ key : inout [Character], _ asc : Bool) -> Bool{
	var asc = asc;
	var success : Bool
	var i, j, len, cmp : Double
	var swapped, swap : Bool
	var tmp : Structure
	var sa, sb : [Character]
	var da, db : Data

	len = ArrayLength(&a)
	success = true
	i = 0.0
	while(i < len && success){
		da = ArrayIndex(&a, i).ref
		if(IsStructure(&da)){
			if(StructHasKey(&da.structure, &key)){
				da = GetDataFromStruct(&da.structure, &key).ref
				if(IsString(&da)){
				}else{
					success = false
				}
			}else{
				success = false
			}
		}else{
			success = false
		}
		i = i + 1.0
	}

	if(success){
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped){
			swapped = false
			j = 0.0
			while(j < len - i - 1.0){
				da = ArrayIndex(&a, j).ref
				db = ArrayIndex(&a, j + 1.0).ref

				sa = GetStringFromStruct(&da.structure, &key)
				sb = GetStringFromStruct(&db.structure, &key)

				cmp = StringOrder(&sa, &sb)
				if(asc){
					swap = cmp < 0.0
				}else{
					swap = cmp > 0.0
				}
				if(swap){
					tmp = da.structure
					da.structure = db.structure
					db.structure = tmp
					swapped = true
				}
				j = j + 1.0
			}
			i = i + 1.0
		}
	}

	return success
}


func arraysStringToNumberArray(_ stringx : inout [Character]) -> [Double]{
	var i : Double
	var array : [Double]

	array = Array(repeating:Double(), count: Int(Double(stringx.count)))

	i = 0.0
	while(i < Double(stringx.count)){
		array[Int(i)] = charToDouble(stringx[Int(i)])
		i = i + 1.0
	}
	return array
}


func arraysNumberArrayToString(_ array : inout [Double]) -> [Character]{
	var i : Double
	var stringx : [Character]

	stringx = Array(repeating:Character(" "), count: Int(Double(array.count)))

	i = 0.0
	while(i < Double(array.count)){
		stringx[Int(i)] = Character(Unicode.Scalar(Int(array[Int(i)]))!)
		i = i + 1.0
	}
	return stringx
}


func arraysNumberArraysEqual(_ a : inout [Double], _ b : inout [Double]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysBooleanArraysEqual(_ a : inout [Bool], _ b : inout [Bool]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysStringsEqual(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysFillNumberArray(_ a : inout [Double], _ value : Double) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillString(_ a : inout [Character], _ value : Character) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillBooleanArray(_ a : inout [Bool], _ value : Bool) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillNumberArrayRange(_ a : inout [Double], _ value : Double, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysFillBooleanArrayRange(_ a : inout [Bool], _ value : Bool, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysFillStringRange(_ a : inout [Character], _ value : Character, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyNumberArray(_ a : inout [Double]) -> [Double]{
	var i : Double
	var n : [Double]

	n = Array(repeating:Double(), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyBooleanArray(_ a : inout [Bool]) -> [Bool]{
	var i : Double
	var n : [Bool]

	n = Array(repeating:Bool(), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyString(_ a : inout [Character]) -> [Character]{
	var i : Double
	var n : [Character]

	n = Array(repeating:Character(" "), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyNumberArrayRange(_ a : inout [Double], _ from : Double, _ to : Double, _ copyReference : inout NumberArrayReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Double]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Double(), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.numberArray = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyBooleanArrayRange(_ a : inout [Bool], _ from : Double, _ to : Double, _ copyReference : inout BooleanArrayReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Bool]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Bool(), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.booleanArray = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyStringRange(_ a : inout [Character], _ from : Double, _ to : Double, _ copyReference : inout StringReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Character]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Character(" "), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.stringx = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysIsLastElement(_ length : Double, _ index : Double) -> Bool{
	var length = length;
	var index = index;
	return index + 1.0 == length
}


func arraysCreateNumberArray(_ length : Double, _ value : Double) -> [Double]{
	var length = length;
	var value = value;
	var array : [Double]

	array = Array(repeating:Double(), count: Int(length))
	arraysFillNumberArray(&array, value)

	return array
}


func arraysCreateBooleanArray(_ length : Double, _ value : Bool) -> [Bool]{
	var length = length;
	var value = value;
	var array : [Bool]

	array = Array(repeating:Bool(), count: Int(length))
	arraysFillBooleanArray(&array, value)

	return array
}


func arraysCreateString(_ length : Double, _ value : Character) -> [Character]{
	var length = length;
	var value = value;
	var array : [Character]

	array = Array(repeating:Character(" "), count: Int(length))
	arraysFillString(&array, value)

	return array
}


func arraysSwapElementsOfNumberArray(_ A : inout [Double], _ ai : Double, _ bi : Double) -> Void{
	var ai = ai;
	var bi = bi;
	var tmp : Double

	tmp = A[Int(ai)]
	A[Int(ai)] = A[Int(bi)]
	A[Int(bi)] = tmp
}


func arraysSwapElementsOfStringArray(_ A : inout StringArrayReference, _ ai : Double, _ bi : Double) -> Void{
	var ai = ai;
	var bi = bi;
	var tmp : StringReference

	tmp = A.stringArray[Int(ai)]
	A.stringArray[Int(ai)] = A.stringArray[Int(bi)]
	A.stringArray[Int(bi)] = tmp
}


func arraysReverseNumberArray(_ array : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(array.count)/2.0){
		arraysSwapElementsOfNumberArray(&array, i, Double(array.count) - i - 1.0)
		i = i + 1.0
	}
}


func arraysNumberArrayContains(_ a : inout [Double], _ e : Double) -> Bool{
	var e = e;
	var found : Bool
	var i : Double

	found = false

	i = 0.0
	while(i < Double(a.count) && !found){
		if(arraysIndexNumber(&a, i) == e){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func arraysIndexNumber(_ array : inout [Double], _ index : Double) -> Double{
	var index = index;
	return array[Int(index)]
}


func arraysIndexChar(_ array : inout [Character], _ index : Double) -> Character{
	var index = index;
	return array[Int(index)]
}


func arraysIndexBoolean(_ array : inout [Bool], _ index : Double) -> Bool{
	var index = index;
	return array[Int(index)]
}


func arraysIndexString(_ array : inout [StringReference], _ index : Double) -> [Character]{
	var index = index;
	return array[Int(index)].stringx
}


func arraysGetMinimum(_ data : inout [Double], _ minimumReference : inout NumberReference) -> Bool{
	var i, minimum : Double
	var success : Bool

	if(Double(data.count) >= 1.0){
		minimum = data[Int(0)]
		i = 0.0
		while(i < Double(data.count)){
			minimum = min(minimum, data[Int(i)])
			i = i + 1.0
		}
		minimumReference.numberValue = minimum
		success = true
	}else{
		success = false
	}

	return success
}


func arraysGetMaximum(_ data : inout [Double], _ maximumReference : inout NumberReference) -> Bool{
	var i, maximum : Double
	var success : Bool

	if(Double(data.count) >= 1.0){
		maximum = data[Int(0)]
		i = 0.0
		while(i < Double(data.count)){
			maximum = max(maximum, data[Int(i)])
			i = i + 1.0
		}
		maximumReference.numberValue = maximum
		success = true
	}else{
		success = false
	}

	return success
}


func arraysAssignNumberArray(_ asx : inout [Double], _ bs : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < min(Double(asx.count), Double(bs.count))){
		asx[Int(i)] = bs[Int(i)]
		i = i + 1.0
	}
}


func arraysAssignBooleanArray(_ asx : inout [Bool], _ bs : inout [Bool]) -> Void{
	var i : Double

	i = 0.0
	while(i < min(Double(asx.count), Double(bs.count))){
		asx[Int(i)] = bs[Int(i)]
		i = i + 1.0
	}
}


func arraysAssignString(_ asx : inout [Character], _ bs : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < min(Double(asx.count), Double(bs.count))){
		asx[Int(i)] = bs[Int(i)]
		i = i + 1.0
	}
}


func arraysRearrangeArray(_ asx : inout [Double], _ indexes : inout [Double]) -> Void{
	var bs : [Double]
	var i : Double

	bs = Array(repeating:Double(), count: Int(Double(asx.count)))

	arraysAssignNumberArray(&bs, &asx)

	i = 0.0
	while(i < Double(indexes.count)){
		asx[Int(i)] = bs[Int(indexes[Int(i)])]
		i = i + 1.0
	}

	delete(bs)
}


func arraysSetNumberArrayRange(_ data : inout [Double], _ offset : Double, _ str : inout [Double]) -> Void{
	var offset = offset;
	var i : Double

	i = 0.0
	while(i < Double(str.count) && offset + i < Double(data.count)){
		data[Int(offset + i)] = str[Int(i)]
		i = i + 1.0
	}
}


func arraysCopyNumberArrayValues(_ a : inout [Double], _ b : inout [Double]) -> Bool{
	var success : Bool
	var i : Double

	success = Double(a.count) == Double(b.count)

	if(success){
		i = 0.0
		while(i < Double(a.count)){
			a[Int(i)] = b[Int(i)]
			i = i + 1.0
		}
	}

	return success
}


func arraysCopyBooleanArrayValues(_ a : inout [Bool], _ b : inout [Bool]) -> Bool{
	var success : Bool
	var i : Double

	success = Double(a.count) == Double(b.count)

	if(success){
		i = 0.0
		while(i < Double(a.count)){
			a[Int(i)] = b[Int(i)]
			i = i + 1.0
		}
	}

	return success
}


func arraysCopyStringValues(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var success : Bool
	var i : Double

	success = Double(a.count) == Double(b.count)

	if(success){
		i = 0.0
		while(i < Double(a.count)){
			a[Int(i)] = b[Int(i)]
			i = i + 1.0
		}
	}

	return success
}


func CreateStringScientificNotationDecimalFromNumber(_ n : Double) -> [Character]{
	var n = n;
	var mantissaReference, exponentReference : StringReference
	var e : Double
	var isPositive : Bool
	var result : [Character]

	mantissaReference = StringReference()
	exponentReference = StringReference()
	result = Array(repeating:Character(" "), count: Int(0))

	if(n < 0.0){
		isPositive = false
		n = -n
	}else{
		isPositive = true
	}

	if(n == 0.0){
		e = 0.0
	}else{
		e = GetFirstDecimalDigitPosition(n)

		if(e < 0.0){
			n = n*pow(10.0, abs(e))
		}else{
			n = n/pow(10.0, e)
		}
	}

	mantissaReference.stringx = CreateStringDecimalFromNumber(n)
	exponentReference.stringx = CreateStringDecimalFromNumber(e)

	if(!isPositive){
		result = strAppendString(&result, &characterArray("-").ca)
	}

	result = strAppendString(&result, &mantissaReference.stringx)
	result = strAppendString(&result, &characterArray("e").ca)
	result = strAppendString(&result, &exponentReference.stringx)

	return result
}


func CreateStringDecimalFromNumber(_ number : Double) -> [Character]{
	var number = number;
	var d, factor, a, x, tz, extra, dotpos, p, zero : Double
	var isPositive, done, lessThan1, isInt : Bool
	var str, ds : [Character]
	var factorRef : NumberReference

	factorRef = NumberReference()

	isPositive = true

	if(number < 0.0){
		isPositive = false
		number = abs(number)
	}

	if(number == 0.0){
		str = characterArray("0").ca
	}else if(number > 999999999999999e99){
		/* Guard the number against relaxations.*/
		if(isPositive){
			str = characterArray("Infinity").ca
		}else{
			str = characterArray("-Infinity").ca
		}
	}else{
		lessThan1 = number < 1.0

		/* Guard the number against relaxations.*/
		if(number < 1e-99){
			number = 0.0
		}

		/* 1. Turn number into an integer with 15 digits.*/
		number = NumberTo15DigitInteger(number, &factorRef)
		factor = factorRef.numberValue
		delete(factorRef)

		/* 2. Extract the 15 digits*/
		ds = Array(repeating:Character(" "), count: Int(15))

		a = number
		zero = charToDouble("0")
		d = 0.0
		while(d < 15.0){
			x = a - floor(a/10.0)*10.0
			ds[Int(15.0 - d - 1.0)] = Character(Unicode.Scalar(Int((x + zero)))!)
			a = floor(a/10.0)
			d = d + 1.0
		}

		/* 3. Remove trailing zeros*/
		tz = 0.0
		done = false
		d = 0.0
		while(d < 15.0 && !done){
			if(ds[Int(15.0 - d - 1.0)] == "0"){
				tz = tz + 1.0
			}else{
				done = true
			}
			d = d + 1.0
		}
		ds = strSubstring(&ds, 0.0, 15.0 - tz)

		/* 4. Determine if integer*/
		isInt = factor + tz >= 0.0

		/* 5. Fill into formats*/
		if(isInt){
			/* |-----|*/
			/* AAAAAAA00000000*/
			str = Array(repeating:Character(" "), count: Int(15.0 + factor))
			d = 0.0
			while(d < Double(str.count)){
				str[Int(d)] = "0"
				d = d + 1.0
			}
			d = 0.0
			while(d < Double(ds.count)){
				str[Int(d)] = ds[Int(d)]
				d = d + 1.0
			}
		}else if(lessThan1){
			/*       |-----|*/
			/* 0.0000AAAAAAA*/
			extra = -factor - 15.0
			str = Array(repeating:Character(" "), count: Int(2.0 + extra + 15.0 - tz))
			d = 0.0
			while(d < Double(str.count)){
				str[Int(d)] = "0"
				d = d + 1.0
			}
			str[Int(1)] = "."
			d = 0.0
			while(d < Double(ds.count)){
				str[Int(2.0 + extra + d)] = ds[Int(d)]
				d = d + 1.0
			}
		}else{
			/* |-------|*/
			/* AAAA.AAAA*/
			str = Array(repeating:Character(" "), count: Int(1.0 + 15.0 - tz))
			dotpos = 15.0 + factor
			p = 0.0
			d = 0.0
			while(d < Double(str.count)){
				if(d == dotpos){
					str[Int(d)] = "."
				}else{
					str[Int(d)] = ds[Int(p)]
					p = p + 1.0
				}
				d = d + 1.0
			}
		}
	}

	/* Done*/
	if(!isPositive){
		str = strConcatenateString(&characterArray("-").ca, &str)
	}

	return str
}


func CreateStringFromNumberWithCheck(_ number : Double, _ basex : Double, _ stringRef : inout StringReference) -> Bool{
	var number = number;
	var basex = basex;
	var stringx : DynamicArrayCharacters
	var maximumDigits, i, d, digitPosition, trailingZeros : Double
	var success, hasPrintedPoint, isPositive, done : Bool
	var characterReference : CharacterReference
	var c : Character

	stringx = CreateDynamicArrayCharacters().ref
	isPositive = true

	if(number < 0.0){
		isPositive = false
		number = -number
	}

	if(number == 0.0){
		DynamicArrayAddCharacter(&stringx, "0")
		success = true
	}else{
		characterReference = CharacterReference()

		if(IsInteger(basex)){
			success = true

			maximumDigits = GetMaximumDigitsForBase(basex)

			digitPosition = GetFirstDigitPosition(number, basex)

			hasPrintedPoint = false

			if(!isPositive){
				DynamicArrayAddCharacter(&stringx, "-")
			}

			/* Print leading zeros.*/
			if(digitPosition < 0.0){
				DynamicArrayAddCharacter(&stringx, "0")
				DynamicArrayAddCharacter(&stringx, ".")
				hasPrintedPoint = true
				i = 0.0
				while(i < -digitPosition - 1.0){
					DynamicArrayAddCharacter(&stringx, "0")
					i = i + 1.0
				}
			}

			/* Count trailing zeros*/
			trailingZeros = 0.0
			done = false
			i = 0.0
			while(i < maximumDigits && !done){
				d = GetDigit(number, basex, maximumDigits - i - 1.0)
				if(d == 0.0){
					trailingZeros = trailingZeros + 1.0
				}else{
					done = true
				}
				i = i + 1.0
			}

			/* Print number.*/
			i = 0.0
			while(i < maximumDigits && success){
				d = GetDigit(number, basex, i)

				if(d >= basex){
					d = basex - 1.0
				}

				if(!hasPrintedPoint && digitPosition - i + 1.0 == 0.0){
					if(maximumDigits - i > trailingZeros){
						DynamicArrayAddCharacter(&stringx, ".")
					}
					hasPrintedPoint = true
				}

				if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
				}else{
					success = GetSingleDigitCharacterFromNumberWithCheck(d, basex, &characterReference)
					if(success){
						c = characterReference.characterValue
						DynamicArrayAddCharacter(&stringx, c)
					}
				}
				i = i + 1.0
			}

			if(success){
				/* Print trailing zeros.*/
				i = 0.0
				while(i < digitPosition - maximumDigits + 1.0){
					DynamicArrayAddCharacter(&stringx, "0")
					i = i + 1.0
				}
			}
		}else{
			success = false
		}
	}

	if(success){
		stringRef.stringx = DynamicArrayCharactersToArray(&stringx)
		FreeDynamicArrayCharacters(&stringx)
	}

	/* Done*/
	return success
}


func GetMaximumDigitsForBase(_ basex : Double) -> Double{
	var basex = basex;
	var t : Double

	t = pow(10.0, 15.0)
	return floor(log10(t)/log10(basex))
}


func GetMaximumDigitsForDecimal() -> Double{
	return 15.0
}


func NumberTo15DigitInteger(_ n : Double, _ factorRef : inout NumberReference) -> Double{
	var n = n;
	var i, dp : Double
	var factors : [Double]

	factors = GetPowersOfTenFor15d2e()
	dp = GetFirstDecimalDigitPosition(n)
	factorRef.numberValue = dp - 14.0

	i = 14.0 + -dp

	n = MultiplyWithIntegerPowerOf10(n, &factors, i)

	delete(factors)

	n = Roundx(n)

	if(n >= 1e15){
		n = n/10.0
		factorRef.numberValue = factorRef.numberValue + 1.0
	}

	return n
}


func MultiplyWithIntegerPowerOf10(_ n : Double, _ factors : inout [Double], _ power : Double) -> Double{
	var n = n;
	var power = power;
	n = n*factors[Int(power + 99.0)]

	return n
}


func GetFirstDecimalDigitPosition(_ n : Double) -> Double{
	var n = n;
	var power, i : Double
	var factors : [Double]
	var found : Bool

	n = abs(n)

	factors = GetPowersOfTenFor15d2e()

	power = 1.0

	if(n == 0.0){
		power = 0.0
	}else if(n > 999999999999999e99){
		/* This guards against relaxed variables' max value*/
		power = 114.0
	}else if(n < 1e-99){
		/* This guards against relaxed variables' min value*/
		power = -100.0
	}else{
		found = false
		/* Search the most likely space first.*/
		i = 99.0 - 20.0
		while(i < 99.0 + 20.0 && !found){
			if(n >= factors[Int(i)] && n < factors[Int(i + 1.0)]){
				power = i - 99.0
				found = true
			}
			i = i + 1.0
		}
		/* Search the whole space*/
		i = 0.0
		while(i < Double(factors.count) - 1.0 && !found){
			if(n >= factors[Int(i)] && n < factors[Int(i + 1.0)]){
				power = i - 99.0
				found = true
			}
			i = i + 1.0
		}
		if(!found){
			if(n >= 100000000000000e99 && n <= 999999999999999e99){
				power = i - 99.0
			}
		}
	}

	delete(factors)

	/* Normal returns are -99 to 113. If -100 or 114 is returned, it means a relaxation is used.*/
	return power
}


func GetPowersOfTenFor15d2e() -> [Double]{
	var factors : [Double]

	factors = Array(repeating:Double(), count: Int(213))

	factors[Int(0)] = 1e-99
	factors[Int(1)] = 1e-98
	factors[Int(2)] = 1e-97
	factors[Int(3)] = 1e-96
	factors[Int(4)] = 1e-95
	factors[Int(5)] = 1e-94
	factors[Int(6)] = 1e-93
	factors[Int(7)] = 1e-92
	factors[Int(8)] = 1e-91
	factors[Int(9)] = 1e-90
	factors[Int(10)] = 1e-89
	factors[Int(11)] = 1e-88
	factors[Int(12)] = 1e-87
	factors[Int(13)] = 1e-86
	factors[Int(14)] = 1e-85
	factors[Int(15)] = 1e-84
	factors[Int(16)] = 1e-83
	factors[Int(17)] = 1e-82
	factors[Int(18)] = 1e-81
	factors[Int(19)] = 1e-80
	factors[Int(20)] = 1e-79
	factors[Int(21)] = 1e-78
	factors[Int(22)] = 1e-77
	factors[Int(23)] = 1e-76
	factors[Int(24)] = 1e-75
	factors[Int(25)] = 1e-74
	factors[Int(26)] = 1e-73
	factors[Int(27)] = 1e-72
	factors[Int(28)] = 1e-71
	factors[Int(29)] = 1e-70
	factors[Int(30)] = 1e-69
	factors[Int(31)] = 1e-68
	factors[Int(32)] = 1e-67
	factors[Int(33)] = 1e-66
	factors[Int(34)] = 1e-65
	factors[Int(35)] = 1e-64
	factors[Int(36)] = 1e-63
	factors[Int(37)] = 1e-62
	factors[Int(38)] = 1e-61
	factors[Int(39)] = 1e-60
	factors[Int(40)] = 1e-59
	factors[Int(41)] = 1e-58
	factors[Int(42)] = 1e-57
	factors[Int(43)] = 1e-56
	factors[Int(44)] = 1e-55
	factors[Int(45)] = 1e-54
	factors[Int(46)] = 1e-53
	factors[Int(47)] = 1e-52
	factors[Int(48)] = 1e-51
	factors[Int(49)] = 1e-50
	factors[Int(50)] = 1e-49
	factors[Int(51)] = 1e-48
	factors[Int(52)] = 1e-47
	factors[Int(53)] = 1e-46
	factors[Int(54)] = 1e-45
	factors[Int(55)] = 1e-44
	factors[Int(56)] = 1e-43
	factors[Int(57)] = 1e-42
	factors[Int(58)] = 1e-41
	factors[Int(59)] = 1e-40
	factors[Int(60)] = 1e-39
	factors[Int(61)] = 1e-38
	factors[Int(62)] = 1e-37
	factors[Int(63)] = 1e-36
	factors[Int(64)] = 1e-35
	factors[Int(65)] = 1e-34
	factors[Int(66)] = 1e-33
	factors[Int(67)] = 1e-32
	factors[Int(68)] = 1e-31
	factors[Int(69)] = 1e-30
	factors[Int(70)] = 1e-29
	factors[Int(71)] = 1e-28
	factors[Int(72)] = 1e-27
	factors[Int(73)] = 1e-26
	factors[Int(74)] = 1e-25
	factors[Int(75)] = 1e-24
	factors[Int(76)] = 1e-23
	factors[Int(77)] = 1e-22
	factors[Int(78)] = 1e-21
	factors[Int(79)] = 1e-20
	factors[Int(80)] = 1e-19
	factors[Int(81)] = 1e-18
	factors[Int(82)] = 1e-17
	factors[Int(83)] = 1e-16
	factors[Int(84)] = 1e-15
	factors[Int(85)] = 1e-14
	factors[Int(86)] = 1e-13
	factors[Int(87)] = 1e-12
	factors[Int(88)] = 1e-11
	factors[Int(89)] = 1e-10
	factors[Int(90)] = 1e-9
	factors[Int(91)] = 1e-8
	factors[Int(92)] = 1e-7
	factors[Int(93)] = 1e-6
	factors[Int(94)] = 1e-5
	factors[Int(95)] = 1e-4
	factors[Int(96)] = 1e-3
	factors[Int(97)] = 1e-2
	factors[Int(98)] = 1e-1
	factors[Int(99)] = 1e0
	factors[Int(100)] = 1e1
	factors[Int(101)] = 1e2
	factors[Int(102)] = 1e3
	factors[Int(103)] = 1e4
	factors[Int(104)] = 1e5
	factors[Int(105)] = 1e6
	factors[Int(106)] = 1e7
	factors[Int(107)] = 1e8
	factors[Int(108)] = 1e9
	factors[Int(109)] = 1e10
	factors[Int(110)] = 1e11
	factors[Int(111)] = 1e12
	factors[Int(112)] = 1e13
	factors[Int(113)] = 1e14
	factors[Int(114)] = 1e15
	factors[Int(115)] = 1e16
	factors[Int(116)] = 1e17
	factors[Int(117)] = 1e18
	factors[Int(118)] = 1e19
	factors[Int(119)] = 1e20
	factors[Int(120)] = 1e21
	factors[Int(121)] = 1e22
	factors[Int(122)] = 1e23
	factors[Int(123)] = 1e24
	factors[Int(124)] = 1e25
	factors[Int(125)] = 1e26
	factors[Int(126)] = 1e27
	factors[Int(127)] = 1e28
	factors[Int(128)] = 1e29
	factors[Int(129)] = 1e30
	factors[Int(130)] = 1e31
	factors[Int(131)] = 1e32
	factors[Int(132)] = 1e33
	factors[Int(133)] = 1e34
	factors[Int(134)] = 1e35
	factors[Int(135)] = 1e36
	factors[Int(136)] = 1e37
	factors[Int(137)] = 1e38
	factors[Int(138)] = 1e39
	factors[Int(139)] = 1e40
	factors[Int(140)] = 1e41
	factors[Int(141)] = 1e42
	factors[Int(142)] = 1e43
	factors[Int(143)] = 1e44
	factors[Int(144)] = 1e45
	factors[Int(145)] = 1e46
	factors[Int(146)] = 1e47
	factors[Int(147)] = 1e48
	factors[Int(148)] = 1e49
	factors[Int(149)] = 1e50
	factors[Int(150)] = 1e51
	factors[Int(151)] = 1e52
	factors[Int(152)] = 1e53
	factors[Int(153)] = 1e54
	factors[Int(154)] = 1e55
	factors[Int(155)] = 1e56
	factors[Int(156)] = 1e57
	factors[Int(157)] = 1e58
	factors[Int(158)] = 1e59
	factors[Int(159)] = 1e60
	factors[Int(160)] = 1e61
	factors[Int(161)] = 1e62
	factors[Int(162)] = 1e63
	factors[Int(163)] = 1e64
	factors[Int(164)] = 1e65
	factors[Int(165)] = 1e66
	factors[Int(166)] = 1e67
	factors[Int(167)] = 1e68
	factors[Int(168)] = 1e69
	factors[Int(169)] = 1e70
	factors[Int(170)] = 1e71
	factors[Int(171)] = 1e72
	factors[Int(172)] = 1e73
	factors[Int(173)] = 1e74
	factors[Int(174)] = 1e75
	factors[Int(175)] = 1e76
	factors[Int(176)] = 1e77
	factors[Int(177)] = 1e78
	factors[Int(178)] = 1e79
	factors[Int(179)] = 1e80
	factors[Int(180)] = 1e81
	factors[Int(181)] = 1e82
	factors[Int(182)] = 1e83
	factors[Int(183)] = 1e84
	factors[Int(184)] = 1e85
	factors[Int(185)] = 1e86
	factors[Int(186)] = 1e87
	factors[Int(187)] = 1e88
	factors[Int(188)] = 1e89
	factors[Int(189)] = 1e90
	factors[Int(190)] = 1e91
	factors[Int(191)] = 1e92
	factors[Int(192)] = 1e93
	factors[Int(193)] = 1e94
	factors[Int(194)] = 1e95
	factors[Int(195)] = 1e96
	factors[Int(196)] = 1e97
	factors[Int(197)] = 1e98
	factors[Int(198)] = 1e99
	factors[Int(199)] = 10e99
	factors[Int(200)] = 100e99
	factors[Int(201)] = 1000e99
	factors[Int(202)] = 10000e99
	factors[Int(203)] = 100000e99
	factors[Int(204)] = 1000000e99
	factors[Int(205)] = 10000000e99
	factors[Int(206)] = 100000000e99
	factors[Int(207)] = 1000000000e99
	factors[Int(208)] = 10000000000e99
	factors[Int(209)] = 100000000000e99
	factors[Int(210)] = 1000000000000e99
	factors[Int(211)] = 10000000000000e99
	factors[Int(212)] = 100000000000000e99

	return factors
}


func GetFirstDigitPosition(_ n : Double, _ basex : Double) -> Double{
	var n = n;
	var basex = basex;
	var power, m, i, maximumDigits : Double
	var multiply, done : Bool

	maximumDigits = GetMaximumDigitsForBase(basex)
	n = abs(n)

	if(n != 0.0){
		if(floor(n) < pow(basex, maximumDigits)){
			multiply = true
		}else{
			multiply = false
		}

		done = false
		m = 0.0
		i = 0.0
		while(!done){
			if(multiply){
				m = n*pow(basex, i)
				if(floor(m) >= pow(basex, maximumDigits - 1.0)){
					done = true
				}
			}else{
				m = n/pow(basex, i)
				if(floor(m) < pow(basex, maximumDigits)){
					done = true
				}
			}
			i = i + 1.0
		}

		if(multiply){
			power = maximumDigits - i
		}else{
			power = maximumDigits + i - 2.0
		}

		if(Roundx(m) >= pow(basex, maximumDigits)){
			power = power + 1.0
		}
	}else{
		power = 1.0
	}

	return power
}


func GetSingleDigitCharacterFromNumberWithCheck(_ c : Double, _ basex : Double, _ characterReference : inout CharacterReference) -> Bool{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var success : Bool

	numberTable = GetDigitCharacterTable()

	if(c < basex || c < Double(numberTable.count)){
		success = true
		characterReference.characterValue = numberTable[Int(c)]
	}else{
		success = false
	}

	return success
}


func GetDecimalDigitCharacterFromNumberWithCheck(_ c : Double, _ characterRef : inout CharacterReference) -> Bool{
	var c = c;
	var numberTable : [Character]
	var success : Bool

	numberTable = characterArray("0123456789").ca

	if(c >= 0.0 && c < 10.0){
		success = true
		characterRef.characterValue = numberTable[Int(c)]
	}else{
		success = false
	}

	return success
}


func GetDigitCharacterTable() -> [Character]{
	var numberTable : [Character]

	numberTable = characterArray("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ").ca

	return numberTable
}


func GetDecimalDigit(_ n : Double, _ index : Double) -> Double{
	var n = n;
	var index = index;
	var digitPosition : Double

	digitPosition = GetFirstDecimalDigitPosition(n)

	return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)
}


func GetDecimalDigitWithFirstDigitPosition(_ n : Double, _ digitPosition : Double, _ index : Double) -> Double{
	var n = n;
	var digitPosition = digitPosition;
	var index = index;
	var d, m, i : Double
	var factorRef : NumberReference

	n = abs(n)

	factorRef = NumberReference()
	n = NumberTo15DigitInteger(n, &factorRef)
	delete(factorRef)

	m = n
	d = 0.0
	i = 0.0
	while(i < 15.0 - index){
		d = round(m.truncatingRemainder(dividingBy:10.0))
		m = m - d
		m = round(m/10.0)
		i = i + 1.0
	}

	return d
}


func GetDigit(_ n : Double, _ basex : Double, _ index : Double) -> Double{
	var n = n;
	var basex = basex;
	var index = index;
	var d, digitPosition, e, m, maximumDigits, i : Double

	n = abs(n)
	maximumDigits = GetMaximumDigitsForBase(basex)
	digitPosition = GetFirstDigitPosition(n, basex)

	e = maximumDigits - digitPosition - 1.0
	if(e < 0.0){
		n = round(n/pow(basex, abs(e)))
	}else{
		n = round(n*pow(basex, e))
	}

	m = n
	d = 0.0
	i = 0.0
	while(i < maximumDigits - index){
		d = round(m.truncatingRemainder(dividingBy:basex))
		m = m - d
		m = round(m/basex)
		i = i + 1.0
	}

	return d
}


func NumberToHumanReadableShortScale(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var k, M, B, T, Q : Double

	k = 1000.0
	M = k*1000.0
	B = M*1000.0
	T = B*1000.0
	Q = T*1000.0
	suffix = characterArray(" ").ca

	if(n < k){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= k && n < M){
		if(n < 10.0*k){
			n = Roundx(n/100.0)
			n = n/10.0
		}else{
			n = Roundx(n/k)
		}
		suffix = characterArray("k").ca
	}else if(n >= M && n < B){
		if(n < 10.0*M){
			n = Roundx(n/(k*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/M)
		}
		suffix = characterArray("M").ca
	}else if(n >= B && n < T){
		if(n < 10.0*B){
			n = Roundx(n/(M*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/B)
		}
		suffix = characterArray("B").ca
	}else if(n >= T && n < Q){
		if(n < 10.0*T){
			n = Roundx(n/(B*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/T)
		}
		suffix = characterArray("T").ca
	}else if(n >= Q){
		if(n < 10.0*Q){
			n = Roundx(n/(T*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Q)
		}
		suffix = characterArray("Q").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}
        
	return res
}


func NumberToHumanReadableBinary(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi : Double

	Ki = 1024.0
	Mi = Ki*1024.0
	Gi = Mi*1024.0
	Ti = Gi*1024.0
	Pi = Ti*1024.0
	Ei = Pi*1024.0
	Zi = Ei*1024.0
	Yi = Zi*1024.0
	suffix = characterArray(" ").ca

	if(n < Ki){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= Ki && n < Mi){
		if(n < 10.0*Ki){
			n = Roundx(n/(Ki/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ki)
		}
		suffix = characterArray("Ki").ca
	}else if(n >= Mi && n < Gi){
		if(n < 10.0*Mi){
			n = Roundx(n/(Mi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Mi)
		}
		suffix = characterArray("Mi").ca
	}else if(n >= Gi && n < Ti){
		if(n < 10.0*Gi){
			n = Roundx(n/(Gi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Gi)
		}
		suffix = characterArray("Gi").ca
	}else if(n >= Ti && n < Pi){
		if(n < 10.0*Ti){
			n = Roundx(n/(Ti/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ti)
		}
		suffix = characterArray("Ti").ca
	}else if(n >= Pi && n < Ei){
		if(n < 10.0*Pi){
			n = Roundx(n/(Pi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Pi)
		}
		suffix = characterArray("Pi").ca
	}else if(n >= Ei && n < Zi){
		if(n < 10.0*Ei){
			n = Roundx(n/(Ei/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ei)
		}
		suffix = characterArray("Ei").ca
	}else if(n >= Zi && n < Yi){
		if(n < 10.0*Zi){
			n = Roundx(n/(Zi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Zi)
		}
		suffix = characterArray("Zi").ca
	}else if(n >= Yi){
		if(n < 10.0*Yi){
			n = Roundx(n/(Yi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Yi)
		}
		suffix = characterArray("Yi").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}

	return res
}


func NumberToHumanReadableMetric(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var k, M, G, T, P, Ex, Z, Y, R, Q : Double

	k = 1000.0
	M = k*1000.0
	G = M*1000.0
	T = G*1000.0
	P = T*1000.0
	Ex = P*1000.0
	Z = Ex*1000.0
	Y = Z*1000.0
	R = Y*1000.0
	Q = R*1000.0
	suffix = characterArray(" ").ca

	if(n < k){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= k && n < M){
		if(n < 10.0*k){
			n = Roundx(n/100.0)
			n = n/10.0
		}else{
			n = Roundx(n/k)
		}
		suffix = characterArray("k").ca
	}else if(n >= M && n < G){
		if(n < 10.0*M){
			n = Roundx(n/(k*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/M)
		}
		suffix = characterArray("M").ca
	}else if(n >= G && n < T){
		if(n < 10.0*G){
			n = Roundx(n/(M*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/G)
		}
		suffix = characterArray("G").ca
	}else if(n >= T && n < P){
		if(n < 10.0*T){
			n = Roundx(n/(G*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/T)
		}
		suffix = characterArray("T").ca
	}else if(n >= P && n < Ex){
		if(n < 10.0*P){
			n = Roundx(n/(T*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/P)
		}
		suffix = characterArray("P").ca
	}else if(n >= Ex && n < Z){
		if(n < 10.0*Ex){
			n = Roundx(n/(P*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ex)
		}
		suffix = characterArray("E").ca
	}else if(n >= Z && n < Y){
		if(n < 10.0*Z){
			n = Roundx(n/(Ex*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Z)
		}
		suffix = characterArray("Z").ca
	}else if(n >= Y && n < R){
		if(n < 10.0*Y){
			n = Roundx(n/(Z*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Y)
		}
		suffix = characterArray("Y").ca
	}else if(n >= R && n < Q){
		if(n < 10.0*R){
			n = Roundx(n/(Y*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/R)
		}
		suffix = characterArray("R").ca
	}else if(n >= Q){
		if(n < 10.0*Q){
			n = Roundx(n/(R*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Q)
		}
		suffix = characterArray("Q").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}

	return res
}


func IsValidNumber(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	delete(numberRef)
	delete(message)

	return valid
}


func IsValidInteger(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	if(valid){
		valid = IsInteger(numberRef.numberValue)
	}

	delete(numberRef)
	delete(message)

	return valid
}


func IsValidPositiveInteger(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	if(valid){
		valid = IsInteger(numberRef.numberValue)
		if(valid){
			valid = numberRef.numberValue >= 0.0
		}
	}

	delete(numberRef)
	delete(message)

	return valid
}


func CreateNumberFromDecimalStringWithCheck(_ stringx : inout [Character], _ decimalReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	return CreateDecimalNumberFromStringWithCheck(&stringx, &decimalReference, &message)
}


func CreateNumberFromDecimalString(_ stringx : inout [Character]) -> Double{
	var numberRef : NumberReference
	var message : StringReference
	var number : Double

	numberRef = CreateNumberReference(0.0).ref
	message = CreateStringReference(&characterArray("").ca).ref
	CreateDecimalNumberFromStringWithCheck(&stringx, &numberRef, &message)
	number = numberRef.numberValue

	delete(numberRef)
	delete(message)

	return number
}


func CreateNumberFromStringWithCheck(_ stringx : inout [Character], _ basex : Double, _ numberReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var basex = basex;
	var success : Bool
	var numberIsPositive, exponentIsPositive : BooleanReference
	var beforePoint, afterPoint, exponent : NumberArrayReference

	numberIsPositive = CreateBooleanReference(true).ref
	exponentIsPositive = CreateBooleanReference(true).ref
	beforePoint = NumberArrayReference()
	afterPoint = NumberArrayReference()
	exponent = NumberArrayReference()

	if(basex >= 2.0 && basex <= 36.0){
		success = ExtractPartsFromNumberString(&stringx, basex, &numberIsPositive, &beforePoint, &afterPoint, &exponentIsPositive, &exponent, &message)

		if(success){
			numberReference.numberValue = CreateNumberFromParts(basex, numberIsPositive.booleanValue, &beforePoint.numberArray, &afterPoint.numberArray, exponentIsPositive.booleanValue, &exponent.numberArray)
		}
	}else{
		success = false
		message.stringx = characterArray("Base must be from 2 to 36.").ca
	}

	return success
}


func CreateDecimalNumberFromStringWithCheck(_ stringx : inout [Character], _ numberReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var success : Bool
	var numberIsPositive, exponentIsPositive : BooleanReference
	var beforePoint, afterPoint, exponent : NumberArrayReference

	numberIsPositive = CreateBooleanReference(true).ref
	exponentIsPositive = CreateBooleanReference(true).ref
	beforePoint = NumberArrayReference()
	afterPoint = NumberArrayReference()
	exponent = NumberArrayReference()

	success = ExtractPartsFromNumberString(&stringx, 10.0, &numberIsPositive, &beforePoint, &afterPoint, &exponentIsPositive, &exponent, &message)

	if(success){
		numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, &beforePoint.numberArray, &afterPoint.numberArray, exponentIsPositive.booleanValue, &exponent.numberArray)
	}

	delete(numberIsPositive)
	delete(exponentIsPositive)
	delete(beforePoint)
	delete(afterPoint)
	delete(exponent)

	return success
}


func CreateNumberFromParts(_ basex : Double, _ numberIsPositive : Bool, _ beforePoint : inout [Double], _ afterPoint : inout [Double], _ exponentIsPositive : Bool, _ exponent : inout [Double]) -> Double{
	var basex = basex;
	var numberIsPositive = numberIsPositive;
	var exponentIsPositive = exponentIsPositive;
	var n, i, d, e, digits, integerOffset, maxDigits, roundingDigit : Double
	var digitsStarted, roundingDigitSet : Bool

	n = 0.0
	e = 0.0
	digits = 0.0
	digitsStarted = false
	integerOffset = 0.0
	maxDigits = floor(15.0*log(10.0)/log(basex))
	roundingDigitSet = false
	roundingDigit = 0.0

	/* We construct an integer n, inserting one and one digit and shifting left.*/
	/* We read up to a certain amount of digits.*/
	i = 0.0
	while(i < Double(beforePoint.count) + Double(afterPoint.count) && digits < maxDigits + 1.0){
		if(i < Double(beforePoint.count)){
			d = beforePoint[Int(i)]
		}else{
			d = afterPoint[Int(i - Double(beforePoint.count))]
		}

		if(digits < maxDigits){
			if(d != 0.0){
				digitsStarted = true
				integerOffset = Double(beforePoint.count) - i
			}

			n = n*basex
			n = n + d

			integerOffset = integerOffset - 1.0
		}else{
			roundingDigitSet = true
			roundingDigit = d
		}

		if(digitsStarted){
			digits = digits + 1.0
		}
		i = i + 1.0
	}

	if(roundingDigitSet){
		if(roundingDigit >= basex/2.0){
			n = n + 1.0
		}
	}

	i = 0.0
	while(i < Double(exponent.count)){
		d = exponent[Int(i)]
		e = e*basex
		e = e + d
		i = i + 1.0
	}

	if(!exponentIsPositive){
		e = -e
	}

	if(!numberIsPositive){
		n = -n
	}

	n = n*pow(basex, e + integerOffset)

	return n
}


func CreateDecimalNumberFromParts(_ numberIsPositive : Bool, _ beforePoint : inout [Double], _ afterPoint : inout [Double], _ exponentIsPositive : Bool, _ exponent : inout [Double]) -> Double{
	var numberIsPositive = numberIsPositive;
	var exponentIsPositive = exponentIsPositive;
	var n, i, d, e, digits, integerOffset, maxDigits, roundingDigit : Double
	var digitsStarted, roundingDigitSet : Bool

	n = 0.0
	e = 0.0
	digits = 0.0
	digitsStarted = false
	integerOffset = 0.0
	maxDigits = 15.0
	roundingDigitSet = false
	roundingDigit = 0.0

	/* We construct an integer n, inserting one and one digit and shifting left.*/
	/* We read up to 15 digits, but we note a 16th digit to correctly round the result.*/
	i = 0.0
	while(i < Double(beforePoint.count) + Double(afterPoint.count) && digits < maxDigits + 1.0){
		if(i < Double(beforePoint.count)){
			d = beforePoint[Int(i)]
		}else{
			d = afterPoint[Int(i - Double(beforePoint.count))]
		}

		if(digits < maxDigits){
			if(d != 0.0){
				digitsStarted = true
				integerOffset = Double(beforePoint.count) - i
			}

			n = n*10.0
			n = n + d

			integerOffset = integerOffset - 1.0
		}else{
			roundingDigitSet = true
			roundingDigit = d
		}

		if(digitsStarted){
			digits = digits + 1.0
		}
		i = i + 1.0
	}

	if(roundingDigitSet){
		if(roundingDigit >= 5.0){
			n = n + 1.0
		}
	}

	i = 0.0
	while(i < Double(exponent.count)){
		d = exponent[Int(i)]
		e = e*10.0
		e = e + d
		i = i + 1.0
	}

	if(!exponentIsPositive){
		e = -e
	}

	if(!numberIsPositive){
		n = -n
	}

	n = n*pow(10.0, e + integerOffset)

	return n
}


func ExtractPartsFromNumberString(_ n : inout [Character], _ basex : Double, _ numberIsPositive : inout BooleanReference, _ beforePoint : inout NumberArrayReference, _ afterPoint : inout NumberArrayReference, _ exponentIsPositive : inout BooleanReference, _ exponent : inout NumberArrayReference, _ message : inout StringReference) -> Bool{
	var basex = basex;
	var i, j, count : Double
	var success, done, complete : Bool

	i = 0.0
	complete = false

	if(i < Double(n.count)){
		if(n[Int(i)] == "-"){
			numberIsPositive.booleanValue = false
			i = i + 1.0
		}else if(n[Int(i)] == "+"){
			numberIsPositive.booleanValue = true
			i = i + 1.0
		}

		success = true
	}else{
		success = false
		message.stringx = characterArray("Number cannot have length zero.").ca
	}

	if(success){
		done = false
		count = 0.0
		while(i + count < Double(n.count) && !done){
			if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
				count = count + 1.0
			}else{
				done = true
			}
		}

		if(count >= 1.0){
			beforePoint.numberArray = Array(repeating:Double(), count: Int(count))

			j = 0.0
			while(j < count){
				beforePoint.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
				j = j + 1.0
			}

			i = i + count

			if(i < Double(n.count)){
				success = true
			}else{
				afterPoint.numberArray = Array(repeating:Double(), count: Int(0))
				exponent.numberArray = Array(repeating:Double(), count: Int(0))
				success = true
				complete = true
			}
		}else{
			success = false
			message.stringx = characterArray("Number must have at least one number after the optional sign.").ca
		}
	}

	if(success && !complete){
		if(n[Int(i)] == "."){
			i = i + 1.0

			if(i < Double(n.count)){
				done = false
				count = 0.0
				while(i + count < Double(n.count) && !done){
					if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
						count = count + 1.0
					}else{
						done = true
					}
				}

				if(count >= 1.0){
					afterPoint.numberArray = Array(repeating:Double(), count: Int(count))

					j = 0.0
					while(j < count){
						afterPoint.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
						j = j + 1.0
					}

					i = i + count

					if(i < Double(n.count)){
						success = true
					}else{
						exponent.numberArray = Array(repeating:Double(), count: Int(0))
						success = true
						complete = true
					}
				}else{
					success = false
					message.stringx = characterArray("There must be at least one digit after the decimal point.").ca
				}
			}else{
				success = false
				message.stringx = characterArray("There must be at least one digit after the decimal point.").ca
			}
		}else if(basex <= 14.0 && (n[Int(i)] == "e" || n[Int(i)] == "E")){
			if(i < Double(n.count)){
				success = true
				afterPoint.numberArray = Array(repeating:Double(), count: Int(0))
			}else{
				success = false
				message.stringx = characterArray("There must be at least one digit after the exponent.").ca
			}
		}else{
			success = false
			message.stringx = characterArray("Expected decimal point or exponent symbol.").ca
		}
	}

	if(success && !complete){
		if(basex <= 14.0 && (n[Int(i)] == "e" || n[Int(i)] == "E")){
			i = i + 1.0

			if(i < Double(n.count)){
				if(n[Int(i)] == "-"){
					exponentIsPositive.booleanValue = false
					i = i + 1.0
				}else if(n[Int(i)] == "+"){
					exponentIsPositive.booleanValue = true
					i = i + 1.0
				}

				if(i < Double(n.count)){
					done = false
					count = 0.0
					while(i + count < Double(n.count) && !done){
						if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
							count = count + 1.0
						}else{
							done = true
						}
					}

					if(count >= 1.0){
						exponent.numberArray = Array(repeating:Double(), count: Int(count))

						j = 0.0
						while(j < count){
							exponent.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
							j = j + 1.0
						}

						i = i + count

						if(i == Double(n.count)){
							success = true
						}else{
							success = false
							message.stringx = characterArray("There cannot be any characters past the exponent of the number.").ca
						}
					}else{
						success = false
						message.stringx = characterArray("There must be at least one digit after the decimal point.").ca
					}
				}else{
					success = false
					message.stringx = characterArray("There must be at least one digit after the exponent symbol.").ca
				}
			}else{
				success = false
				message.stringx = characterArray("There must be at least one digit after the exponent symbol.").ca
			}
		}else{
			success = false
			message.stringx = characterArray("Expected exponent symbol.").ca
		}
	}

	return success
}


func GetNumberFromNumberCharacterForBase(_ c : Character, _ basex : Double) -> Double{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var i : Double
	var position : Double

	numberTable = GetDigitCharacterTable()
	position = 0.0

	i = 0.0
	while(i < basex){
		if(numberTable[Int(i)] == c){
			position = i
		}
		i = i + 1.0
	}

	return position
}


func CharacterIsNumberCharacterInBase(_ c : Character, _ basex : Double) -> Bool{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var i : Double
	var found : Bool

	numberTable = GetDigitCharacterTable()
	found = false

	i = 0.0
	while(i < basex){
		if(numberTable[Int(i)] == c){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func StringToNumberArray(_ str : inout [Character]) -> [Double]{
	var numberArrayReference : NumberArrayReference
	var stringReference : StringReference
	var numbers : [Double]

	numberArrayReference = NumberArrayReference()
	stringReference = StringReference()

	StringToNumberArrayWithCheck(&str, &numberArrayReference, &stringReference)

	numbers = numberArrayReference.numberArray

	delete(numberArrayReference)
	delete(stringReference)

	return numbers
}


func StringToNumberArrayWithCheck(_ str : inout [Character], _ numberArrayReference : inout NumberArrayReference, _ errorMessage : inout StringReference) -> Bool{
	var numberStrings : [StringReference]
	var numbers : [Double]
	var i : Double
	var numberString, trimmedNumberString : [Character]
	var success : Bool
	var numberReference : NumberReference

	numberStrings = strSplitByString(&str, &characterArray(",").ca)

	numbers = Array(repeating:Double(), count: Int(Double(numberStrings.count)))
	success = true
	numberReference = NumberReference()

	i = 0.0
	while(i < Double(numberStrings.count)){
		numberString = numberStrings[Int(i)].stringx
		trimmedNumberString = strTrim(&numberString)
		success = CreateNumberFromDecimalStringWithCheck(&trimmedNumberString, &numberReference, &errorMessage)
		numbers[Int(i)] = numberReference.numberValue

		FreeStringReference(&numberStrings[Int(i)])
		delete(trimmedNumberString)
		i = i + 1.0
	}

	delete(numberStrings)
	delete(numberReference)

	numberArrayReference.numberArray = numbers

	return success
}


func strWriteStringToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(src.count)){
		stream[Int(index.numberValue + i)] = src[Int(i)]
		i = i + 1.0
	}
	index.numberValue = index.numberValue + Double(src.count)
}


func strWriteCharacterToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : Character) -> Void{
	var src = src;
	stream[Int(index.numberValue)] = src
	index.numberValue = index.numberValue + 1.0
}


func strWriteBooleanToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : Bool) -> Void{
	var src = src;
	if(src){
		strWriteStringToStingStream(&stream, &index, &characterArray("true").ca)
	}else{
		strWriteStringToStingStream(&stream, &index, &characterArray("false").ca)
	}
}


func strSubstringWithCheck(_ stringx : inout [Character], _ from : Double, _ to : Double, _ stringReference : inout StringReference) -> Bool{
	var from = from;
	var to = to;
	var success : Bool

	if(from >= 0.0 && from <= Double(stringx.count) && to >= 0.0 && to <= Double(stringx.count) && from <= to){
		stringReference.stringx = strSubstring(&stringx, from, to)
		success = true
	}else{
		success = false
	}

	return success
}


func strSubstring(_ stringx : inout [Character], _ from : Double, _ to : Double) -> [Character]{
	var from = from;
	var to = to;
	var n : [Character]
	var i, length : Double

	length = to - from

	n = Array(repeating:Character(" "), count: Int(length))

	i = from
	while(i < to){
		n[Int(i - from)] = stringx[Int(i)]
		i = i + 1.0
	}

	return n
}


func strAppendString(_ s1 : inout [Character], _ s2 : inout [Character]) -> [Character]{
	var newString : [Character]

	newString = strConcatenateString(&s1, &s2)

	delete(s1)

	return newString
}


func strConcatenateString(_ s1 : inout [Character], _ s2 : inout [Character]) -> [Character]{
	var newString : [Character]
	var i : Double

	newString = Array(repeating:Character(" "), count: Int(Double(s1.count) + Double(s2.count)))

	i = 0.0
	while(i < Double(s1.count)){
		newString[Int(i)] = s1[Int(i)]
		i = i + 1.0
	}

	i = 0.0
	while(i < Double(s2.count)){
		newString[Int(Double(s1.count) + i)] = s2[Int(i)]
		i = i + 1.0
	}

	return newString
}


func strAppendCharacter(_ stringx : inout [Character], _ c : Character) -> [Character]{
	var c = c;
	var newString : [Character]

	newString = strConcatenateCharacter(&stringx, c)

	delete(stringx)

	return newString
}


func strConcatenateCharacter(_ stringx : inout [Character], _ c : Character) -> [Character]{
	var c = c;
	var newString : [Character]
	var i : Double
	newString = Array(repeating:Character(" "), count: Int(Double(stringx.count) + 1.0))

	i = 0.0
	while(i < Double(stringx.count)){
		newString[Int(i)] = stringx[Int(i)]
		i = i + 1.0
	}

	newString[Int(Double(stringx.count))] = c

	return newString
}


func strSplitByCharacter(_ toSplit : inout [Character], _ splitBy : Character) -> [StringReference]{
	var splitBy = splitBy;
	var parts : [StringReference]
	var i : Double
	var c : Character
	var ll : LinkedListStrings
	var next : LinkedListCharacters
	var part : [Character]

	ll = CreateLinkedListString().ref

	next = CreateLinkedListCharacter().ref
	i = 0.0
	while(i < Double(toSplit.count)){
		c = toSplit[Int(i)]

		if(c == splitBy){
			part = LinkedListCharactersToArray(&next)
			LinkedListAddString(&ll, &part)
			FreeLinkedListCharacter(&next)
			next = CreateLinkedListCharacter().ref
		}else{
			LinkedListAddCharacter(&next, c)
		}
		i = i + 1.0
	}

	part = LinkedListCharactersToArray(&next)
	LinkedListAddString(&ll, &part)
	FreeLinkedListCharacter(&next)

	parts = LinkedListStringsToArray(&ll)
	FreeLinkedListString(&ll)

	return parts
}


func strIndexOfCharacter(_ stringx : inout [Character], _ character : Character, _ indexReference : inout NumberReference) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) && !found){
		if(stringx[Int(i)] == character){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strLastIndexOfCharacter(_ stringx : inout [Character], _ character : Character, _ indexReference : inout NumberReference) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == character){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strSubstringEqualsWithCheck(_ stringx : inout [Character], _ from : Double, _ substring : inout [Character], _ equalsReference : inout BooleanReference) -> Bool{
	var from = from;
	var success : Bool

	if(from < Double(stringx.count)){
		success = true
		equalsReference.booleanValue = strSubstringEquals(&stringx, from, &substring)
	}else{
		success = false
	}

	return success
}


func strSubstringEquals(_ stringx : inout [Character], _ from : Double, _ substring : inout [Character]) -> Bool{
	var from = from;
	var i : Double
	var equal : Bool

	equal = true
	if(Double(stringx.count) - from >= Double(substring.count)){
		i = 0.0
		while(i < Double(substring.count) && equal){
			if(stringx[Int(from + i)] != substring[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func strIndexOfString(_ stringx : inout [Character], _ substring : inout [Character], _ indexReference : inout NumberReference) -> Bool{
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) - Double(substring.count) + 1.0 && !found){
		if(strSubstringEquals(&stringx, i, &substring)){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strContainsCharacter(_ stringx : inout [Character], _ character : Character) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) && !found){
		if(stringx[Int(i)] == character){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func strContainsString(_ stringx : inout [Character], _ substring : inout [Character]) -> Bool{
	return strIndexOfString(&stringx, &substring, &NumberReferenceCreateFunction().ref)
}


func strToUpperCase(_ stringx : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		stringx[Int(i)] = cToUpperCase(stringx[Int(i)])
		i = i + 1.0
	}
}


func strToLowerCase(_ stringx : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		stringx[Int(i)] = cToLowerCase(stringx[Int(i)])
		i = i + 1.0
	}
}


func strEqualsIgnoreCase(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var equal : Bool
	var i : Double

	if(Double(a.count) == Double(b.count)){
		equal = true
		i = 0.0
		while(i < Double(a.count) && equal){
			if(cToLowerCase(a[Int(i)]) != cToLowerCase(b[Int(i)])){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func strReplaceString(_ stringx : inout [Character], _ toReplace : inout [Character], _ replaceWith : inout [Character]) -> [Character]{
	var result : [Character]
	var i, j : Double
	var equalsReference : BooleanReference
	var success : Bool
	var da : DynamicArrayCharacters

	da = CreateDynamicArrayCharacters().ref

	equalsReference = BooleanReference()

	i = 0.0
	while(i < Double(stringx.count)){
		success = strSubstringEqualsWithCheck(&stringx, i, &toReplace, &equalsReference)
		if(success){
			success = equalsReference.booleanValue
		}

		if(success && Double(toReplace.count) > 0.0){
			j = 0.0
			while(j < Double(replaceWith.count)){
				DynamicArrayAddCharacter(&da, replaceWith[Int(j)])
				j = j + 1.0
			}
			i = i + Double(toReplace.count)
		}else{
			DynamicArrayAddCharacter(&da, stringx[Int(i)])
			i = i + 1.0
		}
	}

	result = DynamicArrayCharactersToArray(&da)

	FreeDynamicArrayCharacters(&da)

	return result
}


func strReplaceCharacterToNew(_ stringx : inout [Character], _ toReplace : Character, _ replaceWith : Character) -> [Character]{
	var toReplace = toReplace;
	var replaceWith = replaceWith;
	var result : [Character]
	var i : Double

	result = Array(repeating:Character(" "), count: Int(Double(stringx.count)))

	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == toReplace){
			result[Int(i)] = replaceWith
		}else{
			result[Int(i)] = stringx[Int(i)]
		}
		i = i + 1.0
	}

	return result
}


func strReplaceCharacter(_ stringx : inout [Character], _ toReplace : Character, _ replaceWith : Character) -> Void{
	var toReplace = toReplace;
	var replaceWith = replaceWith;
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == toReplace){
			stringx[Int(i)] = replaceWith
		}
		i = i + 1.0
	}
}


func strTrim(_ stringx : inout [Character]) -> [Character]{
	var result : [Character]
	var i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd : Double
	var firstNonWhitespaceFound : Bool

	/* Find whitepaces at the start.*/
	lastWhitespaceLocationStart = -1.0
	firstNonWhitespaceFound = false
	i = 0.0
	while(i < Double(stringx.count) && !firstNonWhitespaceFound){
		if(cIsWhiteSpace(stringx[Int(i)])){
			lastWhitespaceLocationStart = i
		}else{
			firstNonWhitespaceFound = true
		}
		i = i + 1.0
	}

	/* Find whitepaces at the end.*/
	lastWhitespaceLocationEnd = Double(stringx.count)
	firstNonWhitespaceFound = false
	i = Double(stringx.count) - 1.0
	while(i >= 0.0 && !firstNonWhitespaceFound){
		if(cIsWhiteSpace(stringx[Int(i)])){
			lastWhitespaceLocationEnd = i
		}else{
			firstNonWhitespaceFound = true
		}
		i = i - 1.0
	}

	if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
		result = strSubstring(&stringx, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd)
	}else{
		result = Array(repeating:Character(" "), count: Int(0))
	}

	return result
}


func strStartsWith(_ stringx : inout [Character], _ start : inout [Character]) -> Bool{
	var startsWithString : Bool

	startsWithString = false
	if(Double(stringx.count) >= Double(start.count)){
		startsWithString = strSubstringEquals(&stringx, 0.0, &start)
	}

	return startsWithString
}


func strEndsWith(_ stringx : inout [Character], _ end : inout [Character]) -> Bool{
	var endsWithString : Bool

	endsWithString = false
	if(Double(stringx.count) >= Double(end.count)){
		endsWithString = strSubstringEquals(&stringx, Double(stringx.count) - Double(end.count), &end)
	}

	return endsWithString
}


func strSplitByWhitespace(_ toSplit : inout [Character]) -> [StringReference]{
	var parts : [StringReference]
	var i, skip : Double
	var c : Character
	var ll : LinkedListStrings
	var next : LinkedListCharacters
	var part : [Character]
	var split : Bool

	ll = CreateLinkedListString().ref

	next = CreateLinkedListCharacter().ref
	i = 0.0
	while(i < Double(toSplit.count)){
		c = toSplit[Int(i)]

		split = false
		skip = 0.0
		while((c == " " || c == "\n" || c == "\t") && i + skip <= Double(toSplit.count)){
			if(i + skip != Double(toSplit.count)){
				c = toSplit[Int(i + skip)]
			}
			skip = skip + 1.0
			split = true
		}

		if(split){
			part = LinkedListCharactersToArray(&next)
			LinkedListAddString(&ll, &part)
			FreeLinkedListCharacter(&next)
			next = CreateLinkedListCharacter().ref
			i = i + skip - 1.0
		}else{
			LinkedListAddCharacter(&next, c)
			i = i + 1.0
		}
	}

	part = LinkedListCharactersToArray(&next)
	LinkedListAddString(&ll, &part)
	FreeLinkedListCharacter(&next)

	parts = LinkedListStringsToArray(&ll)
	FreeLinkedListString(&ll)

	return parts
}


func strSplitByString(_ toSplit : inout [Character], _ splitBy : inout [Character]) -> [StringReference]{
	var parts : [StringReference]
	var i : Double
	var c : Character
	var ll : LinkedListStrings
	var next : LinkedListCharacters
	var part : [Character]

	ll = CreateLinkedListString().ref

	next = CreateLinkedListCharacter().ref
	i = 0.0
	while(i < Double(toSplit.count)){
		c = toSplit[Int(i)]

		if(strSubstringEquals(&toSplit, i, &splitBy)){
			part = LinkedListCharactersToArray(&next)
			LinkedListAddString(&ll, &part)
			FreeLinkedListCharacter(&next)
			next = CreateLinkedListCharacter().ref
			i = i + Double(splitBy.count)
		}else{
			LinkedListAddCharacter(&next, c)
			i = i + 1.0
		}
	}

	part = LinkedListCharactersToArray(&next)
	LinkedListAddString(&ll, &part)
	FreeLinkedListCharacter(&next)

	parts = LinkedListStringsToArray(&ll)
	FreeLinkedListString(&ll)

	return parts
}


func strStringIsBefore(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var before, equal, done : Bool
	var i : Double

	before = false
	equal = true
	done = false

	if(Double(a.count) == 0.0 && Double(b.count) > 0.0){
		before = true
	}else{
		i = 0.0
		while(i < Double(a.count) && i < Double(b.count) && !done){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			if(cCharacterIsBefore(a[Int(i)], b[Int(i)])){
				before = true
			}
			if(cCharacterIsBefore(b[Int(i)], a[Int(i)])){
				done = true
			}
			i = i + 1.0
		}

		if(equal){
			if(Double(a.count) < Double(b.count)){
				before = true
			}
		}
	}

	return before
}


func strJoinStringsWithSeparator(_ strings : inout [StringReference], _ separator : inout [Character]) -> [Character]{
	var result, stringx : [Character]
	var length, i : Double
	var index : NumberReference

	index = CreateNumberReference(0.0).ref

	length = 0.0
	i = 0.0
	while(i < Double(strings.count)){
		length = length + Double(strings[Int(i)].stringx.count)
		i = i + 1.0
	}
	length = length + (Double(strings.count) - 1.0)*Double(separator.count)

	result = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < Double(strings.count)){
		stringx = strings[Int(i)].stringx
		strWriteStringToStingStream(&result, &index, &stringx)
		if(i + 1.0 < Double(strings.count)){
			strWriteStringToStingStream(&result, &index, &separator)
		}
		i = i + 1.0
	}

	delete(index)

	return result
}


func strJoinStrings(_ strings : inout [StringReference]) -> [Character]{
	var result, stringx : [Character]
	var length, i : Double
	var index : NumberReference

	index = CreateNumberReference(0.0).ref

	length = 0.0
	i = 0.0
	while(i < Double(strings.count)){
		length = length + Double(strings[Int(i)].stringx.count)
		i = i + 1.0
	}

	result = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < Double(strings.count)){
		stringx = strings[Int(i)].stringx
		strWriteStringToStingStream(&result, &index, &stringx)
		i = i + 1.0
	}

	delete(index)

	return result
}


func strStringOrder(_ a : inout [Character], _ b : inout [Character]) -> Double{
	var order, minimum, i, ac, bc : Double
	var done : Bool

	minimum = min(Double(a.count), Double(b.count))

	done = false
	order = 0.0
	i = 0.0
	while(i < minimum && !done){
		ac = charToDouble(a[Int(i)])
		bc = charToDouble(b[Int(i)])

		if(ac < bc){
			done = true
			order = 1.0
		}else if(ac > bc){
			done = true
			order = -1.0
		}
		i = i + 1.0
	}

	if(!done){
		if(Double(a.count) < Double(b.count)){
			order = 1.0
		}else if(Double(a.count) > Double(b.count)){
			order = -1.0
		}
	}

	return order
}


func strLeftPad(_ str : inout [Character], _ width : Double) -> [Character]{
	var width = width;
	var i : Double
	var padded : [Character]

	padded = Array(repeating:Character(" "), count: Int(width))
	arraysFillString(&padded, " ")

	i = 0.0
	while(i < Double(str.count)){
		padded[Int(width - Double(str.count) + i)] = str[Int(i)]
		i = i + 1.0
	}

	return padded
}


func strRightPad(_ str : inout [Character], _ width : Double) -> [Character]{
	var width = width;
	var i : Double
	var padded : [Character]

	padded = Array(repeating:Character(" "), count: Int(width))
	arraysFillString(&padded, " ")

	i = 0.0
	while(i < Double(str.count)){
		padded[Int(i)] = str[Int(i)]
		i = i + 1.0
	}

	return padded
}


func cToLowerCase(_ character : Character) -> Character{
	var character = character;
	var toReturn : Character

	toReturn = character
	if(character == "A"){
		toReturn = "a"
	}else if(character == "B"){
		toReturn = "b"
	}else if(character == "C"){
		toReturn = "c"
	}else if(character == "D"){
		toReturn = "d"
	}else if(character == "E"){
		toReturn = "e"
	}else if(character == "F"){
		toReturn = "f"
	}else if(character == "G"){
		toReturn = "g"
	}else if(character == "H"){
		toReturn = "h"
	}else if(character == "I"){
		toReturn = "i"
	}else if(character == "J"){
		toReturn = "j"
	}else if(character == "K"){
		toReturn = "k"
	}else if(character == "L"){
		toReturn = "l"
	}else if(character == "M"){
		toReturn = "m"
	}else if(character == "N"){
		toReturn = "n"
	}else if(character == "O"){
		toReturn = "o"
	}else if(character == "P"){
		toReturn = "p"
	}else if(character == "Q"){
		toReturn = "q"
	}else if(character == "R"){
		toReturn = "r"
	}else if(character == "S"){
		toReturn = "s"
	}else if(character == "T"){
		toReturn = "t"
	}else if(character == "U"){
		toReturn = "u"
	}else if(character == "V"){
		toReturn = "v"
	}else if(character == "W"){
		toReturn = "w"
	}else if(character == "X"){
		toReturn = "x"
	}else if(character == "Y"){
		toReturn = "y"
	}else if(character == "Z"){
		toReturn = "z"
	}

	return toReturn
}


func cToUpperCase(_ character : Character) -> Character{
	var character = character;
	var toReturn : Character

	toReturn = character
	if(character == "a"){
		toReturn = "A"
	}else if(character == "b"){
		toReturn = "B"
	}else if(character == "c"){
		toReturn = "C"
	}else if(character == "d"){
		toReturn = "D"
	}else if(character == "e"){
		toReturn = "E"
	}else if(character == "f"){
		toReturn = "F"
	}else if(character == "g"){
		toReturn = "G"
	}else if(character == "h"){
		toReturn = "H"
	}else if(character == "i"){
		toReturn = "I"
	}else if(character == "j"){
		toReturn = "J"
	}else if(character == "k"){
		toReturn = "K"
	}else if(character == "l"){
		toReturn = "L"
	}else if(character == "m"){
		toReturn = "M"
	}else if(character == "n"){
		toReturn = "N"
	}else if(character == "o"){
		toReturn = "O"
	}else if(character == "p"){
		toReturn = "P"
	}else if(character == "q"){
		toReturn = "Q"
	}else if(character == "r"){
		toReturn = "R"
	}else if(character == "s"){
		toReturn = "S"
	}else if(character == "t"){
		toReturn = "T"
	}else if(character == "u"){
		toReturn = "U"
	}else if(character == "v"){
		toReturn = "V"
	}else if(character == "w"){
		toReturn = "W"
	}else if(character == "x"){
		toReturn = "X"
	}else if(character == "y"){
		toReturn = "Y"
	}else if(character == "z"){
		toReturn = "Z"
	}

	return toReturn
}


func cIsUpperCase(_ character : Character) -> Bool{
	var character = character;
	var isUpper : Bool

	isUpper = true
	if(character == "A"){
	}else if(character == "B"){
	}else if(character == "C"){
	}else if(character == "D"){
	}else if(character == "E"){
	}else if(character == "F"){
	}else if(character == "G"){
	}else if(character == "H"){
	}else if(character == "I"){
	}else if(character == "J"){
	}else if(character == "K"){
	}else if(character == "L"){
	}else if(character == "M"){
	}else if(character == "N"){
	}else if(character == "O"){
	}else if(character == "P"){
	}else if(character == "Q"){
	}else if(character == "R"){
	}else if(character == "S"){
	}else if(character == "T"){
	}else if(character == "U"){
	}else if(character == "V"){
	}else if(character == "W"){
	}else if(character == "X"){
	}else if(character == "Y"){
	}else if(character == "Z"){
	}else{
		isUpper = false
	}

	return isUpper
}


func cIsLowerCase(_ character : Character) -> Bool{
	var character = character;
	var isLower : Bool

	isLower = true
	if(character == "a"){
	}else if(character == "b"){
	}else if(character == "c"){
	}else if(character == "d"){
	}else if(character == "e"){
	}else if(character == "f"){
	}else if(character == "g"){
	}else if(character == "h"){
	}else if(character == "i"){
	}else if(character == "j"){
	}else if(character == "k"){
	}else if(character == "l"){
	}else if(character == "m"){
	}else if(character == "n"){
	}else if(character == "o"){
	}else if(character == "p"){
	}else if(character == "q"){
	}else if(character == "r"){
	}else if(character == "s"){
	}else if(character == "t"){
	}else if(character == "u"){
	}else if(character == "v"){
	}else if(character == "w"){
	}else if(character == "x"){
	}else if(character == "y"){
	}else if(character == "z"){
	}else{
		isLower = false
	}

	return isLower
}


func cIsLetter(_ character : Character) -> Bool{
	var character = character;
	return cIsUpperCase(character) || cIsLowerCase(character)
}


func cIsNumber(_ character : Character) -> Bool{
	var character = character;
	var isNumberx : Bool

	isNumberx = true
	if(character == "0"){
	}else if(character == "1"){
	}else if(character == "2"){
	}else if(character == "3"){
	}else if(character == "4"){
	}else if(character == "5"){
	}else if(character == "6"){
	}else if(character == "7"){
	}else if(character == "8"){
	}else if(character == "9"){
	}else{
		isNumberx = false
	}

	return isNumberx
}


func cIsWhiteSpace(_ character : Character) -> Bool{
	var character = character;
	var isWhiteSpacex : Bool

	isWhiteSpacex = true
	if(character == " "){
	}else if(character == "\t"){
	}else if(character == "\n"){
	}else if(character == "\r"){
	}else{
		isWhiteSpacex = false
	}

	return isWhiteSpacex
}


func cIsSymbol(_ character : Character) -> Bool{
	var character = character;
	var isSymbolx : Bool

	isSymbolx = true
	if(character == "!"){
	}else if(character == "\""){
	}else if(character == "#"){
	}else if(character == "$"){
	}else if(character == "%"){
	}else if(character == "&"){
	}else if(character == "\'"){
	}else if(character == "("){
	}else if(character == ")"){
	}else if(character == "*"){
	}else if(character == "+"){
	}else if(character == ","){
	}else if(character == "-"){
	}else if(character == "."){
	}else if(character == "/"){
	}else if(character == ":"){
	}else if(character == ";"){
	}else if(character == "<"){
	}else if(character == "="){
	}else if(character == ">"){
	}else if(character == "?"){
	}else if(character == "@"){
	}else if(character == "["){
	}else if(character == "\\"){
	}else if(character == "]"){
	}else if(character == "^"){
	}else if(character == "_"){
	}else if(character == "`"){
	}else if(character == "{"){
	}else if(character == "|"){
	}else if(character == "}"){
	}else if(character == "~"){
	}else{
		isSymbolx = false
	}

	return isSymbolx
}


func cCharacterIsBefore(_ a : Character, _ b : Character) -> Bool{
	var a = a;
	var b = b;
	var ad, bd : Double

	ad = charToDouble(a)
	bd = charToDouble(b)

	return ad < bd
}


func cDecimalDigitToCharacter(_ digit : Double) -> Character{
	var digit = digit;
	var c : Character

	if(digit == 1.0){
		c = "1"
	}else if(digit == 2.0){
		c = "2"
	}else if(digit == 3.0){
		c = "3"
	}else if(digit == 4.0){
		c = "4"
	}else if(digit == 5.0){
		c = "5"
	}else if(digit == 6.0){
		c = "6"
	}else if(digit == 7.0){
		c = "7"
	}else if(digit == 8.0){
		c = "8"
	}else if(digit == 9.0){
		c = "9"
	}else{
		c = "0"
	}

	return c
}


func cCharacterToDecimalDigit(_ c : Character) -> Double{
	var c = c;
	var digit : Double

	if(c == "1"){
		digit = 1.0
	}else if(c == "2"){
		digit = 2.0
	}else if(c == "3"){
		digit = 3.0
	}else if(c == "4"){
		digit = 4.0
	}else if(c == "5"){
		digit = 5.0
	}else if(c == "6"){
		digit = 6.0
	}else if(c == "7"){
		digit = 7.0
	}else if(c == "8"){
		digit = 8.0
	}else if(c == "9"){
		digit = 9.0
	}else{
		digit = 0.0
	}

	return digit
}


func cHexadecimalDigitToCharacter(_ digit : Double) -> Character{
	var digit = digit;
	var c : Character

	if(digit == 1.0){
		c = "1"
	}else if(digit == 2.0){
		c = "2"
	}else if(digit == 3.0){
		c = "3"
	}else if(digit == 4.0){
		c = "4"
	}else if(digit == 5.0){
		c = "5"
	}else if(digit == 6.0){
		c = "6"
	}else if(digit == 7.0){
		c = "7"
	}else if(digit == 8.0){
		c = "8"
	}else if(digit == 9.0){
		c = "9"
	}else if(digit == 10.0){
		c = "A"
	}else if(digit == 11.0){
		c = "B"
	}else if(digit == 12.0){
		c = "C"
	}else if(digit == 13.0){
		c = "D"
	}else if(digit == 14.0){
		c = "E"
	}else if(digit == 15.0){
		c = "F"
	}else{
		c = "0"
	}

	return c
}


func cCharacterToHexadecimalDigit(_ c : Character) -> Double{
	var c = c;
	var digit : Double

	if(c == "1"){
		digit = 1.0
	}else if(c == "2"){
		digit = 2.0
	}else if(c == "3"){
		digit = 3.0
	}else if(c == "4"){
		digit = 4.0
	}else if(c == "5"){
		digit = 5.0
	}else if(c == "6"){
		digit = 6.0
	}else if(c == "7"){
		digit = 7.0
	}else if(c == "8"){
		digit = 8.0
	}else if(c == "9"){
		digit = 9.0
	}else if(c == "A"){
		digit = 10.0
	}else if(c == "B"){
		digit = 11.0
	}else if(c == "C"){
		digit = 12.0
	}else if(c == "D"){
		digit = 13.0
	}else if(c == "E"){
		digit = 14.0
	}else if(c == "F"){
		digit = 15.0
	}else{
		digit = 0.0
	}

	return digit
}


func GetBlack() -> RGBAReferenceClass{
	var black : RGBA
	black = RGBA()
	black.a = 1.0
	black.r = 0.0
	black.g = 0.0
	black.b = 0.0
	var returnReference = RGBAReferenceClass()
	returnReference.ref = black
	return returnReference
}


func GetWhite() -> RGBAReferenceClass{
	var white : RGBA
	white = RGBA()
	white.a = 1.0
	white.r = 1.0
	white.g = 1.0
	white.b = 1.0
	var returnReference = RGBAReferenceClass()
	returnReference.ref = white
	return returnReference
}


func GetTransparent() -> RGBAReferenceClass{
	var transparent : RGBA
	transparent = RGBA()
	transparent.a = 0.0
	transparent.r = 0.0
	transparent.g = 0.0
	transparent.b = 0.0
	var returnReference = RGBAReferenceClass()
	returnReference.ref = transparent
	return returnReference
}


func GetGray(_ percentage : Double) -> RGBAReferenceClass{
	var percentage = percentage;
	var black : RGBA
	black = RGBA()
	black.a = 1.0
	black.r = 1.0 - percentage
	black.g = 1.0 - percentage
	black.b = 1.0 - percentage
	var returnReference = RGBAReferenceClass()
	returnReference.ref = black
	return returnReference
}


func CreateRGBColor(_ r : Double, _ g : Double, _ b : Double) -> RGBAReferenceClass{
	var r = r;
	var g = g;
	var b = b;
	var color : RGBA
	color = RGBA()
	color.a = 1.0
	color.r = r
	color.g = g
	color.b = b
	var returnReference = RGBAReferenceClass()
	returnReference.ref = color
	return returnReference
}


func CreateRGBAColor(_ r : Double, _ g : Double, _ b : Double, _ a : Double) -> RGBAReferenceClass{
	var r = r;
	var g = g;
	var b = b;
	var a = a;
	var color : RGBA
	color = RGBA()
	color.a = a
	color.r = r
	color.g = g
	color.b = b
	var returnReference = RGBAReferenceClass()
	returnReference.ref = color
	return returnReference
}


func CreateImage(_ w : Double, _ h : Double, _ color : inout RGBA) -> RGBABitmapImageReferenceClass{
	var w = w;
	var h = h;
	var image : RGBABitmapImage
	var i, j : Double

	image = RGBABitmapImage()
	image.x = Array(repeating:RGBABitmap(), count: Int(w))
	i = 0.0
	while(i < w){
		image.x[Int(i)] = RGBABitmap()
		image.x[Int(i)].y = Array(repeating:RGBA(), count: Int(h))
		j = 0.0
		while(j < h){
			image.x[Int(i)].y[Int(j)] = RGBA()
			SetPixel(&image, i, j, &color)
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = image
	return returnReference
}


func DeleteImage(_ image : inout RGBABitmapImage) -> Void{
	var i, j, w, h : Double

	w = ImageWidth(&image)
	h = ImageHeight(&image)

	i = 0.0
	while(i < w){
		j = 0.0
		while(j < h){
			delete(image.x[Int(i)].y[Int(j)])
			j = j + 1.0
		}
		delete(image.x[Int(i)])
		i = i + 1.0
	}
	delete(image)
}


func ImageWidth(_ image : inout RGBABitmapImage) -> Double{
	return Double(image.x.count)
}


func ImageHeight(_ image : inout RGBABitmapImage) -> Double{
	var height : Double

	if(ImageWidth(&image) == 0.0){
		height = 0.0
	}else{
		height = Double(image.x[Int(0)].y.count)
	}

	return height
}


func SetPixel(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	if(x >= 0.0 && x < ImageWidth(&image) && y >= 0.0 && y < ImageHeight(&image)){
		image.x[Int(x)].y[Int(y)].a = color.a
		image.x[Int(x)].y[Int(y)].r = color.r
		image.x[Int(x)].y[Int(y)].g = color.g
		image.x[Int(x)].y[Int(y)].b = color.b
	}
}


func DrawPixel(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var ra, ga, ba, aa : Double
	var rb, gb, bb, ab : Double
	var ro, go, bo, ao : Double
	var c : RGBA

	if(x >= 0.0 && x < ImageWidth(&image) && y >= 0.0 && y < ImageHeight(&image)){
		ra = color.r
		ga = color.g
		ba = color.b
		aa = color.a

		c = GetImagePixel(&image, x, y).ref
		rb = c.r
		gb = c.g
		bb = c.b
		ab = c.a

		ao = CombineAlpha(aa, ab)

		ro = AlphaBlend(ra, aa, rb, ab, ao)
		go = AlphaBlend(ga, aa, gb, ab, ao)
		bo = AlphaBlend(ba, aa, bb, ab, ao)

		image.x[Int(x)].y[Int(y)].r = ro
		image.x[Int(x)].y[Int(y)].g = go
		image.x[Int(x)].y[Int(y)].b = bo
		image.x[Int(x)].y[Int(y)].a = ao
	}
}


func CombineAlpha(_ asx : Double, _ ad : Double) -> Double{
	var asx = asx;
	var ad = ad;
	return asx + ad*(1.0 - asx)
}


func AlphaBlend(_ cs : Double, _ asx : Double, _ cd : Double, _ ad : Double, _ ao : Double) -> Double{
	var cs = cs;
	var asx = asx;
	var cd = cd;
	var ad = ad;
	var ao = ao;
	return (cs*asx + cd*ad*(1.0 - asx))/ao
}


func DrawHorizontalLine1px(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ length : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var length = length;
	var i : Double

	i = 0.0
	while(i < length){
		DrawPixel(&image, x + i, y, &color)
		i = i + 1.0
	}
}


func DrawVerticalLine1px(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ height : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var height = height;
	var i : Double

	i = 0.0
	while(i < height){
		DrawPixel(&image, x, y + i, &color)
		i = i + 1.0
	}
}


func DrawRectangle1px(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ width : Double, _ height : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var width = width;
	var height = height;
	DrawHorizontalLine1px(&image, x, y, width + 1.0, &color)
	DrawVerticalLine1px(&image, x, y + 1.0, height + 1.0 - 1.0, &color)
	DrawVerticalLine1px(&image, x + width, y + 1.0, height + 1.0 - 1.0, &color)
	DrawHorizontalLine1px(&image, x + 1.0, y + height, width + 1.0 - 2.0, &color)
}


func DrawImageOnImage(_ dst : inout RGBABitmapImage, _ src : inout RGBABitmapImage, _ topx : Double, _ topy : Double) -> Void{
	var topx = topx;
	var topy = topy;
	var y, x : Double

	y = 0.0
	while(y < ImageHeight(&src)){
		x = 0.0
		while(x < ImageWidth(&src)){
			if(topx + x >= 0.0 && topx + x < ImageWidth(&dst) && topy + y >= 0.0 && topy + y < ImageHeight(&dst)){
				DrawPixel(&dst, topx + x, topy + y, &GetImagePixel(&src, x, y).ref)
			}
			x = x + 1.0
		}
		y = y + 1.0
	}
}


func DrawLine1px(_ image : inout RGBABitmapImage, _ x0 : Double, _ y0 : Double, _ x1 : Double, _ y1 : Double, _ color : inout RGBA) -> Void{
	var x0 = x0;
	var y0 = y0;
	var x1 = x1;
	var y1 = y1;
	XiaolinWusLineAlgorithm(&image, x0, y0, x1, y1, &color)
}


func XiaolinWusLineAlgorithm(_ image : inout RGBABitmapImage, _ x0 : Double, _ y0 : Double, _ x1 : Double, _ y1 : Double, _ color : inout RGBA) -> Void{
	var x0 = x0;
	var y0 = y0;
	var x1 = x1;
	var y1 = y1;
	var steep : Bool
	var x, t, dx, dy, g, xEnd, yEnd, xGap, xpxl1, ypxl1, intery, xpxl2, ypxl2, olda : Double

	olda = color.a

	steep = abs(y1 - y0) > abs(x1 - x0)

	if(steep){
		t = x0
		x0 = y0
		y0 = t

		t = x1
		x1 = y1
		y1 = t
	}
	if(x0 > x1){
		t = x0
		x0 = x1
		x1 = t

		t = y0
		y0 = y1
		y1 = t
	}

	dx = x1 - x0
	dy = y1 - y0
	g = dy/dx

	if(dx == 0.0){
		g = 1.0
	}

	xEnd = Roundx(x0)
	yEnd = y0 + g*(xEnd - x0)
	xGap = OneMinusFractionalPart(x0 + 0.5)
	xpxl1 = xEnd
	ypxl1 = floor(yEnd)
	if(steep){
		DrawPixel(&image, ypxl1, xpxl1, &SetBrightness(&color, OneMinusFractionalPart(yEnd)*xGap).ref)
		DrawPixel(&image, ypxl1 + 1.0, xpxl1, &SetBrightness(&color, FractionalPart(yEnd)*xGap).ref)
	}else{
		DrawPixel(&image, xpxl1, ypxl1, &SetBrightness(&color, OneMinusFractionalPart(yEnd)*xGap).ref)
		DrawPixel(&image, xpxl1, ypxl1 + 1.0, &SetBrightness(&color, FractionalPart(yEnd)*xGap).ref)
	}
	intery = yEnd + g

	xEnd = Roundx(x1)
	yEnd = y1 + g*(xEnd - x1)
	xGap = FractionalPart(x1 + 0.5)
	xpxl2 = xEnd
	ypxl2 = floor(yEnd)
	if(steep){
		DrawPixel(&image, ypxl2, xpxl2, &SetBrightness(&color, OneMinusFractionalPart(yEnd)*xGap).ref)
		DrawPixel(&image, ypxl2 + 1.0, xpxl2, &SetBrightness(&color, FractionalPart(yEnd)*xGap).ref)
	}else{
		DrawPixel(&image, xpxl2, ypxl2, &SetBrightness(&color, OneMinusFractionalPart(yEnd)*xGap).ref)
		DrawPixel(&image, xpxl2, ypxl2 + 1.0, &SetBrightness(&color, FractionalPart(yEnd)*xGap).ref)
	}

	if(steep){
		x = xpxl1 + 1.0
		while(x <= xpxl2 - 1.0){
			DrawPixel(&image, floor(intery), x, &SetBrightness(&color, OneMinusFractionalPart(intery)).ref)
			DrawPixel(&image, floor(intery) + 1.0, x, &SetBrightness(&color, FractionalPart(intery)).ref)
			intery = intery + g
			x = x + 1.0
		}
	}else{
		x = xpxl1 + 1.0
		while(x <= xpxl2 - 1.0){
			DrawPixel(&image, x, floor(intery), &SetBrightness(&color, OneMinusFractionalPart(intery)).ref)
			DrawPixel(&image, x, floor(intery) + 1.0, &SetBrightness(&color, FractionalPart(intery)).ref)
			intery = intery + g
			x = x + 1.0
		}
	}

	color.a = olda
}


func OneMinusFractionalPart(_ x : Double) -> Double{
	var x = x;
	return 1.0 - FractionalPart(x)
}


func FractionalPart(_ x : Double) -> Double{
	var x = x;
	return x - floor(x)
}


func SetBrightness(_ color : inout RGBA, _ newBrightness : Double) -> RGBAReferenceClass{
	var newBrightness = newBrightness;
	color.a = newBrightness
	var returnReference = RGBAReferenceClass()
	returnReference.ref = color
	return returnReference
}


func DrawQuadraticBezierCurve(_ image : inout RGBABitmapImage, _ x0 : Double, _ y0 : Double, _ cx : Double, _ cy : Double, _ x1 : Double, _ y1 : Double, _ color : inout RGBA) -> Void{
	var x0 = x0;
	var y0 = y0;
	var cx = cx;
	var cy = cy;
	var x1 = x1;
	var y1 = y1;
	var t, dt, dx, dy : Double
	var xs, ys, xe, ye : NumberReference

	dx = abs(x0 - x1)
	dy = abs(y0 - y1)

	dt = 1.0/sqrt(pow(dx, 2.0) + pow(dy, 2.0))

	xs = NumberReference()
	ys = NumberReference()
	xe = NumberReference()
	ye = NumberReference()

	QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0.0, &xs, &ys)
	t = dt
	while(t <= 1.0){
		QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, &xe, &ye)
		DrawLine1px(&image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, &color)
		xs.numberValue = xe.numberValue
		ys.numberValue = ye.numberValue
		t = t + dt
	}

	delete(xs)
	delete(ys)
	delete(xe)
	delete(ye)
}


func QuadraticBezierPoint(_ x0 : Double, _ y0 : Double, _ cx : Double, _ cy : Double, _ x1 : Double, _ y1 : Double, _ t : Double, _ x : inout NumberReference, _ y : inout NumberReference) -> Void{
	var x0 = x0;
	var y0 = y0;
	var cx = cx;
	var cy = cy;
	var x1 = x1;
	var y1 = y1;
	var t = t;
	x.numberValue = pow(1.0 - t, 2.0)*x0 + (1.0 - t)*2.0*t*cx + pow(t, 2.0)*x1
	y.numberValue = pow(1.0 - t, 2.0)*y0 + (1.0 - t)*2.0*t*cy + pow(t, 2.0)*y1
}


func DrawCubicBezierCurve(_ image : inout RGBABitmapImage, _ x0 : Double, _ y0 : Double, _ c0x : Double, _ c0y : Double, _ c1x : Double, _ c1y : Double, _ x1 : Double, _ y1 : Double, _ color : inout RGBA) -> Void{
	var x0 = x0;
	var y0 = y0;
	var c0x = c0x;
	var c0y = c0y;
	var c1x = c1x;
	var c1y = c1y;
	var x1 = x1;
	var y1 = y1;
	var t, dt, dx, dy : Double
	var xs, ys, xe, ye : NumberReference

	dx = abs(x0 - x1)
	dy = abs(y0 - y1)

	dt = 1.0/sqrt(pow(dx, 2.0) + pow(dy, 2.0))

	xs = NumberReference()
	ys = NumberReference()
	xe = NumberReference()
	ye = NumberReference()

	CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0.0, &xs, &ys)
	t = dt
	while(t <= 1.0){
		CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, &xe, &ye)
		DrawLine1px(&image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, &color)
		xs.numberValue = xe.numberValue
		ys.numberValue = ye.numberValue
		t = t + dt
	}

	delete(xs)
	delete(ys)
	delete(xe)
	delete(ye)
}


func CubicBezierPoint(_ x0 : Double, _ y0 : Double, _ c0x : Double, _ c0y : Double, _ c1x : Double, _ c1y : Double, _ x1 : Double, _ y1 : Double, _ t : Double, _ x : inout NumberReference, _ y : inout NumberReference) -> Void{
	var x0 = x0;
	var y0 = y0;
	var c0x = c0x;
	var c0y = c0y;
	var c1x = c1x;
	var c1y = c1y;
	var x1 = x1;
	var y1 = y1;
	var t = t;
	x.numberValue = pow(1.0 - t, 3.0)*x0 + pow(1.0 - t, 2.0)*3.0*t*c0x + (1.0 - t)*3.0*pow(t, 2.0)*c1x + pow(t, 3.0)*x1

	y.numberValue = pow(1.0 - t, 3.0)*y0 + pow(1.0 - t, 2.0)*3.0*t*c0y + (1.0 - t)*3.0*pow(t, 2.0)*c1y + pow(t, 3.0)*y1
}


func CopyImage(_ image : inout RGBABitmapImage) -> RGBABitmapImageReferenceClass{
	var copy : RGBABitmapImage
	var i, j : Double

	copy = CreateImage(ImageWidth(&image), ImageHeight(&image), &GetTransparent().ref).ref

	i = 0.0
	while(i < ImageWidth(&image)){
		j = 0.0
		while(j < ImageHeight(&image)){
			SetPixel(&copy, i, j, &GetImagePixel(&image, i, j).ref)
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = copy
	return returnReference
}


func GetImagePixel(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double) -> RGBAReferenceClass{
	var x = x;
	var y = y;
	var returnReference = RGBAReferenceClass()
	returnReference.ref = image.x[Int(x)].y[Int(y)]
	return returnReference
}


func HorizontalFlip(_ img : inout RGBABitmapImage) -> Void{
	var y, x : Double
	var tmp : Double
	var c1, c2 : RGBA

	y = 0.0
	while(y < ImageHeight(&img)){
		x = 0.0
		while(x < ImageWidth(&img)/2.0){
			c1 = GetImagePixel(&img, x, y).ref
			c2 = GetImagePixel(&img, ImageWidth(&img) - 1.0 - x, y).ref

			tmp = c1.a
			c1.a = c2.a
			c2.a = tmp

			tmp = c1.r
			c1.r = c2.r
			c2.r = tmp

			tmp = c1.g
			c1.g = c2.g
			c2.g = tmp

			tmp = c1.b
			c1.b = c2.b
			c2.b = tmp
			x = x + 1.0
		}
		y = y + 1.0
	}
}


func DrawFilledRectangle(_ image : inout RGBABitmapImage, _ x : Double, _ y : Double, _ w : Double, _ h : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var w = w;
	var h = h;
	var i, j : Double

	i = 0.0
	while(i < w){
		j = 0.0
		while(j < h){
			SetPixel(&image, x + i, y + j, &color)
			j = j + 1.0
		}
		i = i + 1.0
	}
}


func RotateAntiClockwise90Degrees(_ image : inout RGBABitmapImage) -> RGBABitmapImageReferenceClass{
	var rotated : RGBABitmapImage
	var x, y : Double

	rotated = CreateImage(ImageHeight(&image), ImageWidth(&image), &GetBlack().ref).ref

	y = 0.0
	while(y < ImageHeight(&image)){
		x = 0.0
		while(x < ImageWidth(&image)){
			SetPixel(&rotated, y, ImageWidth(&image) - 1.0 - x, &GetImagePixel(&image, x, y).ref)
			x = x + 1.0
		}
		y = y + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = rotated
	return returnReference
}


func DrawCircle(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	DrawCircleBasicAlgorithm(&canvas, xCenter, yCenter, radius, &color)
}


func BresenhamsCircleDrawingAlgorithm(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	var x, y, delta : Double

	y = radius
	x = 0.0

	delta = 3.0 - 2.0*radius
	while(y >= x){
		DrawLine1px(&canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, &color)
		DrawLine1px(&canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, &color)
		DrawLine1px(&canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, &color)
		DrawLine1px(&canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, &color)

		DrawLine1px(&canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, &color)
		DrawLine1px(&canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, &color)
		DrawLine1px(&canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, &color)
		DrawLine1px(&canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, &color)

		if(delta < 0.0){
			delta = delta + 4.0*x + 6.0
		}else{
			delta = delta + 4.0*(x - y) + 10.0
			y = y - 1.0
		}
		x = x + 1.0
	}
}


func DrawCircleMidpointAlgorithm(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	var d, x, y : Double

	d = floor((5.0 - radius*4.0)/4.0)
	x = 0.0
	y = radius

	while(x <= y){
		DrawPixel(&canvas, xCenter + x, yCenter + y, &color)
		DrawPixel(&canvas, xCenter + x, yCenter - y, &color)
		DrawPixel(&canvas, xCenter - x, yCenter + y, &color)
		DrawPixel(&canvas, xCenter - x, yCenter - y, &color)
		DrawPixel(&canvas, xCenter + y, yCenter + x, &color)
		DrawPixel(&canvas, xCenter + y, yCenter - x, &color)
		DrawPixel(&canvas, xCenter - y, yCenter + x, &color)
		DrawPixel(&canvas, xCenter - y, yCenter - x, &color)

		if(d < 0.0){
			d = d + 2.0*x + 1.0
		}else{
			d = d + 2.0*(x - y) + 1.0
			y = y - 1.0
		}
		x = x + 1.0
	}
}


func DrawCircleBasicAlgorithm(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	var pixels, a, da, dx, dy : Double

	/* Place the circle in the center of the pixel.*/
	xCenter = floor(xCenter) + 0.5
	yCenter = floor(yCenter) + 0.5

	pixels = 2.0*Double.pi*radius

	/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
	if(radius < 10.0){
		pixels = pixels*10.0
	}

	da = 2.0*Double.pi/pixels

	a = 0.0
	while(a < 2.0*Double.pi){
		dx = cos(a)*radius
		dy = sin(a)*radius

		/* Floor to get the pixel coordinate.*/
		DrawPixel(&canvas, floor(xCenter + dx), floor(yCenter + dy), &color)
		a = a + da
	}
}


func DrawFilledCircle(_ canvas : inout RGBABitmapImage, _ x : Double, _ y : Double, _ r : Double, _ color : inout RGBA) -> Void{
	var x = x;
	var y = y;
	var r = r;
	DrawFilledCircleBasicAlgorithm(&canvas, x, y, r, &color)
}


func DrawFilledCircleMidpointAlgorithm(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	var d, x, y : Double

	d = floor((5.0 - radius*4.0)/4.0)
	x = 0.0
	y = radius

	while(x <= y){
		DrawLineBresenhamsAlgorithm(&canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, &color)
		DrawLineBresenhamsAlgorithm(&canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, &color)
		DrawLineBresenhamsAlgorithm(&canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, &color)
		DrawLineBresenhamsAlgorithm(&canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, &color)

		if(d < 0.0){
			d = d + 2.0*x + 1.0
		}else{
			d = d + 2.0*(x - y) + 1.0
			y = y - 1.0
		}
		x = x + 1.0
	}
}


func DrawFilledCircleBasicAlgorithm(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ radius : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var radius = radius;
	var pixels, a, da, dx, dy : Double

	/* Place the circle in the center of the pixel.*/
	xCenter = floor(xCenter) + 0.5
	yCenter = floor(yCenter) + 0.5

	pixels = 2.0*Double.pi*radius

	/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
	if(radius < 10.0){
		pixels = pixels*10.0
	}

	da = 2.0*Double.pi/pixels

	/* Draw lines for a half-circle to fill an entire circle.*/
	a = 0.0
	while(a < Double.pi){
		dx = cos(a)*radius
		dy = sin(a)*radius

		/* Floor to get the pixel coordinate.*/
		DrawVerticalLine1px(&canvas, floor(xCenter - dx), floor(yCenter - dy), floor(2.0*dy) + 1.0, &color)
		a = a + da
	}
}


func DrawTriangle(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ height : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var height = height;
	var x1, y1, x2, y2, x3, y3 : Double

	x1 = floor(xCenter + 0.5)
	y1 = floor(floor(yCenter + 0.5) - height)
	x2 = x1 - 2.0*height*tan(Double.pi/6.0)
	y2 = floor(y1 + 2.0*height)
	x3 = x1 + 2.0*height*tan(Double.pi/6.0)
	y3 = floor(y1 + 2.0*height)

	DrawLine1px(&canvas, x1, y1, x2, y2, &color)
	DrawLine1px(&canvas, x1, y1, x3, y3, &color)
	DrawLine1px(&canvas, x2, y2, x3, y3, &color)
}


func DrawFilledTriangle(_ canvas : inout RGBABitmapImage, _ xCenter : Double, _ yCenter : Double, _ height : Double, _ color : inout RGBA) -> Void{
	var xCenter = xCenter;
	var yCenter = yCenter;
	var height = height;
	var i, offset, x1, y1 : Double

	x1 = floor(xCenter + 0.5)
	y1 = floor(floor(yCenter + 0.5) - height)

	i = 0.0
	while(i <= 2.0*height){
		offset = floor(i*tan(Double.pi/6.0))
		DrawHorizontalLine1px(&canvas, x1 - offset, y1 + i, 2.0*offset, &color)
		i = i + 1.0
	}
}


func DrawLine(_ canvas : inout RGBABitmapImage, _ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double, _ thickness : Double, _ color : inout RGBA) -> Void{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var thickness = thickness;
	DrawLineBresenhamsAlgorithmThick(&canvas, x1, y1, x2, y2, thickness, &color)
}


func DrawLineBresenhamsAlgorithmThick(_ canvas : inout RGBABitmapImage, _ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double, _ thickness : Double, _ color : inout RGBA) -> Void{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var thickness = thickness;
	var x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r : Double

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = abs(dx)
	dy = abs(dy)

	if(dx > dy){
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	}else{
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	}

	x = x1
	y = y1
	err = el/2.0

	if(thickness >= 3.0){
		r = thickness/2.0
		DrawCircle(&canvas, x, y, r, &color)
	}else if(floor(thickness) == 2.0){
		DrawFilledRectangle(&canvas, x, y, 2.0, 2.0, &color)
	}else if(floor(thickness) == 1.0){
		DrawPixel(&canvas, x, y, &color)
	}

	t = 0.0
	while(t < el){
		err = err - es
		if(err < 0.0){
			err = err + el
			x = x + incX
			y = y + incY
		}else{
			x = x + pdx
			y = y + pdy
		}

		if(thickness >= 3.0){
			r = thickness/2.0
			DrawCircle(&canvas, x, y, r, &color)
		}else if(floor(thickness) == 2.0){
			DrawFilledRectangle(&canvas, x, y, 2.0, 2.0, &color)
		}else if(floor(thickness) == 1.0){
			DrawPixel(&canvas, x, y, &color)
		}
		t = t + 1.0
	}
}


func DrawLineBresenhamsAlgorithm(_ canvas : inout RGBABitmapImage, _ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double, _ color : inout RGBA) -> Void{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t : Double

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = abs(dx)
	dy = abs(dy)

	if(dx > dy){
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	}else{
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	}

	x = x1
	y = y1
	err = el/2.0
	DrawPixel(&canvas, x, y, &color)

	t = 0.0
	while(t < el){
		err = err - es
		if(err < 0.0){
			err = err + el
			x = x + incX
			y = y + incY
		}else{
			x = x + pdx
			y = y + pdy
		}

		DrawPixel(&canvas, x, y, &color)
		t = t + 1.0
	}
}


func DrawLineBresenhamsAlgorithmThickPatterned(_ canvas : inout RGBABitmapImage, _ x1 : Double, _ y1 : Double, _ x2 : Double, _ y2 : Double, _ thickness : Double, _ pattern : inout [Bool], _ offset : inout NumberReference, _ color : inout RGBA) -> Void{
	var x1 = x1;
	var y1 = y1;
	var x2 = x2;
	var y2 = y2;
	var thickness = thickness;
	var x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r : Double

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = abs(dx)
	dy = abs(dy)

	if(dx > dy){
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	}else{
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	}

	x = x1
	y = y1
	err = el/2.0

	offset.numberValue = (offset.numberValue + 1.0).truncatingRemainder(dividingBy:Double(pattern.count)*thickness)

	if(pattern[Int(floor(offset.numberValue/thickness))]){
		if(thickness >= 3.0){
			r = thickness/2.0
			DrawCircle(&canvas, x, y, r, &color)
		}else if(floor(thickness) == 2.0){
			DrawFilledRectangle(&canvas, x, y, 2.0, 2.0, &color)
		}else if(floor(thickness) == 1.0){
			DrawPixel(&canvas, x, y, &color)
		}
	}

	t = 0.0
	while(t < el){
		err = err - es
		if(err < 0.0){
			err = err + el
			x = x + incX
			y = y + incY
		}else{
			x = x + pdx
			y = y + pdy
		}

		offset.numberValue = (offset.numberValue + 1.0).truncatingRemainder(dividingBy:Double(pattern.count)*thickness)

		if(pattern[Int(floor(offset.numberValue/thickness))]){
			if(thickness >= 3.0){
				r = thickness/2.0
				DrawCircle(&canvas, x, y, r, &color)
			}else if(floor(thickness) == 2.0){
				DrawFilledRectangle(&canvas, x, y, 2.0, 2.0, &color)
			}else if(floor(thickness) == 1.0){
				DrawPixel(&canvas, x, y, &color)
			}
		}
		t = t + 1.0
	}
}


func GetLinePattern5() -> [Bool]{
	var pattern : [Bool]

	pattern = Array(repeating:Bool(), count: Int(19))

	pattern[Int(0)] = true
	pattern[Int(1)] = true
	pattern[Int(2)] = true
	pattern[Int(3)] = true
	pattern[Int(4)] = true
	pattern[Int(5)] = true
	pattern[Int(6)] = true
	pattern[Int(7)] = true
	pattern[Int(8)] = true
	pattern[Int(9)] = true
	pattern[Int(10)] = false
	pattern[Int(11)] = false
	pattern[Int(12)] = false
	pattern[Int(13)] = true
	pattern[Int(14)] = true
	pattern[Int(15)] = true
	pattern[Int(16)] = false
	pattern[Int(17)] = false
	pattern[Int(18)] = false

	return pattern
}


func GetLinePattern4() -> [Bool]{
	var pattern : [Bool]

	pattern = Array(repeating:Bool(), count: Int(13))

	pattern[Int(0)] = true
	pattern[Int(1)] = true
	pattern[Int(2)] = true
	pattern[Int(3)] = true
	pattern[Int(4)] = true
	pattern[Int(5)] = true
	pattern[Int(6)] = true
	pattern[Int(7)] = true
	pattern[Int(8)] = true
	pattern[Int(9)] = true
	pattern[Int(10)] = false
	pattern[Int(11)] = false
	pattern[Int(12)] = false

	return pattern
}


func GetLinePattern3() -> [Bool]{
	var pattern : [Bool]

	pattern = Array(repeating:Bool(), count: Int(13))

	pattern[Int(0)] = true
	pattern[Int(1)] = true
	pattern[Int(2)] = true
	pattern[Int(3)] = true
	pattern[Int(4)] = true
	pattern[Int(5)] = true
	pattern[Int(6)] = false
	pattern[Int(7)] = false
	pattern[Int(8)] = false
	pattern[Int(9)] = true
	pattern[Int(10)] = true
	pattern[Int(11)] = false
	pattern[Int(12)] = false

	return pattern
}


func GetLinePattern2() -> [Bool]{
	var pattern : [Bool]

	pattern = Array(repeating:Bool(), count: Int(4))

	pattern[Int(0)] = true
	pattern[Int(1)] = true
	pattern[Int(2)] = false
	pattern[Int(3)] = false

	return pattern
}


func GetLinePattern1() -> [Bool]{
	var pattern : [Bool]

	pattern = Array(repeating:Bool(), count: Int(8))

	pattern[Int(0)] = true
	pattern[Int(1)] = true
	pattern[Int(2)] = true
	pattern[Int(3)] = true
	pattern[Int(4)] = true
	pattern[Int(5)] = false
	pattern[Int(6)] = false
	pattern[Int(7)] = false

	return pattern
}


func Blur(_ src : inout RGBABitmapImage, _ pixels : Double) -> RGBABitmapImageReferenceClass{
	var pixels = pixels;
	var dst : RGBABitmapImage
	var x, y, w, h : Double

	w = ImageWidth(&src)
	h = ImageHeight(&src)
	dst = CreateImage(w, h, &GetTransparent().ref).ref

	x = 0.0
	while(x < w){
		y = 0.0
		while(y < h){
			SetPixel(&dst, x, y, &CreateBlurForPoint(&src, x, y, pixels).ref)
			y = y + 1.0
		}
		x = x + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func CreateBlurForPoint(_ src : inout RGBABitmapImage, _ x : Double, _ y : Double, _ pixels : Double) -> RGBAReferenceClass{
	var x = x;
	var y = y;
	var pixels = pixels;
	var rgba : RGBA
	var i, j, countColor, countTransparent : Double
	var fromx, tox, fromy, toy : Double
	var w, h : Double
	var alpha : Double

	w = ImageWidth(&src)
	h = ImageHeight(&src)

	rgba = RGBA()
	rgba.r = 0.0
	rgba.g = 0.0
	rgba.b = 0.0
	rgba.a = 0.0

	fromx = x - pixels
	fromx = max(fromx, 0.0)

	tox = x + pixels
	tox = min(tox, w - 1.0)

	fromy = y - pixels
	fromy = max(fromy, 0.0)

	toy = y + pixels
	toy = min(toy, h - 1.0)

	countColor = 0.0
	countTransparent = 0.0
	i = fromx
	while(i < tox){
		j = fromy
		while(j < toy){
			alpha = src.x[Int(i)].y[Int(j)].a
			if(alpha > 0.0){
				rgba.r = rgba.r + src.x[Int(i)].y[Int(j)].r
				rgba.g = rgba.g + src.x[Int(i)].y[Int(j)].g
				rgba.b = rgba.b + src.x[Int(i)].y[Int(j)].b
				countColor = countColor + 1.0
			}
			rgba.a = rgba.a + alpha
			countTransparent = countTransparent + 1.0
			j = j + 1.0
		}
		i = i + 1.0
	}

	if(countColor > 0.0){
		rgba.r = rgba.r/countColor
		rgba.g = rgba.g/countColor
		rgba.b = rgba.b/countColor
	}else{
		rgba.r = 0.0
		rgba.g = 0.0
		rgba.b = 0.0
	}

	if(countTransparent > 0.0){
		rgba.a = rgba.a/countTransparent
	}else{
		rgba.a = 0.0
	}

	var returnReference = RGBAReferenceClass()
	returnReference.ref = rgba
	return returnReference
}


func ScaleNearestNeighborFloorFactor(_ src : inout RGBABitmapImage, _ factor : Double) -> RGBABitmapImageReferenceClass{
	var factor = factor;
	var dst : RGBABitmapImage
	var w, h, newWidth, newHeight : Double

	w = ImageWidth(&src)
	h = ImageHeight(&src)

	newWidth = Roundx(w*factor)
	newHeight = Roundx(h*factor)

	dst = ScaleNearestNeighborFloor(&src, newWidth, newHeight).ref

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func ScaleNearestNeighborFloor(_ src : inout RGBABitmapImage, _ newWidth : Double, _ newHeight : Double) -> RGBABitmapImageReferenceClass{
	var newWidth = newWidth;
	var newHeight = newHeight;
	var dst : RGBABitmapImage
	var x, y : Double

	dst = CreateImage(newWidth, newHeight, &GetTransparent().ref).ref

	x = 0.0
	while(x < newWidth){
		y = 0.0
		while(y < newHeight){
			SetPixel(&dst, x, y, &GetNearestNeighborFloor(&src, &dst, x, y).ref)
			y = y + 1.0
		}
		x = x + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func GetNearestNeighborFloor(_ src : inout RGBABitmapImage, _ dst : inout RGBABitmapImage, _ x : Double, _ y : Double) -> RGBAReferenceClass{
	var x = x;
	var y = y;
	var nnx, nny, srcw, srch, dstw, dsth : Double

	srcw = ImageWidth(&src)
	srch = ImageHeight(&src)
	dstw = ImageWidth(&dst)
	dsth = ImageHeight(&dst)

	nnx = floor(x*srcw/dstw)
	nny = floor(y*srch/dsth)

	var returnReference = RGBAReferenceClass()
	returnReference.ref = src.x[Int(nnx)].y[Int(nny)]
	return returnReference
}


func ScaleNearestNeighborFactor(_ src : inout RGBABitmapImage, _ factor : Double) -> RGBABitmapImageReferenceClass{
	var factor = factor;
	var dst : RGBABitmapImage
	var w, h, newWidth, newHeight : Double

	w = ImageWidth(&src)
	h = ImageHeight(&src)

	newWidth = Roundx(w*factor)
	newHeight = Roundx(h*factor)

	dst = ScaleNearestNeighbor(&src, newWidth, newHeight).ref

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func ScaleNearestNeighbor(_ src : inout RGBABitmapImage, _ newWidth : Double, _ newHeight : Double) -> RGBABitmapImageReferenceClass{
	var newWidth = newWidth;
	var newHeight = newHeight;
	var dst : RGBABitmapImage
	var x, y : Double

	dst = CreateImage(newWidth, newHeight, &GetTransparent().ref).ref

	x = 0.0
	while(x < newWidth){
		y = 0.0
		while(y < newHeight){
			SetPixel(&dst, x, y, &GetNearestNeighbor(&src, &dst, x, y).ref)
			y = y + 1.0
		}
		x = x + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func GetNearestNeighbor(_ src : inout RGBABitmapImage, _ dst : inout RGBABitmapImage, _ x : Double, _ y : Double) -> RGBAReferenceClass{
	var x = x;
	var y = y;
	var nnx, nny, srcw, srch, dstw, dsth : Double

	srcw = ImageWidth(&src)
	srch = ImageHeight(&src)
	dstw = ImageWidth(&dst)
	dsth = ImageHeight(&dst)

	nnx = min(Roundx(x*srcw/dstw), srcw - 1.0)
	nny = min(Roundx(y*srch/dsth), srch - 1.0)

	var returnReference = RGBAReferenceClass()
	returnReference.ref = src.x[Int(nnx)].y[Int(nny)]
	return returnReference
}


func BilinaerScaleUpFactor(_ src : inout RGBABitmapImage, _ factor : Double) -> RGBABitmapImageReferenceClass{
	var factor = factor;
	var dst : RGBABitmapImage
	var w, h, newWidth, newHeight : Double

	w = ImageWidth(&src)
	h = ImageHeight(&src)

	newWidth = Roundx(w*factor)
	newHeight = Roundx(h*factor)

	dst = BilinaerScaleUp(&src, newWidth, newHeight).ref

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func BilinaerScaleUp(_ src : inout RGBABitmapImage, _ newWidth : Double, _ newHeight : Double) -> RGBABitmapImageReferenceClass{
	var newWidth = newWidth;
	var newHeight = newHeight;
	var dst : RGBABitmapImage
	var x, y : Double

	dst = CreateImage(newWidth, newHeight, &GetTransparent().ref).ref

	y = 0.0
	while(y < newHeight){
		x = 0.0
		while(x < newWidth){
			SetPixel(&dst, x, y, &GetBilinearlyScaledPixel(&src, &dst, x, y).ref)
			x = x + 1.0
		}
		y = y + 1.0
	}

	var returnReference = RGBABitmapImageReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func GetBilinearlyScaledPixel(_ src : inout RGBABitmapImage, _ dst : inout RGBABitmapImage, _ dstx : Double, _ dsty : Double) -> RGBAReferenceClass{
	var dstx = dstx;
	var dsty = dsty;
	var x1, y1, x2, y2, srcw, srch, dstw, dsth : Double
	var x1y1, x2y1, x1y2, x2y2 : RGBA
	var result : RGBA
	var x, y : Double

	srcw = ImageWidth(&src)
	srch = ImageHeight(&src)
	dstw = ImageWidth(&dst)
	dsth = ImageHeight(&dst)

	x = dstx*srcw/dstw
	y = dsty*srch/dsth

	x = x + 0.25
	y = y + 0.25

	x1 = min(floor(x), srcw - 1.0)
	x2 = min(ceil(x), srcw - 1.0)
	y1 = min(floor(y), srch - 1.0)
	y2 = min(ceil(y), srch - 1.0)

	x1y1 = src.x[Int(x1)].y[Int(y1)]
	x1y2 = src.x[Int(x1)].y[Int(y2)]
	x2y1 = src.x[Int(x2)].y[Int(y1)]
	x2y2 = src.x[Int(x2)].y[Int(y2)]

	if(x1 == x2){
		x2 = x2 + 1.0
	}
	if(y1 == y2){
		y2 = y2 + 1.0
	}

	result = RGBA()

	result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2)
	result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2)
	result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2)
	result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2)

	var returnReference = RGBAReferenceClass()
	returnReference.ref = result
	return returnReference
}


func GetBilinearInterpolation(_ q11 : Double, _ q12 : Double, _ q21 : Double, _ q22 : Double, _ x : Double, _ y : Double, _ x1 : Double, _ x2 : Double, _ y1 : Double, _ y2 : Double) -> Double{
	var q11 = q11;
	var q12 = q12;
	var q21 = q21;
	var q22 = q22;
	var x = x;
	var y = y;
	var x1 = x1;
	var x2 = x2;
	var y1 = y1;
	var y2 = y2;
	var h1, h2, v : Double

	h1 = (x2 - x)/(x2 - x1)*q11 + (x - x1)/(x2 - x1)*q12
	h2 = (x2 - x)/(x2 - x1)*q21 + (x - x1)/(x2 - x1)*q22

	v = (y2 - y)/(y2 - y1)*h1 + (y - y1)/(y2 - y1)*h2

	return v
}


func Negate(_ x : Double) -> Double{
	var x = x;
	return -x
}


func Positive(_ x : Double) -> Double{
	var x = x;
	return +x
}


func Factorial(_ x : Double) -> Double{
	var x = x;
	var i, f : Double

	f = 1.0

	i = 2.0
	while(i <= x){
		f = f*i
		i = i + 1.0
	}

	return f
}


func Roundx(_ x : Double) -> Double{
	var x = x;
	return floor(x + 0.5)
}


func RoundToDigits(_ element : Double, _ digitsAfterPoint : Double) -> Double{
	var element = element;
	var digitsAfterPoint = digitsAfterPoint;
	return Roundx(element*pow(10.0, digitsAfterPoint))/pow(10.0, digitsAfterPoint)
}


func BankersRound(_ x : Double) -> Double{
	var x = x;
	var r : Double

	if(Absolute(x - Truncate(x)) == 0.5){
		if(!DivisibleBy(Roundx(x), 2.0)){
			r = Roundx(x) - 1.0
		}else{
			r = Roundx(x)
		}
	}else{
		r = Roundx(x)
	}

	return r
}


func Ceil(_ x : Double) -> Double{
	var x = x;
	return ceil(x)
}


func Floorx(_ x : Double) -> Double{
	var x = x;
	return floor(x)
}


func Truncate(_ x : Double) -> Double{
	var x = x;
	var t : Double

	if(x >= 0.0){
		t = floor(x)
	}else{
		t = ceil(x)
	}

	return t
}


func Absolute(_ x : Double) -> Double{
	var x = x;
	return abs(x)
}


func Logarithm(_ x : Double) -> Double{
	var x = x;
	return log10(x)
}


func NaturalLogarithm(_ x : Double) -> Double{
	var x = x;
	return log(x)
}


func Sinx(_ x : Double) -> Double{
	var x = x;
	return sin(x)
}


func Cosx(_ x : Double) -> Double{
	var x = x;
	return cos(x)
}


func Tanx(_ x : Double) -> Double{
	var x = x;
	return tan(x)
}


func Asinx(_ x : Double) -> Double{
	var x = x;
	return asin(x)
}


func Acosx(_ x : Double) -> Double{
	var x = x;
	return acos(x)
}


func Atanx(_ x : Double) -> Double{
	var x = x;
	return atan(x)
}


func Atan2(_ y : Double, _ x : Double) -> Double{
	var y = y;
	var x = x;
	var a : Double

	/* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.*/
	a = 0.0

	if(x > 0.0){
		a = Atanx(y/x)
	}else if(x < 0.0 && y >= 0.0){
		a = Atanx(y/x) + Double.pi
	}else if(x < 0.0 && y < 0.0){
		a = Atanx(y/x) - Double.pi
	}else if(x == 0.0 && y > 0.0){
		a = Double.pi/2.0
	}else if(x == 0.0 && y < 0.0){
		a = -Double.pi/2.0
	}

	return a
}


func Squareroot(_ x : Double) -> Double{
	var x = x;
	return sqrt(x)
}


func Expx(_ x : Double) -> Double{
	var x = x;
	return exp(x)
}


func DivisibleBy(_ a : Double, _ b : Double) -> Bool{
	var a = a;
	var b = b;
	return ((a.truncatingRemainder(dividingBy:b)) == 0.0)
}


func Combinations(_ n : Double, _ k : Double) -> Double{
	var n = n;
	var k = k;
	var i, j, c : Double

	c = 1.0
	j = 1.0
	i = n - k + 1.0

	while(i <= n){
		c = c*i
		c = c/j

		i = i + 1.0
		j = j + 1.0
	}

	return c
}


func Permutations(_ n : Double, _ k : Double) -> Double{
	var n = n;
	var k = k;
	var i, c : Double

	c = 1.0

	i = n - k + 1.0
	while(i <= n){
		c = c*i
		i = i + 1.0
	}

	return c
}


func EpsilonCompare(_ a : Double, _ b : Double, _ epsilon : Double) -> Bool{
	var a = a;
	var b = b;
	var epsilon = epsilon;
	return abs(a - b) < epsilon
}


func GreatestCommonDivisor(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var t : Double

	while(b != 0.0){
		t = b
		b = a.truncatingRemainder(dividingBy:b)
		a = t
	}

	return a
}


func GCDWithSubtraction(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var g : Double

	if(a == 0.0){
		g = b
	}else{
		while(b != 0.0){
			if(a > b){
				a = a - b
			}else{
				b = b - a
			}
		}

		g = a
	}

	return g
}


func IsInteger(_ a : Double) -> Bool{
	var a = a;
	return (a - floor(a)) == 0.0
}


func GreatestCommonDivisorWithCheck(_ a : Double, _ b : Double, _ gcdReference : inout NumberReference) -> Bool{
	var a = a;
	var b = b;
	var success : Bool
	var gcd : Double

	if(IsInteger(a) && IsInteger(b)){
		gcd = GreatestCommonDivisor(a, b)
		gcdReference.numberValue = gcd
		success = true
	}else{
		success = false
	}

	return success
}


func LeastCommonMultiple(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var lcm : Double

	if(a > 0.0 && b > 0.0){
		lcm = abs(a*b)/GreatestCommonDivisor(a, b)
	}else{
		lcm = 0.0
	}

	return lcm
}


func Sign(_ a : Double) -> Double{
	var a = a;
	var s : Double

	if(a > 0.0){
		s = 1.0
	}else if(a < 0.0){
		s = -1.0
	}else{
		s = 0.0
	}

	return s
}


func Max(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return max(a, b)
}


func Min(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return min(a, b)
}


func Power(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return pow(a, b)
}


func Gamma(_ x : Double) -> Double{
	var x = x;
	return LanczosApproximation(x)
}


func LogGamma(_ x : Double) -> Double{
	var x = x;
	return log(Gamma(x))
}


func LanczosApproximation(_ z : Double) -> Double{
	var z = z;
	var p : [Double]
	var i, y, t, x : Double

	p = Array(repeating:Double(), count: Int(8))
	p[Int(0)] = 676.5203681218851
	p[Int(1)] = -1259.1392167224028
	p[Int(2)] = 771.32342877765313
	p[Int(3)] = -176.61502916214059
	p[Int(4)] = 12.507343278686905
	p[Int(5)] = -0.13857109526572012
	p[Int(6)] = 9.9843695780195716e-6
	p[Int(7)] = 1.5056327351493116e-7

	if(z < 0.5){
		y = Double.pi/(sin(Double.pi*z)*LanczosApproximation(1.0 - z))
	}else{
		z = z - 1.0
		x = 0.99999999999980993
		i = 0.0
		while(i < Double(p.count)){
			x = x + p[Int(i)]/(z + i + 1.0)
			i = i + 1.0
		}
		t = z + Double(p.count) - 0.5
		y = sqrt(2.0*Double.pi)*pow(t, z + 0.5)*exp(-t)*x
	}

	return y
}


func Beta(_ x : Double, _ y : Double) -> Double{
	var x = x;
	var y = y;
	return Gamma(x)*Gamma(y)/Gamma(x + y)
}


func Sinh(_ x : Double) -> Double{
	var x = x;
	return (exp(x) - exp(-x))/2.0
}


func Cosh(_ x : Double) -> Double{
	var x = x;
	return (exp(x) + exp(-x))/2.0
}


func Tanh(_ x : Double) -> Double{
	var x = x;
	return Sinh(x)/Cosh(x)
}


func Cot(_ x : Double) -> Double{
	var x = x;
	return 1.0/tan(x)
}


func Sec(_ x : Double) -> Double{
	var x = x;
	return 1.0/cos(x)
}


func Csc(_ x : Double) -> Double{
	var x = x;
	return 1.0/sin(x)
}


func Coth(_ x : Double) -> Double{
	var x = x;
	return Cosh(x)/Sinh(x)
}


func Sech(_ x : Double) -> Double{
	var x = x;
	return 1.0/Cosh(x)
}


func Csch(_ x : Double) -> Double{
	var x = x;
	return 1.0/Sinh(x)
}


func Error(_ x : Double) -> Double{
	var x = x;
	var y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 : Double

	if(x == 0.0){
		y = 0.0
	}else if(x < 0.0){
		y = -Error(-x)
	}else{
		c1 = -1.26551223
		c2 = +1.00002368
		c3 = +0.37409196
		c4 = +0.09678418
		c5 = -0.18628806
		c6 = +0.27886807
		c7 = -1.13520398
		c8 = +1.48851587
		c9 = -0.82215223
		c10 = +0.17087277

		t = 1.0/(1.0 + 0.5*abs(x))

		tau = t*exp(-pow(x, 2.0) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))))

		y = 1.0 - tau
	}

	return y
}


func ErrorInverse(_ x : Double) -> Double{
	var x = x;
	var y, a, t : Double

	a = (8.0*(Double.pi - 3.0))/(3.0*Double.pi*(4.0 - Double.pi))

	t = 2.0/(Double.pi*a) + log(1.0 - pow(x, 2.0))/2.0
	y = Sign(x)*sqrt(sqrt(pow(t, 2.0) - log(1.0 - pow(x, 2.0))/a) - t)

	return y
}


func FallingFactorial(_ x : Double, _ n : Double) -> Double{
	var x = x;
	var n = n;
	var k, y : Double

	y = 1.0

	k = 0.0
	while(k <= n - 1.0){
		y = y*(x - k)
		k = k + 1.0
	}

	return y
}


func RisingFactorial(_ x : Double, _ n : Double) -> Double{
	var x = x;
	var n = n;
	var k, y : Double

	y = 1.0

	k = 0.0
	while(k <= n - 1.0){
		y = y*(x + k)
		k = k + 1.0
	}

	return y
}


func Hypergeometric(_ a : Double, _ b : Double, _ c : Double, _ z : Double, _ maxIterations : Double, _ precision : Double) -> Double{
	var a = a;
	var b = b;
	var c = c;
	var z = z;
	var maxIterations = maxIterations;
	var precision = precision;
	var y : Double

	if(abs(z) >= 0.5){
		y = pow(1.0 - z, -a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision)
	}else{
		y = HypergeometricDirect(a, b, c, z, maxIterations, precision)
	}

	return y
}


func HypergeometricDirect(_ a : Double, _ b : Double, _ c : Double, _ z : Double, _ maxIterations : Double, _ precision : Double) -> Double{
	var a = a;
	var b = b;
	var c = c;
	var z = z;
	var maxIterations = maxIterations;
	var precision = precision;
	var y, yp, n : Double
	var done : Bool

	y = 0.0
	done = false

	n = 0.0
	while(n < maxIterations && !done){
		yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*pow(z, n)/Factorial(n)
		if(abs(yp) < precision){
			done = true
		}
		y = y + yp
		n = n + 1.0
	}

	return y
}


func BernouilliNumber(_ n : Double) -> Double{
	var n = n;
	return AkiyamaTanigawaAlgorithm(n)
}


func AkiyamaTanigawaAlgorithm(_ n : Double) -> Double{
	var n = n;
	var m, j, B : Double
	var A : [Double]

	A = Array(repeating:Double(), count: Int(n + 1.0))

	m = 0.0
	while(m <= n){
		A[Int(m)] = 1.0/(m + 1.0)
		j = m
		while(j >= 1.0){
			A[Int(j - 1.0)] = j*(A[Int(j - 1.0)] - A[Int(j)])
			j = j - 1.0
		}
		m = m + 1.0
	}

	B = A[Int(0)]

	delete(A)

	return B
}


func D15Add(_ a : Double, _ b : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	x = a + b

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func RoundTo15Digits(_ x : Double) -> Double{
	var x = x;
	var p : Double

	p = floor(log10(x))
	x = x*pow(10.0, 15.0 - p)
	x = Roundx(x)
	x = x/pow(10.0, 15.0 - p)

	return x
}


func D15MaxValue() -> Double{
	return +9.99999999999999e99
}


func D15MinValue() -> Double{
	return -9.99999999999999e99
}


func D15Multiply(_ a : Double, _ b : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	x = a*b

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Divide(_ a : Double, _ b : Double, _ reminder : inout NumberReference, _ overflow : inout BooleanReference, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x, r : Double

	if(b != 0.0){
		invalidOperation.booleanValue = false

		x = a/b
		r = a.truncatingRemainder(dividingBy:b)

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true
			x = 0.0
			r = 0.0
		}else{
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
			r = RoundTo15Digits(r)
		}
	}else{
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
		r = 0.0
	}

	reminder.numberValue = r

	return x
}


func D15Exponentiation(_ a : Double, _ b : Double, _ overflow : inout BooleanReference, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	if(a == 0.0 && b == 0.0){
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	}else if(a < 0.0 && !IsInteger(b)){
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	}else{
		invalidOperation.booleanValue = false

		x = pow(a, b)

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true
			x = 0.0
		}else{
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		}
	}

	return x
}


func D15Modulus(_ a : Double, _ b : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	if(a < 0.0 || b == 0.0 || b < 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = a.truncatingRemainder(dividingBy:b)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Logarithm(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a <= 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = log10(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15NaturalLogarithm(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a <= 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = log(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Sin(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = sin(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Cos(_ x : Double) -> Double{
	var x = x;
	var a, y, piBy2Part1, piBy2Part2, limit, f : Double

	x = abs(x)

	limit = Double.pi + 3.1/2.0

	if(x > limit){
		f = floor(x/Double.pi)
		x = x - Double.pi*f
	}

	piBy2Part1 = +1.57079632679490
	piBy2Part2 = -3.38076867830836e-15

	if(x > 3.1/2.0 && x < 3.3/2.0){
		a = x - piBy2Part1
		a = round(a*pow(10.0, 15.0))/pow(10.0, 15.0)
		a = a - piBy2Part2
		y = -sin(a)
	}else{
		y = cos(x)
		y = RoundTo15Digits(y)
	}

	return y
}


func D15Tan(_ a : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	x = tan(a)

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Asin(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a < -1.0 || a > 1.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = asin(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Acos(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a < -1.0 || a > 1.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = acos(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Atan(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = atan(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Sqrt(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = sqrt(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Exponential(_ a : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	x = exp(a)

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func Decimal15E2ToString(_ decimalx : Double) -> [Character]{
	var decimalx = decimalx;
	var multiplier, inc, i, d : Double
	var exponent : Double
	var done, isPositive, isPositiveExponent : Bool
	var result : [Character]
	var len : Double

	len = 21.0
	/* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"*/
	result = Array(repeating:Character(" "), count: Int(len))

	done = false
	exponent = 0.0

	if(decimalx < 0.0){
		isPositive = false
		decimalx = -decimalx
	}else{
		isPositive = true
	}

	if(decimalx == 0.0){
		done = true
	}

	if(!done){
		multiplier = 0.0
		inc = 0.0

		if(decimalx < 1.0){
			multiplier = 10.0
			inc = -1.0
		}else if(decimalx >= 10.0){
			multiplier = 0.1
			inc = 1.0
		}else{
			done = true
		}

		if(!done){
			exponent = round(log10(decimalx))
			exponent = min(99.0, exponent)
			exponent = max(-99.0, exponent)

			decimalx = decimalx/pow(10.0, exponent)

			/* Adjust*/
			while((decimalx >= 10.0 || decimalx < 1.0) && abs(exponent) < 99.0){
				decimalx = decimalx*multiplier
				exponent = exponent + inc
			}
		}
	}

	isPositiveExponent = exponent >= 0.0
	if(!isPositiveExponent){
		exponent = -exponent
	}

	if(isPositive){
		result[Int(0)] = "+"
	}else{
		result[Int(0)] = "-"
	}

	decimalx = round(decimalx*pow(10.0, 14.0))

	d = floor(decimalx/pow(10.0, 14.0))
	result[Int(1)] = SingleDigitNumberToCharacter(d)
	decimalx = decimalx - d*pow(10.0, 14.0)

	result[Int(2)] = "."

	i = 0.0
	while(i < 14.0){
		d = floor(decimalx/pow(10.0, 13.0 - i))
		result[Int(3.0 + i)] = SingleDigitNumberToCharacter(d)
		decimalx = decimalx - d*pow(10.0, 13.0 - i)
		i = i + 1.0
	}

	result[Int(17)] = "e"

	if(isPositiveExponent){
		result[Int(18)] = "+"
	}else{
		result[Int(18)] = "-"
	}

	result[Int(19)] = SingleDigitNumberToCharacter(floor(exponent/10.0))
	result[Int(20)] = SingleDigitNumberToCharacter(floor(exponent.truncatingRemainder(dividingBy:10.0)))

	return result
}


func SingleDigitNumberToCharacter(_ n : Double) -> Character{
	var n = n;
	var c : Character

	c = "0"
	if(n == 0.0){
		c = "0"
	}else if(n == 1.0){
		c = "1"
	}else if(n == 2.0){
		c = "2"
	}else if(n == 3.0){
		c = "3"
	}else if(n == 4.0){
		c = "4"
	}else if(n == 5.0){
		c = "5"
	}else if(n == 6.0){
		c = "6"
	}else if(n == 7.0){
		c = "7"
	}else if(n == 8.0){
		c = "8"
	}else if(n == 9.0){
		c = "9"
	}

	return c
}


func DigitDataBase16() -> [Character]{
	return characterArray("ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe891412108153069c4ffffffffffffffffffffffffffffffffffffffff9409000000000000000049e7ffffffffffffffffffffffffffffffffff61000000000000000000000017ddffffffffffffffffffffffffffffff840000000573d3f5e5a62b00000028f0ffffffffffffffffffffffffffda04000008bcfffffffffff44200000073ffffffffffffffffffffffffff5700000088ffffffffffffffe812000008e3ffffffffffffffffffffffea02000015f9ffffffffffffffff8100000080ffffffffffffffffffffff9c00000072ffffffffffffffffffe40100002fffffffffffffffffffffff51000000b8ffffffffffffffffffff2a000000e2ffffffffffffffffffff21000001f0ffffffffffffffffffff65000000b3fffffffffffffffffff602000018ffffffffffffffffffffff8b0000008affffffffffffffffffd200000036ffffffffffffffffffffffa900000063ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffb500000057ffffffffffffffffffffffc900000046ffffffffffffffffffa90000005fffffffffffffffffffffffd20000003affffffffffffffffffa900000060ffffffffffffffffffffffd30000003affffffffffffffffffb400000057ffffffffffffffffffffffca00000046ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffd100000037ffffffffffffffffffffffa900000063fffffffffffffffffff602000019ffffffffffffffffffffff8b00000089ffffffffffffffffffff21000001f1ffffffffffffffffffff66000000b3ffffffffffffffffffff50000000b8ffffffffffffffffffff2a000000e1ffffffffffffffffffff9c00000073ffffffffffffffffffe40100002fffffffffffffffffffffffea02000015f9ffffffffffffffff8200000080ffffffffffffffffffffffff5700000088ffffffffffffffe812000008e2ffffffffffffffffffffffffda04000008bcfffffffffff44300000073ffffffffffffffffffffffffffff830000000674d3f6e6a72b00000028f0ffffffffffffffffffffffffffffff60000000000000000000000016ddfffffffffffffffffffffffffffffffffe9309000000000000000048e6ffffffffffffffffffffffffffffffffffffffe88f3f1f07132e68c3fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9d7b28e69441f02000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6a274c7095b9de64000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000affffffffffffffffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd48b56271005142a5ea0f6ffffffffffffffffffffffffffffffffdb7c20000000000000000000001392feffffffffffffffffffffffffffff1f00000000000000000000000000004cf9ffffffffffffffffffffffffff1f0000003784c7e7f9e8b1480000000056ffffffffffffffffffffffffff1f015accffffffffffffffff9701000000b0ffffffffffffffffffffffff58caffffffffffffffffffffff770000003cfffffffffffffffffffffffffffffffffffffffffffffffffff107000002edffffffffffffffffffffffffffffffffffffffffffffffffff3a000000ccffffffffffffffffffffffffffffffffffffffffffffffffff4c000000baffffffffffffffffffffffffffffffffffffffffffffffffff32000000cbffffffffffffffffffffffffffffffffffffffffffffffffec05000002edffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffeb140000009affffffffffffffffffffffffffffffffffffffffffffffff520000002afbffffffffffffffffffffffffffffffffffffffffffffff8c00000003c7ffffffffffffffffffffffffffffffffffffffffffffffb30300000085ffffffffffffffffffffffffffffffffffffffffffffffc50a0000005dfeffffffffffffffffffffffffffffffffffffffffffffd2110000004efbffffffffffffffffffffffffffffffffffffffffffffdb1800000042f8ffffffffffffffffffffffffffffffffffffffffffffe21f00000039f3ffffffffffffffffffffffffffffffffffffffffffffe92600000030efffffffffffffffffffffffffffffffffffffffffffffee2e00000029eafffffffffffffffffffffffffffffffffffffffffffff33700000022e5fffffffffffffffffffffffffffffffffffffffffffff7410000001cdffffffffffffffffffffffffffffffffffffffffffffffb4c00000017d9fffffffffffffffffffffffffffffffffffffffffffffd5900000012d2ffffffffffffffffffffffffffffffffffffffffffffff680000000ecbffffffffffffffffffffffffffffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe2af8058392817060a1a3f74c8ffffffffffffffffffffffffffffffffeb0000000000000000000000000036cfffffffffffffffffffffffffffffeb000000000000000000000000000004a7ffffffffffffffffffffffffffeb00000f5a9dd0edfbf0ca841900000003c2ffffffffffffffffffffffffec3da8f9fffffffffffffffff0410000002bffffffffffffffffffffffffffffffffffffffffffffffffffee12000000cbffffffffffffffffffffffffffffffffffffffffffffffffff6900000090ffffffffffffffffffffffffffffffffffffffffffffffffff9600000078ffffffffffffffffffffffffffffffffffffffffffffffffff9a0000007effffffffffffffffffffffffffffffffffffffffffffffffff73000000a5fffffffffffffffffffffffffffffffffffffffffffffffff51b000009edfffffffffffffffffffffffffffffffffffffffffffffff7540000007efffffffffffffffffffffffffffffffffffffffffff3d3912400000055fcffffffffffffffffffffffffffffffffff1700000000000000001692feffffffffffffffffffffffffffffffffffff17000000000000002db8feffffffffffffffffffffffffffffffffffffff170000000000000000002bc3fffffffffffffffffffffffffffffffffffffffffffdf0cf922e00000003a5fffffffffffffffffffffffffffffffffffffffffffffffffd8700000007d1ffffffffffffffffffffffffffffffffffffffffffffffffff780000004ffffffffffffffffffffffffffffffffffffffffffffffffffff308000006f6ffffffffffffffffffffffffffffffffffffffffffffffffff3c000000d0ffffffffffffffffffffffffffffffffffffffffffffffffff4d000000c6ffffffffffffffffffffffffffffffffffffffffffffffffff35000000ddffffffffffffffffffffffffffffffffffffffffffffffffea0300000bf9ffffffffffffffffffffffffffffffffffffffffffffffff6200000054ffffffffffffffffffffff47bafefffffffffffffffffff56b00000002cbffffffffffffffffffffff0b001e71a9d7edfbf6e4ba771a000000007cffffffffffffffffffffffff0b0000000000000000000000000000017dffffffffffffffffffffffffff0b000000000000000000000000003cc8ffffffffffffffffffffffffffffe9b989593827160608162a5689dbffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffbd0100000000f3fffffffffffffffffffffffffffffffffffffffffffff3200000000000f3ffffffffffffffffffffffffffffffffffffffffffff69000000000000f3ffffffffffffffffffffffffffffffffffffffffffbf01000b0e000000f3fffffffffffffffffffffffffffffffffffffffff42100008e1f000000f3ffffffffffffffffffffffffffffffffffffffff6a000035fc1f000000f3ffffffffffffffffffffffffffffffffffffffc0010004d1ff1f000000f3fffffffffffffffffffffffffffffffffffff42200007affff1f000000f3ffffffffffffffffffffffffffffffffffff6c000026f7ffff1f000000f3ffffffffffffffffffffffffffffffffffc1010001c1ffffff1f000000f3fffffffffffffffffffffffffffffffff523000066ffffffff1f000000f3ffffffffffffffffffffffffffffffff6d000019f0ffffffff1f000000f3ffffffffffffffffffffffffffffffc2010000aeffffffffff1f000000f3fffffffffffffffffffffffffffff524000052ffffffffffff1f000000f3ffffffffffffffffffffffffffff6e00000fe6ffffffffffff1f000000f3ffffffffffffffffffffffffffc30200009affffffffffffff1f000000f3fffffffffffffffffffffffff62400003ffeffffffffffffff1f000000f3ffffffffffffffffffffffff70000008daffffffffffffffff1f000000f3fffffffffffffffffffffff602000086ffffffffffffffffff1f000000f3fffffffffffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f000008672f120514275997efffffffffffffffffffffffffffffffffff4f00000000000000000000000b73f6ffffffffffffffffffffffffffffff4f000000000000000000000000002bdeffffffffffffffffffffffffffff60538cbad2e7faf0d599370000000025ebffffffffffffffffffffffffffffffffffffffffffffffffa0090000005bffffffffffffffffffffffffffffffffffffffffffffffffffb100000001d2ffffffffffffffffffffffffffffffffffffffffffffffffff560000007effffffffffffffffffffffffffffffffffffffffffffffffffb80000003dffffffffffffffffffffffffffffffffffffffffffffffffffec00000022fffffffffffffffffffffffffffffffffffffffffffffffffffd00000011ffffffffffffffffffffffffffffffffffffffffffffffffffec00000022ffffffffffffffffffffffffffffffffffffffffffffffffffb80000003cffffffffffffffffffffffffffffffffffffffffffffffffff580000007dffffffffffffffffffffffffffffffffffffffffffffffffb301000000cfffffffffffffffffffffff4cb1fdffffffffffffffffffa40a00000058ffffffffffffffffffffffff17001a6ea9d7eefbf2d69b380000000024e8ffffffffffffffffffffffff1700000000000000000000000000002de0ffffffffffffffffffffffffff17000000000000000000000000127ef9ffffffffffffffffffffffffffffebba8a59372615050a1a3569a6f7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffca753915050d233866a3e0ffffffffffffffffffffffffffffffffffd13f0000000000000000000000f7ffffffffffffffffffffffffffffff9d07000000000000000000000000f7ffffffffffffffffffffffffffff9700000000469fdbf3f5da9e490100f7ffffffffffffffffffffffffffca0300000eb3ffffffffffffffffd84df8fffffffffffffffffffffffffa2d000007c8ffffffffffffffffffffffffffffffffffffffffffffffff9100000081ffffffffffffffffffffffffffffffffffffffffffffffffff28000010f6ffffffffffffffffffffffffffffffffffffffffffffffffc20000006affffffffffffffffffffffffffffffffffffffffffffffffff79000000b2ffffffffffffffffffffffffffffffffffffffffffffffffff43000000ebffeb903d1a0616306fc0ffffffffffffffffffffffffffffff0f000015ffa211000000000000000041dcfffffffffffffffffffffffff30000003087000000000000000000000013c6ffffffffffffffffffffffe30000000f00000055beeef7d8881000000017e6ffffffffffffffffffffd30000000000019dffffffffffffe12200000056ffffffffffffffffffffd100000000006effffffffffffffffce04000002dbffffffffffffffffffdd0000000006eaffffffffffffffffff550000008bffffffffffffffffffe90000000043ffffffffffffffffffffa90000004dfffffffffffffffffff80200000074ffffffffffffffffffffdb0000002cffffffffffffffffffff2200000088ffffffffffffffffffffef00000019ffffffffffffffffffff4d00000088ffffffffffffffffffffee0000001affffffffffffffffffff7e00000074ffffffffffffffffffffdb0000002dffffffffffffffffffffcd00000042ffffffffffffffffffffa900000052ffffffffffffffffffffff21000005e9ffffffffffffffffff5400000093ffffffffffffffffffffff8f0000006dffffffffffffffffcd04000007e6fffffffffffffffffffffff9220000019effffffffffffe1230000006cffffffffffffffffffffffffffc00600000056beeff8d888110000002af3ffffffffffffffffffffffffffffa603000000000000000000000026ddffffffffffffffffffffffffffffffffc8280000000000000000025deffffffffffffffffffffffffffffffffffffffab25a2a1106193b7ed7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff47000000000000000000000000000000000000f7ffffffffffffffffffff47000000000000000000000000000000000003faffffffffffffffffffff4700000000000000000000000000000000004afffffffffffffffffffffffffffffffffffffffffffffffffc1a000000adffffffffffffffffffffffffffffffffffffffffffffffffb300000015faffffffffffffffffffffffffffffffffffffffffffffffff5100000073ffffffffffffffffffffffffffffffffffffffffffffffffea05000000d6ffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffff2c0000009dffffffffffffffffffffffffffffffffffffffffffffffffc90000000cf3ffffffffffffffffffffffffffffffffffffffffffffffff6700000063fffffffffffffffffffffffffffffffffffffffffffffffff60f000000c6ffffffffffffffffffffffffffffffffffffffffffffffffa300000029ffffffffffffffffffffffffffffffffffffffffffffffffff410000008cffffffffffffffffffffffffffffffffffffffffffffffffdf01000005e9ffffffffffffffffffffffffffffffffffffffffffffffff7d00000052fffffffffffffffffffffffffffffffffffffffffffffffffd1e000000b5ffffffffffffffffffffffffffffffffffffffffffffffffb90000001bfcffffffffffffffffffffffffffffffffffffffffffffffff570000007bffffffffffffffffffffffffffffffffffffffffffffffffee07000001ddffffffffffffffffffffffffffffffffffffffffffffffff9300000042ffffffffffffffffffffffffffffffffffffffffffffffffff31000000a5ffffffffffffffffffffffffffffffffffffffffffffffffd000000010f7ffffffffffffffffffffffffffffffffffffffffffffffff6d0000006bfffffffffffffffffffffffffffffffffffffffffffffffff913000000ceffffffffffffffffffffffffffffffffffffffffffffffffa900000031ffffffffffffffffffffffffffffffffffffffffffffffffff4700000094ffffffffffffffffffffffffffffffffffffffffffffffffe302000008eeffffffffffffffffffffffffffffffffffffffffffffffff840000005afffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9a8602c13050c1d4882dfffffffffffffffffffffffffffffffffffffa918000000000000000000025eeeffffffffffffffffffffffffffffff780000000000000000000000000023e5ffffffffffffffffffffffffff9f0000000037a8e4faf1c66d0500000033fdfffffffffffffffffffffff81600000065fdffffffffffffc40a0000009fffffffffffffffffffffffb600000021faffffffffffffffff8d00000047ffffffffffffffffffffff820000007bffffffffffffffffffeb01000014ffffffffffffffffffffff6d000000a2ffffffffffffffffffff15000001fdffffffffffffffffffff76000000a2ffffffffffffffffffff14000007ffffffffffffffffffffffa10000007bffffffffffffffffffec01000033ffffffffffffffffffffffec08000022fbffffffffffffffff8e00000087ffffffffffffffffffffffff7d00000068fdffffffffffffc70b00001ef2fffffffffffffffffffffffffb5500000039aae5fbf2c87006000013d0fffffffffffffffffffffffffffffe93160000000000000000000153e3ffffffffffffffffffffffffffffffffffbd2e000000000000000780f0ffffffffffffffffffffffffffffffffce3500000000000000000000000e87fcffffffffffffffffffffffffffb3060000004fb2e6faf0cd82150000004ffaffffffffffffffffffffffda0b000004a9ffffffffffffffe93600000076ffffffffffffffffffffff5600000084ffffffffffffffffffe80e000005e2fffffffffffffffffff606000008f4ffffffffffffffffffff6f0000008dffffffffffffffffffcb00000039ffffffffffffffffffffffac0000005cffffffffffffffffffbc0000004affffffffffffffffffffffbe0000004dffffffffffffffffffcc00000039ffffffffffffffffffffffac0000005effffffffffffffffffea00000008f4ffffffffffffffffffff6e0000007cffffffffffffffffffff2f00000085ffffffffffffffffffe70d000000c1ffffffffffffffffffff9300000004a9ffffffffffffffe83400000028fcfffffffffffffffffffffa2d0000000050b2e7fbf2cd821400000002b8ffffffffffffffffffffffffe523000000000000000000000000000299fffffffffffffffffffffffffffff16605000000000000000000002cc5ffffffffffffffffffffffffffffffffffe88e542512040b1b3d72c1fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8a259251008203f8be2ffffffffffffffffffffffffffffffffffffffa91d0000000000000000047ffaffffffffffffffffffffffffffffffff7b00000000000000000000000040f8ffffffffffffffffffffffffffff94000000004db9ecf7da8b1300000057ffffffffffffffffffffffffffdc050000008fffffffffffffe527000000acffffffffffffffffffffffff630000005fffffffffffffffffd406000025fbfffffffffffffffffffffb0c000002e0ffffffffffffffffff5f000000b2ffffffffffffffffffffc600000036ffffffffffffffffffffb50000005fffffffffffffffffffffa000000068ffffffffffffffffffffe700000011feffffffffffffffffff8d0000007cfffffffffffffffffffffb00000000dfffffffffffffffffff8c0000007cfffffffffffffffffffffb00000000b4ffffffffffffffffff9e00000069ffffffffffffffffffffe7000000008dffffffffffffffffffbe00000038ffffffffffffffffffffb6000000007bfffffffffffffffffff606000003e2ffffffffffffffffff62000000006fffffffffffffffffffff4f00000064ffffffffffffffffd8080000000062ffffffffffffffffffffc50000000096ffffffffffffe82b000000000064ffffffffffffffffffffff6c0000000051bbeff8dc8e1500001000000074fffffffffffffffffffffff94f0000000000000000000000288c00000084fffffffffffffffffffffffffd810b000000000000000052ea830000009fffffffffffffffffffffffffffffea8d471d090d2864c1ffff5b000000d4ffffffffffffffffffffffffffffffffffffffffffffffffff2100000dfdffffffffffffffffffffffffffffffffffffffffffffffffd900000052ffffffffffffffffffffffffffffffffffffffffffffffffff75000000b8ffffffffffffffffffffffffffffffffffffffffffffffffe30d000023fefffffffffffffffffffffffffffffffffffffffffffffff945000000b7ffffffffffffffffffffffffff7fa2fdffffffffffffffe8480000005effffffffffffffffffffffffffff63002080c4ecfae7c0740e00000034f4ffffffffffffffffffffffffffff6300000000000000000000000043f0ffffffffffffffffffffffffffffff6300000000000000000000118efdfffffffffffffffffffffffffffffffff4bb7f462b15040b25569ff4ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff").ca
}


func DrawDigitCharacter(_ image : inout RGBABitmapImage, _ topx : Double, _ topy : Double, _ digit : Double) -> Void{
	var topx = topx;
	var topy = topy;
	var digit = digit;
	var x, y : Double
	var allCharData, colorChars : [Character]
	var colorReference : NumberReference
	var errorMessage : StringReference
	var color : RGBA

	colorReference = NumberReference()
	errorMessage = StringReference()
	color = RGBA()

	colorChars = Array(repeating:Character(" "), count: Int(2))

	allCharData = DigitDataBase16()

	y = 0.0
	while(y < 37.0){
		x = 0.0
		while(x < 30.0){
			colorChars[Int(0)] = allCharData[Int(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 0.0)]
			colorChars[Int(1)] = allCharData[Int(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 1.0)]

			strToUpperCase(&colorChars)
			CreateNumberFromStringWithCheck(&colorChars, 16.0, &colorReference, &errorMessage)
			color.r = colorReference.numberValue/255.0
			color.g = colorReference.numberValue/255.0
			color.b = colorReference.numberValue/255.0
			color.a = 1.0
			SetPixel(&image, topx + x, topy + y, &color)
			x = x + 1.0
		}
		y = y + 1.0
	}
}


func GetPixelFontData() -> [Character]{
	return characterArray("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001100000011000000000000000000000011000000110000001100000011000000110000001100000011000000000000000000000000000000000000000000000000000000000000000000000000000011011000110110001101100011011000000000000000000000000000110011001100110111111110110011001100110111111110110011001100110000000000000000000000000000000000001100001111110111111111101100011111000011111100001111100011011111111110111111000011000000000000000000001110000110110001101101101110110000011000001100000110000011011101101101100011011000011100000000000000000111111100110001111110011000110110000111000001110000110110011001100110011001101100001110000000000000000000000000000000000000000000000000000000000000000000000000000011000001110000011000001110000000000000000000000110000000110000000110000001100000011000000110000001100000011000000110000011000001100000000000000000000000011000001100000110000001100000011000000110000001100000011000000110000000110000000110000000000000000000000000000000000100110010101101000111100111111110011110001011010100110010000000000000000000000000000000000000000000110000001100000011000111111111111111100011000000110000001100000000000000000000000000000000000000011000001100000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011111111111111110000000000000000000000000000000000000000000000000000000000000000000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000110000001100000110000001100000110000001100000110000001100000110000001100000110000001100000000000000000000000011110001100110110000111100011111001111110110111111001111100011110000110110011000111100000000000000000001111110000110000001100000011000000110000001100000011000000110000001111000011100000110000000000000000000111111110000001100000011000001100000110000011000001100000110000011000000111001110111111000000000000000000111111011100111110000001100000011100000011111101110000011000000110000001110011101111110000000000000000000110000001100000011000000110000001100001111111100110011001101100011110000111000001100000000000000000000011111101110011111000000110000001110000001111111000000110000001100000011000000111111111100000000000000000111111011100111110000111100001111100011011111110000001100000011000000111110011101111110000000000000000000001100000011000000110000001100000110000011000001100000110000001100000011000000111111110000000000000000011111101110011111000011110000111110011101111110111001111100001111000011111001110111111000000000000000000111111011100111110000001100000011000000111111101110011111000011110000111110011101111110000000000000000000000000000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000000000000011000001100000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000110000000110000000110000000110000000110000000110000011000001100000110000011000001100000000000000000000000000000000000001111111111111111000000001111111111111111000000000000000000000000000000000000000000000000000001100000110000011000001100000110000011000000011000000011000000011000000011000000011000000000000000000001100000000000000000000001100000011000001100000110000011000000110000111100001101111110000000000000000011111100000001101111001111011011110010111011101111000011011111100000000000000000000000000000000000000000110000111100001111000011110000111111111111000011110000111100001101100110001111000001100000000000000000000111111111100011110000111100001111100011011111111110001111000011110000111110001101111111000000000000000001111110111001110000001100000011000000110000001100000011000000110000001111100111011111100000000000000000001111110111001111100011110000111100001111000011110000111100001111100011011100110011111100000000000000001111111100000011000000110000001100000011001111110000001100000011000000110000001111111111000000000000000000000011000000110000001100000011000000110000001100111111000000110000001100000011111111110000000000000000011111101110011111000011110000111111001100000011000000110000001100000011111001110111111000000000000000001100001111000011110000111100001111000011111111111100001111000011110000111100001111000011000000000000000001111110000110000001100000011000000110000001100000011000000110000001100000011000011111100000000000000000001111100111011101100011011000000110000001100000011000000110000001100000011000000110000000000000000000001100001101100011001100110001101100001111000001110000111100011011001100110110001111000011000000000000000011111111000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000110000111100001111000011110000111100001111000011110110111111111111111111111001111100001100000000000000001110001111100011111100111111001111111011110110111101111111001111110011111100011111000111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111100111011111100000000000000000000000110000001100000011000000110000001101111111111000111100001111000011111000110111111100000000000000001111110001110110111110111101101111000011110000111100001111000011110000110110011000111100000000000000000011000011011000110011001100011011000011110111111111100011110000111100001111100011011111110000000000000000011111101110011111000000110000001110000001111110000001110000001100000011111001110111111000000000000000000001100000011000000110000001100000011000000110000001100000011000000110000001100011111111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111000011110000110000000000000000000110000011110000111100011001100110011011000011110000111100001111000011110000111100001100000000000000001100001111100111111111111111111111011011110110111100001111000011110000111100001111000011000000000000000011000011011001100110011000111100001111000001100000111100001111000110011001100110110000110000000000000000000110000001100000011000000110000001100000011000001111000011110001100110011001101100001100000000000000001111111100000011000000110000011000001100011111100011000001100000110000001100000011111111000000000000000000111100000011000000110000001100000011000000110000001100000011000000110000001100001111000000000011000000110000000110000001100000001100000011000000011000000110000000110000001100000001100000011000000000000000000011110000110000001100000011000000110000001100000011000000110000001100000011000000111100000000000000000000000000000000000000000000000000000000000000000000000000110000110110011000111100000110001111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000111000000110000001110000000000000000011111110110000111100001111111110110000001100001101111110000000000000000000000000000000000000000000000000011111111100001111000011110000111100001101111111000000110000001100000011000000110000001100000000000000000111111011000011000000110000001100000011110000110111111000000000000000000000000000000000000000000000000011111110110000111100001111000011110000111111111011000000110000001100000011000000110000000000000000000000111111100000001100000011011111111100001111000011011111100000000000000000000000000000000000000000000000000000110000001100000011000000110000001100001111110000110000001100000011001100110001111000011111101100001111000000110000001111111011000011110000111100001101111110000000000000000000000000000000000000000000000000110000111100001111000011110000111100001111000011011111110000001100000011000000110000001100000000000000000001100000011000000110000001100000011000000110000001100000000000000000000001100000000000000111000011011000110000001100000011000000110000001100000011000000110000000000000000000000110000000000000000000000000000011000110011001100011111000011110001101100110011011000110000001100000011000000110000001100000000000000000111111000011000000110000001100000011000000110000001100000011000000110000001100000011110000000000000000011011011110110111101101111011011110110111101101101111111000000000000000000000000000000000000000000000000011000110110001101100011011000110110001101100011001111110000000000000000000000000000000000000000000000000011111001100011011000110110001101100011011000110011111000000000000000000000000000000000000000110000001100000011011111111100001111000011110000111100001101111111000000000000000000000000000000001100000011000000110000001111111011000011110000111100001111000011111111100000000000000000000000000000000000000000000000000000001100000011000000110000001100000011000001110111111100000000000000000000000000000000000000000000000001111111110000001100000001111110000000110000001111111110000000000000000000000000000000000000000000000000001110000110110000001100000011000000110000001100001111110000110000001100000011000000000000000000000000000111111001100011011000110110001101100011011000110110001100000000000000000000000000000000000000000000000000011000001111000011110001100110011001101100001111000011000000000000000000000000000000000000000000000000110000111110011111111111110110111100001111000011110000110000000000000000000000000000000000000000000000001100001101100110001111000001100000111100011001101100001100000000000000000000000000000000000000110000011000000110000011000001100000111100011001100110011011000011000000000000000000000000000000000000000000000000111111110000011000001100000110000011000001100000111111110000000000000000000000000000000000000000000000001111000000011000000110000001100000011100000011110001110000011000000110000001100011110000000110000001100000011000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000000000011110001100000011000000110000011100011110000001110000001100000011000000110000000111100000000000000000000000000000000000000000000000000000000000000000000000000000000001110110110111000000000").ca
}


func DrawAsciiCharacter(_ image : inout RGBABitmapImage, _ topx : Double, _ topy : Double, _ a : Character, _ color : inout RGBA) -> Void{
	var topx = topx;
	var topy = topy;
	var a = a;
	var index, x, y, pixel, basis, ybasis : Double
	var allCharData : [Character]

	index = charToDouble(a)
	index = index - 32.0
	allCharData = GetPixelFontData()

	basis = index*8.0*13.0

	y = 0.0
	while(y < 13.0){
		ybasis = basis + y*8.0
		x = 0.0
		while(x < 8.0){
			pixel = charToDouble(allCharData[Int(ybasis + x)])
			if(pixel == charToDouble("1")){
				DrawPixel(&image, topx + 8.0 - 1.0 - x, topy + 13.0 - 1.0 - y, &color)
			}
			x = x + 1.0
		}
		y = y + 1.0
	}
}


func GetTextWidth(_ text : inout [Character]) -> Double{
	var charWidth, spacing, width : Double

	charWidth = 8.0
	spacing = 2.0

	if(Double(text.count) == 0.0){
		width = 0.0
	}else{
		width = Double(text.count)*charWidth + (Double(text.count) - 1.0)*spacing
	}

	return width
}


func GetTextHeight(_ text : inout [Character]) -> Double{
	return 13.0
}


func DPIToDotsPerMm(_ dpi : Double) -> Double{
	var dpi = dpi;
	return dpi/25.4
}


func DotsPerMmDPI(_ dotsPerMm : Double) -> Double{
	var dotsPerMm = dotsPerMm;
	return dotsPerMm*25.4
}


func MmToInch(_ mm : Double) -> Double{
	var mm = mm;
	return mm/25.4
}


func InchToMm(_ inch : Double) -> Double{
	var inch = inch;
	return inch*25.4
}


func MmToDots(_ mm : Double, _ dpi : Double) -> Double{
	var mm = mm;
	var dpi = dpi;
	return MmToInch(mm)*dpi
}


func DotsToMm(_ dots : Double, _ dpi : Double) -> Double{
	var dots = dots;
	var dpi = dpi;
	return InchToMm(dots/dpi)
}


func PtsToInch(_ pts : Double) -> Double{
	var pts = pts;
	return pts*1.0/72.0
}


func InchToPts(_ inch : Double) -> Double{
	var inch = inch;
	return inch*72.0
}


func PtsToMm(_ pts : Double) -> Double{
	var pts = pts;
	return InchToMm(PtsToInch(pts))
}


func MmToPts(_ mm : Double) -> Double{
	var mm = mm;
	return InchToPts(MmToInch(mm))
}


func ComputeReedSolomonCodes(_ data : inout [Double], _ eccs : Double) -> [Double]{
	var eccs = eccs;
	var rsDiv, ecc : [Double]

	rsDiv = ReedSolomonComputeDivisor(eccs)
	ecc = ReedSolomonComputeRemainder(&data, &rsDiv)

	return ecc
}


func ReedSolomonComputeDivisor(_ eccs : Double) -> [Double]{
	var eccs = eccs;
	var result : [Double]
	var root, i, j : Double

	result = arraysCreateNumberArray(eccs, 0.0)
	result[Int(Double(result.count) - 1.0)] = 1.0

	root = 1.0
	i = 0.0
	while(i < eccs){
		j = 0.0
		while(j < Double(result.count)){
			result[Int(j)] = GaloisField2e8Mul(result[Int(j)], root, 285.0)
			if(j + 1.0 < Double(result.count)){
				result[Int(j)] = XorByte(result[Int(j)], result[Int(j + 1.0)])
			}
			j = j + 1.0
		}
		root = GaloisField2e8Mul(root, 2.0, 285.0)
		i = i + 1.0
	}

	return result
}


func ReedSolomonComputeRemainder(_ data : inout [Double], _ divisor : inout [Double]) -> [Double]{
	var result : [Double]
	var i, j, b, factor, coef : Double

	result = arraysCreateNumberArray(Double(divisor.count), 0.0)

	i = 0.0
	while(i < Double(data.count)){
		b = data[Int(i)]

		factor = XorByte(b, result[Int(0)])

		j = 0.0
		while(j < Double(result.count) - 1.0){
			result[Int(j)] = result[Int(j + 1.0)]
			j = j + 1.0
		}
		result[Int(j)] = 0.0

		j = 0.0
		while(j < Double(divisor.count)){
			coef = divisor[Int(j)]
			result[Int(j)] = XorByte(result[Int(j)], GaloisField2e8Mul(coef, factor, 285.0))
			j = j + 1.0
		}
		i = i + 1.0
	}

	return result
}


func ComputeBHC15_5Code(_ data : Double) -> Double{
	var data = data;
	var i, gp : Double

	/* x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335*/
	gp = 1335.0

	i = 0.0
	while(i < 10.0){
		data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 9.0)*gp)
		i = i + 1.0
	}

	return data
}


func ComputeBHC18_6Code(_ data : Double) -> Double{
	var data = data;
	var i, gp : Double

	/* x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973*/
	gp = 7973.0

	i = 0.0
	while(i < 12.0){
		data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 11.0)*gp)
		i = i + 1.0
	}

	return data
}


func And4Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 && bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func ToUnsigned4Bytes(_ a : Double) -> Double{
	var a = a;
	if(a < 0.0){
		a = 4294967296.0 - Truncate((-a).truncatingRemainder(dividingBy:4294967296.0))
	}else{
		a = Truncate(a.truncatingRemainder(dividingBy:4294967296.0))
	}
	return a
}


func ToUnsigned2Bytes(_ a : Double) -> Double{
	var a = a;
	if(a < 0.0){
		a = 65536.0 - Truncate((-a).truncatingRemainder(dividingBy:65536.0))
	}else{
		a = Truncate(a.truncatingRemainder(dividingBy:65536.0))
	}
	return a
}


func ToUnsignedByte(_ a : Double) -> Double{
	var a = a;
	if(a < 0.0){
		a = 256.0 - Truncate((-a).truncatingRemainder(dividingBy:256.0))
	}else{
		a = Truncate(a.truncatingRemainder(dividingBy:256.0))
	}
	return a
}


func And2Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 && bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func AndByte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 && bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func Or4Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 || bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func Or2Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 || bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func OrByte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab == 1.0 || bb == 1.0){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func Xor4Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab != bb){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func Xor2Byte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab != bb){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func XorByte(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var byteVal, result, i, ab, bb : Double

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0){
		ab = a.truncatingRemainder(dividingBy:2.0)
		bb = b.truncatingRemainder(dividingBy:2.0)

		if(ab != bb){
			result = result + byteVal
		}

		a = floor(a/2.0)
		b = floor(b/2.0)
		byteVal = byteVal*2.0
		i = i + 1.0
	}

	return result
}


func Not4Byte(_ a : Double) -> Double{
	var a = a;
	var result : Double

	a = ToUnsigned4Bytes(a)

	result = 4294967296.0 - a - 1.0

	return result
}


func Not2Byte(_ a : Double) -> Double{
	var a = a;
	var result : Double

	a = ToUnsigned2Bytes(a)

	result = 65536.0 - a - 1.0

	return result
}


func NotByte(_ a : Double) -> Double{
	var a = a;
	var result : Double

	a = ToUnsignedByte(a)

	result = 256.0 - a - 1.0

	return result
}


func ShiftLeft4Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:4294967296.0))
	n = Truncate(max(n, 0.0))

	result = a*pow(2.0, n)

	return result
}


func ShiftLeft2Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:65536.0))
	n = Truncate(max(n, 0.0))

	result = a*pow(2.0, n)

	return result
}


func ShiftLeftByte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:256.0))
	n = Truncate(max(n, 0.0))

	result = a*pow(2.0, n)

	return result
}


func ShiftRight4Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:4294967296.0))
	n = Truncate(max(n, 0.0))

	result = Truncate(a/pow(2.0, n))

	return result
}


func ShiftRight2Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:65536.0))
	n = Truncate(max(n, 0.0))

	result = Truncate(a/pow(2.0, n))

	return result
}


func ShiftRightByte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var result : Double

	a = Truncate(a.truncatingRemainder(dividingBy:256.0))
	n = Truncate(max(n, 0.0))

	result = Truncate(a/pow(2.0, n))

	return result
}


func RotateLeft4Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var x : Double

	a = ToUnsigned4Bytes(a)
	n = Truncate(n)

	/*return (a << n) | (a >> (32 - n));*/
	/* Mask the upper bits first, then rotate.*/
	x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1.0, n) - 1.0))
	x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32.0 - n)))

	return x
}


func RotateRight4Byte(_ a : Double, _ n : Double) -> Double{
	var a = a;
	var n = n;
	var x : Double

	a = ToUnsigned4Bytes(a)
	n = Truncate(n)

	/* return (a >> d) | (a << (32 - n));*/
	/* Mask away the upper bits first, then perform the shift.*/
	x = And4Byte(a, ShiftLeft4Byte(1.0, n) - 1.0)
	x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32.0 - n))

	return x
}


func CreateBooleanArrayFromNumber(_ w : Double, _ size : Double) -> [Bool]{
	var w = w;
	var size = size;
	var out : [Bool]
	var p, j : Double

	out = arraysCreateBooleanArray(size, false)

	j = 0.0
	p = 1.0
	while(p < w){
		p = p*2.0
		j = j + 1.0
	}

	while(j >= 0.0){
		if(w >= p){
			w = w - p
			if(j < size){
				out[Int(size - 1.0 - j)] = true
			}
		}
		p = p/2.0
		j = j - 1.0
	}

	return out
}


func BooleanArrayToNumber(_ bits : inout [Bool]) -> Double{
	var w, i, p : Double

	w = 0.0
	p = 1.0
	i = 31.0
	while(i >= 0.0){
		if(bits[Int(i)]){
			w = w + p
		}
		p = p*2.0
		i = i - 1.0
	}

	return w
}


func BooleanAnd(_ a : inout [Bool], _ b : inout [Bool]) -> [Bool]{
	var out : [Bool]
	var i, length : Double

	length = Double(a.count)

	out = Array(repeating:Bool(), count: Int(length))

	i = 0.0
	while(i < length){
		out[Int(i)] = a[Int(i)] && b[Int(i)]
		i = i + 1.0
	}
	return out
}


func BooleanXor(_ a : inout [Bool], _ b : inout [Bool]) -> [Bool]{
	var out : [Bool]
	var i, length : Double

	length = Double(a.count)

	out = Array(repeating:Bool(), count: Int(length))

	i = 0.0
	while(i < length){
		if(a[Int(i)] || b[Int(i)]){
			if(!(a[Int(i)] && b[Int(i)])){
				out[Int(i)] = true
			}
		}
		i = i + 1.0
	}
	return out
}


func BooleanNot(_ a : inout [Bool]) -> [Bool]{
	var out : [Bool]
	var i, length : Double

	length = Double(a.count)

	out = Array(repeating:Bool(), count: Int(length))

	i = 0.0
	while(i < length){
		out[Int(i)] = !a[Int(i)]
		i = i + 1.0
	}
	return out
}


func ShiftBitsRight4Byte(_ w : inout [Bool], _ n : Double) -> [Bool]{
	var n = n;
	var wb : [Bool]
	var ob : [Bool]
	var i, it : Double
	var f : Bool
	f = false

	if(n == 0.0){
		ob = w
	}else{
		wb = w
		ob = Array(repeating:Bool(), count: Int(32))

		i = 0.0
		while(i < 32.0){
			it = i - n

			if(it < 0.0){
				f = false
			}else{
				f = wb[Int(it)]
			}

			ob[Int(i)] = f
			i = i + 1.0
		}
	}

	return ob
}


func ReadNextBit(_ data : inout [Double], _ nextbit : inout NumberReference) -> Double{
	var bytenr, bitnumber, bit, b : Double

	bytenr = floor(nextbit.numberValue/8.0)
	bitnumber = nextbit.numberValue.truncatingRemainder(dividingBy:8.0)

	b = data[Int(bytenr)]

	bit = floor(b/pow(2.0, bitnumber)).truncatingRemainder(dividingBy:2.0)

	nextbit.numberValue = nextbit.numberValue + 1.0

	return bit
}


func BitExtract(_ b : Double, _ fromInc : Double, _ toInc : Double) -> Double{
	var b = b;
	var fromInc = fromInc;
	var toInc = toInc;
	return floor(b/pow(2.0, fromInc)).truncatingRemainder(dividingBy:pow(2.0, toInc + 1.0 - fromInc))
}


func ReadBitRange(_ data : inout [Double], _ nextbit : inout NumberReference, _ length : Double) -> Double{
	var length = length;
	var startbyte, endbyte : Double
	var startbit, endbit : Double
	var number, i : Double

	number = 0.0

	startbyte = floor(nextbit.numberValue/8.0)
	endbyte = floor((nextbit.numberValue + length)/8.0)

	startbit = nextbit.numberValue.truncatingRemainder(dividingBy:8.0)
	endbit = (nextbit.numberValue + length - 1.0).truncatingRemainder(dividingBy:8.0)

	if(startbyte == endbyte){
		number = BitExtract(data[Int(startbyte)], startbit, endbit)
	}

	nextbit.numberValue = nextbit.numberValue + length

	return number
}


func SkipToBoundary(_ nextbit : inout NumberReference) -> Void{
	var skip : Double

	skip = 8.0 - nextbit.numberValue.truncatingRemainder(dividingBy:8.0)
	nextbit.numberValue = nextbit.numberValue + skip
}


func ReadNextByteBoundary(_ data : inout [Double], _ nextbit : inout NumberReference) -> Double{
	var bytenr, b : Double

	bytenr = floor(nextbit.numberValue/8.0)
	b = data[Int(bytenr)]
	nextbit.numberValue = nextbit.numberValue + 8.0

	return b
}


func Read2bytesByteBoundary(_ data : inout [Double], _ nextbit : inout NumberReference) -> Double{
	var r : Double

	r = 0.0
	r = r + pow(2.0, 8.0)*ReadNextByteBoundary(&data, &nextbit)
	r = r + ReadNextByteBoundary(&data, &nextbit)

	return r
}


func QuickSortStrings(_ list : inout StringArrayReference) -> Void{
	QuickSortStringsBounds(&list, 0.0, Double(list.stringArray.count) - 1.0)
}


func QuickSortStringsBounds(_ A : inout StringArrayReference, _ lo : Double, _ hi : Double) -> Void{
	var lo = lo;
	var hi = hi;
	var p : Double

	if(lo < hi){
		p = QuickSortStringsPartition(&A, lo, hi)
		QuickSortStringsBounds(&A, lo, p - 1.0)
		QuickSortStringsBounds(&A, p + 1.0, hi)
	}
}


func QuickSortStringsPartition(_ A : inout StringArrayReference, _ lo : Double, _ hi : Double) -> Double{
	var lo = lo;
	var hi = hi;
	var pivot : [Character]
	var i, j : Double

	pivot = A.stringArray[Int(hi)].stringx
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0){
		if(strStringIsBefore(&A.stringArray[Int(j)].stringx, &pivot)){
			i = i + 1.0
			arraysSwapElementsOfStringArray(&A, i, j)
		}
		j = j + 1.0
	}
	arraysSwapElementsOfStringArray(&A, i + 1.0, hi)

	return i + 1.0
}


func QuickSortStringsWithIndexes(_ A : inout StringArrayReference) -> [Double]{
	var indexes : [Double]
	var i : Double

	indexes = Array(repeating:Double(), count: Int(Double(A.stringArray.count)))

	i = 0.0
	while(i < Double(A.stringArray.count)){
		indexes[Int(i)] = i
		i = i + 1.0
	}

	QuickSortStringsBoundsWithIndexes(&A, &indexes, 0.0, Double(A.stringArray.count) - 1.0)

	return indexes
}


func QuickSortStringsBoundsWithIndexes(_ A : inout StringArrayReference, _ indexes : inout [Double], _ lo : Double, _ hi : Double) -> Void{
	var lo = lo;
	var hi = hi;
	var p : Double

	if(lo < hi){
		p = QuickSortStringsPartitionWithIndexes(&A, &indexes, lo, hi)
		QuickSortStringsBoundsWithIndexes(&A, &indexes, lo, p - 1.0)
		QuickSortStringsBoundsWithIndexes(&A, &indexes, p + 1.0, hi)
	}
}


func QuickSortStringsPartitionWithIndexes(_ A : inout StringArrayReference, _ indexes : inout [Double], _ lo : Double, _ hi : Double) -> Double{
	var lo = lo;
	var hi = hi;
	var i, j : Double
	var pivot : [Character]

	pivot = A.stringArray[Int(hi)].stringx
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0){
		if(strStringIsBefore(&A.stringArray[Int(j)].stringx, &pivot)){
			i = i + 1.0
			arraysSwapElementsOfStringArray(&A, i, j)
			arraysSwapElementsOfNumberArray(&indexes, i, j)
		}
		j = j + 1.0
	}
	arraysSwapElementsOfStringArray(&A, i + 1.0, hi)
	arraysSwapElementsOfNumberArray(&indexes, i + 1.0, hi)

	return i + 1.0
}


func QuickSortNumbers(_ list : inout [Double]) -> Void{
	QuickSortNumbersBounds(&list, 0.0, Double(list.count) - 1.0)
}


func QuickSortNumbersBounds(_ A : inout [Double], _ lo : Double, _ hi : Double) -> Void{
	var lo = lo;
	var hi = hi;
	var p : Double

	if(lo < hi){
		p = QuickSortNumbersPartition(&A, lo, hi)
		QuickSortNumbersBounds(&A, lo, p - 1.0)
		QuickSortNumbersBounds(&A, p + 1.0, hi)
	}
}


func QuickSortNumbersPartition(_ A : inout [Double], _ lo : Double, _ hi : Double) -> Double{
	var lo = lo;
	var hi = hi;
	var pivot, lowPos, j : Double

	pivot = A[Int(hi)]
	lowPos = lo
	j = lo
	while(j <= hi - 1.0){
		if(A[Int(j)] < pivot){
			arraysSwapElementsOfNumberArray(&A, lowPos, j)
			lowPos = lowPos + 1.0
		}
		j = j + 1.0
	}
	arraysSwapElementsOfNumberArray(&A, lowPos, hi)

	return lowPos
}


func QuickSortNumbersWithIndexes(_ A : inout [Double]) -> [Double]{
	var indexes : [Double]
	var i : Double

	indexes = Array(repeating:Double(), count: Int(Double(A.count)))

	i = 0.0
	while(i < Double(A.count)){
		indexes[Int(i)] = i
		i = i + 1.0
	}

	QuickSortNumbersBoundsWithIndexes(&A, &indexes, 0.0, Double(A.count) - 1.0)

	return indexes
}


func QuickSortNumbersBoundsWithIndexes(_ A : inout [Double], _ indexes : inout [Double], _ lo : Double, _ hi : Double) -> Void{
	var lo = lo;
	var hi = hi;
	var p : Double

	if(lo < hi){
		p = QuickSortNumbersPartitionWithIndexes(&A, &indexes, lo, hi)
		QuickSortNumbersBoundsWithIndexes(&A, &indexes, lo, p - 1.0)
		QuickSortNumbersBoundsWithIndexes(&A, &indexes, p + 1.0, hi)
	}
}


func QuickSortNumbersPartitionWithIndexes(_ A : inout [Double], _ indexes : inout [Double], _ lo : Double, _ hi : Double) -> Double{
	var lo = lo;
	var hi = hi;
	var pivot, i, j : Double

	pivot = A[Int(hi)]
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0){
		if(A[Int(j)] < pivot){
			i = i + 1.0
			arraysSwapElementsOfNumberArray(&A, i, j)
			arraysSwapElementsOfNumberArray(&indexes, i, j)
		}
		j = j + 1.0
	}
	arraysSwapElementsOfNumberArray(&A, i + 1.0, hi)
	arraysSwapElementsOfNumberArray(&indexes, i + 1.0, hi)

	return i + 1.0
}


func Add(_ a : inout Matrix, _ b : inout Matrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&a)
	c = NumberOfColumns(&a)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			a.r[Int(m)].c[Int(n)] = Element(&a, m, n) + Element(&b, m, n)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func Assign(_ A : inout Matrix, _ B : inout Matrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&A)
	c = NumberOfColumns(&A)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			A.r[Int(m)].c[Int(n)] = Element(&B, m, n)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func Resize(_ A : inout Matrix, _ r : Double, _ c : Double) -> Void{
	var r = r;
	var c = c;
	var m, n, ar, ac : Double
	var C : Matrix

	C = CreateMatrix(r, c).ref

	ar = NumberOfRows(&A)
	ac = NumberOfColumns(&A)

	m = 0.0
	while(m < min(r, ar)){
		n = 0.0
		while(n < min(c, ac)){
			C.r[Int(m)].c[Int(n)] = Element(&A, m, n)
			n = n + 1.0
		}
		m = m + 1.0
	}

	FreeMatrixRows(&A.r)
	A.r = C.r
}


func Subtract(_ a : inout Matrix, _ b : inout Matrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&a)
	c = NumberOfColumns(&a)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			a.r[Int(m)].c[Int(n)] = Element(&a, m, n) - Element(&b, m, n)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func SubtractToNew(_ a : inout Matrix, _ b : inout Matrix) -> MatrixReferenceClass{
	var X : Matrix

	X = CreateCopyOfMatrix(&a).ref
	Subtract(&X, &b)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func ScalarMultiply(_ A : inout Matrix, _ b : Double) -> Void{
	var b = b;
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&A)
	c = NumberOfColumns(&A)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			A.r[Int(m)].c[Int(n)] = b*A.r[Int(m)].c[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ScalarDivide(_ A : inout Matrix, _ b : Double) -> Void{
	var b = b;
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&A)
	c = NumberOfColumns(&A)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			A.r[Int(m)].c[Int(n)] = Element(&A, m, n)/b
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ElementWisePower(_ A : inout Matrix, _ p : Double) -> Void{
	var p = p;
	var m, n : Double
	var r, c : Double

	r = NumberOfRows(&A)
	c = NumberOfColumns(&A)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			A.r[Int(m)].c[Int(n)] = pow(A.r[Int(m)].c[Int(n)], p)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ScalarMultiplyToNew(_ A : inout Matrix, _ b : Double) -> MatrixReferenceClass{
	var b = b;
	var matrix : Matrix

	matrix = CreateCopyOfMatrix(&A).ref
	ScalarMultiply(&matrix, b)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func MultiplyToNew(_ a : inout Matrix, _ b : inout Matrix) -> MatrixReferenceClass{
	var rows, cols : Double
	var x : Matrix

	rows = NumberOfRows(&a)
	cols = NumberOfColumns(&b)
	x = CreateMatrix(rows, cols).ref
	Multiply(&x, &a, &b)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = x
	return returnReference
}


func Multiply(_ x : inout Matrix, _ a : inout Matrix, _ b : inout Matrix) -> Void{
	var m, n : Double
	var rows, cols, d : Double
	var i, s : Double

	rows = NumberOfRows(&a)
	cols = NumberOfColumns(&b)
	d = NumberOfColumns(&a)

	m = 0.0
	while(m < rows){
		n = 0.0
		while(n < cols){
			s = 0.0

			i = 0.0
			while(i < d){
				s = s + a.r[Int(m)].c[Int(i)]*b.r[Int(i)].c[Int(n)]
				i = i + 1.0
			}

			x.r[Int(m)].c[Int(n)] = s
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func CreateSquareMatrix(_ d : Double) -> MatrixReferenceClass{
	var d = d;
	var m, n : Double
	var matrix : Matrix

	matrix = Matrix()
	matrix.r = Array(repeating:MatrixRow(), count: Int(d))
	m = 0.0
	while(m < d){
		matrix.r[Int(m)] = MatrixRow()
		matrix.r[Int(m)].c = Array(repeating:Double(), count: Int(d))
		n = 0.0
		while(n < d){
			matrix.r[Int(m)].c[Int(n)] = 0.0
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateMatrix(_ rows : Double, _ cols : Double) -> MatrixReferenceClass{
	var rows = rows;
	var cols = cols;
	var m, n : Double
	var matrix : Matrix

	matrix = Matrix()
	matrix.r = Array(repeating:MatrixRow(), count: Int(rows))
	m = 0.0
	while(m < rows){
		matrix.r[Int(m)] = MatrixRow()
		matrix.r[Int(m)].c = Array(repeating:Double(), count: Int(cols))
		n = 0.0
		while(n < cols){
			matrix.r[Int(m)].c[Int(n)] = 0.0
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateIdentityMatrix(_ d : Double) -> MatrixReferenceClass{
	var d = d;
	var m : Double
	var matrix : Matrix

	matrix = CreateSquareMatrix(d).ref
	Fill(&matrix, 0.0)

	m = 0.0
	while(m < d){
		matrix.r[Int(m)].c[Int(m)] = 1.0
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func Transpose(_ a : inout Matrix) -> Void{
	var ap : Matrix

	ap = TransposeToNew(&a).ref

	FreeMatrixRows(&a.r)
	a.r = ap.r
}


func TransposeAssign(_ t : inout Matrix, _ a : inout Matrix) -> Void{
	var m, n : Double
	var rows, cols : Double

	cols = NumberOfRows(&a)
	rows = NumberOfColumns(&a)

	m = 0.0
	while(m < cols){
		n = 0.0
		while(n < rows){
			t.r[Int(n)].c[Int(m)] = a.r[Int(m)].c[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func TransposeToNew(_ a : inout Matrix) -> MatrixReferenceClass{
	var m, n : Double
	var rows, cols : Double
	var c : Matrix

	cols = NumberOfRows(&a)
	rows = NumberOfColumns(&a)

	c = CreateMatrix(rows, cols).ref

	m = 0.0
	while(m < cols){
		n = 0.0
		while(n < rows){
			c.r[Int(n)].c[Int(m)] = a.r[Int(m)].c[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = c
	return returnReference
}


func CofactorOfMatrix(_ mat : inout Matrix, _ temp : inout Matrix, _ p : Double, _ q : Double, _ n : Double) -> Void{
	var p = p;
	var q = q;
	var n = n;
	var i, j : Double
	var row, col : Double

	i = 0.0
	j = 0.0

	row = 0.0
	while(row < n){
		col = 0.0
		while(col < n){
			if(row != p && col != q){
				temp.r[Int(i)].c[Int(j)] = mat.r[Int(row)].c[Int(col)]
				j = j + 1.0

				if(j == n - 1.0){
					j = 0.0
					i = i + 1.0
				}
			}
			col = col + 1.0
		}
		row = row + 1.0
	}
}


func DeterminantOfSubmatrix(_ mat : inout Matrix, _ n : Double) -> Double{
	var n = n;
	var D, f, sign : Double
	var temp : Matrix

	D = 0.0

	if(n == 1.0){
		D = mat.r[Int(0)].c[Int(0)]
	}else{
		temp = CreateSquareMatrix(n).ref

		sign = 1.0

		f = 0.0
		while(f < n){
			CofactorOfMatrix(&mat, &temp, 0.0, f, n)
			D = D + sign*mat.r[Int(0)].c[Int(f)]*DeterminantOfSubmatrix(&temp, n - 1.0)
			sign = -sign
			f = f + 1.0
		}

		FreeMatrix(&temp)
	}

	return D
}


func Determinant(_ m : inout Matrix) -> Double{
	var D, n : Double

	n = NumberOfRows(&m)
	D = DeterminantOfSubmatrix(&m, n)

	return D
}


func Adjoint(_ A : inout Matrix, _ adj : inout Matrix) -> Void{
	var n, sign : Double
	var cofactors : Matrix
	var i, j : Double

	n = Double(A.r.count)

	if(n == 1.0){
		adj.r[Int(0)].c[Int(0)] = 1.0
	}else{
		cofactors = CreateSquareMatrix(n).ref

		i = 0.0
		while(i < n){
			j = 0.0
			while(j < n){
				CofactorOfMatrix(&A, &cofactors, i, j, n)

				if((i + j).truncatingRemainder(dividingBy:2.0) == 0.0){
					sign = 1.0
				}else{
					sign = -1.0
				}

				adj.r[Int(j)].c[Int(i)] = sign*DeterminantOfSubmatrix(&cofactors, n - 1.0)
				j = j + 1.0
			}
			i = i + 1.0
		}

		FreeMatrix(&cofactors)
	}
}


func Inverse(_ A : inout Matrix, _ inverseResult : inout Matrix) -> Bool{
	return InverseUsingLUDecomposition(&A, &inverseResult)
}


func InverseUsingAdjoint(_ A : inout Matrix, _ inverseResult : inout Matrix) -> Bool{
	var success : Bool
	var adj : Matrix
	var n, i, j : Double
	var det : Double

	if(NumberOfColumns(&A) == NumberOfRows(&A)){
		n = NumberOfColumns(&A)

		det = Determinant(&A)
		if(det != 0.0){
			adj = CreateSquareMatrix(n).ref
			Adjoint(&A, &adj)

			i = 0.0
			while(i < n){
				j = 0.0
				while(j < n){
					inverseResult.r[Int(i)].c[Int(j)] = adj.r[Int(i)].c[Int(j)]/det
					j = j + 1.0
				}
				i = i + 1.0
			}

			success = true
			FreeMatrix(&adj)
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func InverseUsingLUDecomposition(_ A : inout Matrix, _ inverseResult : inout Matrix) -> Bool{
	var success : Bool
	var l, u, li, ui : Matrix

	l = CreateCopyOfMatrix(&A).ref
	u = CreateCopyOfMatrix(&A).ref
	li = CreateCopyOfMatrix(&A).ref
	ui = CreateCopyOfMatrix(&A).ref
	inverseResult.r = CreateCopyOfMatrix(&A).ref.r

	success = LUDecomposition(&A, &l, &u)
	if(success){
		success = InvertLowerTriangularMatrix(&l, &li)
		if(success){
			success = InvertUpperTriangularMatrix(&u, &ui)
			if(success){
				Multiply(&inverseResult, &ui, &li)
			}
		}
	}

	FreeMatrix(&l)
	FreeMatrix(&u)
	FreeMatrix(&li)
	FreeMatrix(&ui)

	return success
}


func LUDecomposition(_ A : inout Matrix, _ L : inout Matrix, _ U : inout Matrix) -> Bool{
	var n, i, j, k, sum : Double
	var success : Bool

	n = NumberOfRows(&A)

	L.r = CreateSquareMatrix(n).ref.r
	U.r = CreateSquareMatrix(n).ref.r

	if(IsSquare(&A)){
		success = true

		i = 0.0
		while(i < n && success){
			k = i
			while(k < n){
				sum = 0.0
				j = 0.0
				while(j < i){
					sum = sum + (Element(&L, i, j)*Element(&U, j, k))
					j = j + 1.0
				}

				U.r[Int(i)].c[Int(k)] = Element(&A, i, k) - sum
				k = k + 1.0
			}

			k = i
			while(k < n && success){
				if(i == k){
					L.r[Int(i)].c[Int(i)] = 1.0
				}else{
					sum = 0.0
					j = 0.0
					while(j < i){
						sum = sum + (Element(&L, k, j)*Element(&U, j, i))
						j = j + 1.0
					}

					if(Element(&U, i, i) == 0.0){
						success = false
					}else{
						L.r[Int(k)].c[Int(i)] = (Element(&A, k, i) - sum)/Element(&U, i, i)
					}
				}
				k = k + 1.0
			}
			i = i + 1.0
		}
	}else{
		success = false
	}

	return success
}


func IsSymmetric(_ A : inout Matrix) -> Bool{
	var N : Double
	var i, j : Double
	var isx, done : Bool

	N = NumberOfRows(&A)

	done = false
	isx = true
	i = 0.0
	while(i < N && !done){
		j = 0.0
		while(j < i && !done){
			if(A.r[Int(i)].c[Int(j)] != A.r[Int(j)].c[Int(i)]){
				isx = false
				done = true
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	return isx
}


func IsSquare(_ A : inout Matrix) -> Bool{
	var isx : Bool

	if(NumberOfRows(&A) == NumberOfColumns(&A)){
		isx = true
	}else{
		isx = false
	}

	return isx
}


func Cholesky(_ A : inout Matrix, _ L : inout Matrix) -> Bool{
	var success : Bool
	var N : Double
	var i, j, k, s : Double

	Clear(&L)

	if(IsSquare(&A) && IsSymmetric(&A)){
		success = true

		N = NumberOfRows(&A)

		i = 0.0
		while(i < N && success){
			j = 0.0
			while(j <= i && success){
				s = 0.0
				k = 0.0
				while(k < j){
					s = s + L.r[Int(i)].c[Int(k)]*L.r[Int(j)].c[Int(k)]
					k = k + 1.0
				}
				if(i == j){
					L.r[Int(i)].c[Int(i)] = sqrt(A.r[Int(i)].c[Int(i)] - s)
				}else{
					L.r[Int(i)].c[Int(j)] = 1.0/L.r[Int(j)].c[Int(j)]*(A.r[Int(i)].c[Int(j)] - s)
				}
				j = j + 1.0
			}
			if(L.r[Int(i)].c[Int(i)] <= 0.0){
				success = false
			}
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func Clear(_ a : inout Matrix) -> Void{
	Fill(&a, 0.0)
}


func Fill(_ a : inout Matrix, _ value : Double) -> Void{
	var value = value;
	var m, n : Double

	m = 0.0
	while(m < NumberOfRows(&a)){
		n = 0.0
		while(n < NumberOfColumns(&a)){
			a.r[Int(m)].c[Int(n)] = value
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func Element(_ matrix : inout Matrix, _ m : Double, _ n : Double) -> Double{
	var m = m;
	var n = n;
	return matrix.r[Int(m)].c[Int(n)]
}


func Trace(_ a : inout Matrix) -> Double{
	var m : Double
	var d, tr : Double

	tr = 0.0

	d = Double(a.r.count)
	m = 0.0
	while(m < d){
		tr = tr + a.r[Int(m)].c[Int(m)]
		m = m + 1.0
	}

	return tr
}


func ColumnCombineMatricesToNew(_ A : inout Matrix, _ B : inout Matrix) -> MatrixReferenceClass{
	var X : Matrix
	var m, n : Double

	X = CreateMatrix(NumberOfRows(&A), NumberOfColumns(&A) + NumberOfColumns(&B)).ref

	m = 0.0
	while(m < NumberOfRows(&A)){
		n = 0.0
		while(n < NumberOfColumns(&A)){
			X.r[Int(m)].c[Int(n)] = A.r[Int(m)].c[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}

	m = 0.0
	while(m < NumberOfRows(&B)){
		n = 0.0
		while(n < NumberOfColumns(&B)){
			X.r[Int(m)].c[Int(NumberOfColumns(&A) + n)] = B.r[Int(m)].c[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func NumberOfRows(_ A : inout Matrix) -> Double{
	return Double(A.r.count)
}


func NumberOfColumns(_ A : inout Matrix) -> Double{
	return Double(A.r[Int(0)].c.count)
}


func CharacteristicPolynomial(_ A : inout Matrix) -> [Double]{
	var dummy : Matrix
	var coeffs : NumberArrayReference
	var determinant : NumberReference

	dummy = CreateSquareMatrix(NumberOfRows(&A)).ref

	coeffs = NumberArrayReference()
	determinant = NumberReference()
	CharacteristicPolynomialWithInverse(&A, &dummy, &coeffs, &determinant)

	FreeMatrix(&dummy)

	return coeffs.numberArray
}


func CharacteristicPolynomialWithInverse(_ A : inout Matrix, _ AInverse : inout Matrix, _ cp : inout NumberArrayReference, _ determinant : inout NumberReference) -> Void{
	FaddeevLeVerrierAlgorithm(&A, &AInverse, &cp, &determinant)
}


func FaddeevLeVerrierAlgorithm(_ A : inout Matrix, _ AInverse : inout Matrix, _ cp : inout NumberArrayReference, _ determinant : inout NumberReference) -> Void{
	var p : [Double]
	var Mk, Mkm1, t1, I : Matrix
	var n, k : Double

	n = NumberOfRows(&A)
	p = Array(repeating:Double(), count: Int(n + 1.0))
	p[Int(n)] = 1.0
	Mkm1 = CreateSquareMatrix(n).ref
	Fill(&Mkm1, 0.0)
	I = CreateIdentityMatrix(n).ref
	Mk = CreateSquareMatrix(n).ref
	t1 = CreateSquareMatrix(n).ref

	k = 1.0
	while(k <= n){
		/* M_k = A * M_(k-1) + c_(n-k+1) * I*/
		Multiply(&Mk, &A, &Mkm1)
		Assign(&t1, &I)
		ScalarMultiply(&t1, p[Int(n - k + 1.0)])
		Add(&Mk, &t1)

		/* c_(n-k) = -1/k * trace(A * M_k)*/
		Multiply(&t1, &A, &Mk)
		p[Int(n - k)] = -1.0/k*Trace(&t1)

		/* done*/
		Assign(&Mkm1, &Mk)

		if(k == n){
			Assign(&AInverse, &Mk)
			determinant.numberValue = -p[Int(0)]
			if(p[Int(0)] == 0.0){
			}else{
				ScalarDivide(&AInverse, determinant.numberValue)
			}
		}
		k = k + 1.0
	}

	FreeMatrix(&Mkm1)
	FreeMatrix(&I)
	FreeMatrix(&Mk)
	FreeMatrix(&t1)

	cp.numberArray = p
}


func InverseUsingCharacteristicPolynomial(_ A : inout Matrix) -> MatrixReferenceClass{
	var inverse : Matrix
	var coeffs : NumberArrayReference
	var determinant : NumberReference

	inverse = CreateSquareMatrix(NumberOfRows(&A)).ref
	coeffs = NumberArrayReference()
	determinant = NumberReference()
	CharacteristicPolynomialWithInverse(&A, &inverse, &coeffs, &determinant)
	delete(coeffs.numberArray)
	delete(coeffs)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = inverse
	return returnReference
}


func Eigenvalues(_ A : inout Matrix, _ eigenValuesReference : inout NumberArrayReference) -> Bool{
	var eigenVectorsReference : MatrixArrayReference
	var success : Bool
	var i : Double

	eigenVectorsReference = MatrixArrayReference()
	success = Eigenpairs(&A, &eigenValuesReference, &eigenVectorsReference)
	if(success){
		i = 0.0
		while(i < Double(eigenVectorsReference.matrices.count)){
			FreeMatrix(&eigenVectorsReference.matrices[Int(i)])
			i = i + 1.0
		}
		delete(eigenVectorsReference.matrices)
		delete(eigenVectorsReference)
	}

	return success
}


func EigenvaluesUsingQRAlgorithm(_ A : inout Matrix, _ eigenValuesReference : inout NumberArrayReference, _ precision : Double, _ maxIterations : Double) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var x, q, r : Matrix
	var success : Bool
	var i, n, v, v1, v2, ev, found : Double
	var cp : [Double]

	n = NumberOfRows(&A)
	x = CreateSquareMatrix(n).ref
	q = CreateSquareMatrix(n).ref
	r = CreateSquareMatrix(n).ref
	eigenValuesReference.numberArray = Array(repeating:Double(), count: Int(n))
	success = QRAlgorithm(&A, &r, &x, &q, precision, maxIterations)
	found = 0.0
	if(success){
		ExtractDiagonal(&x, &eigenValuesReference.numberArray)

		/* find the correct sign of the eigenvalue.*/
		cp = CharacteristicPolynomial(&A)
		i = 0.0
		while(i < n){
			ev = eigenValuesReference.numberArray[Int(i)]

			v1 = pEvaluate(&cp, ev)
			v2 = pEvaluate(&cp, -ev)

			if(abs(v2) < abs(v1)){
				eigenValuesReference.numberArray[Int(i)] = -ev
				v = v2
			}else{
				v = v1
			}

			if(abs(v) < precision*pow(10.0, 4.0)){
				found = found + 1.0
			}
			i = i + 1.0
		}

		FreeMatrix(&x)
		FreeMatrix(&q)
		FreeMatrix(&r)
	}

	if(found != n){
		success = false
	}

	return success
}


func EigenvaluesUsingLaguerreIterations(_ A : inout Matrix, _ eigenValuesReference : inout NumberArrayReference) -> Bool{
	var p : [Double]
	var success : Bool

	p = CharacteristicPolynomial(&A)
	success = FindRoots(&p, &eigenValuesReference)

	return success
}


func GaussianElimination(_ A : inout Matrix) -> Void{
	var h, k, m, n, maxElement, i, j, max, maxCandidate, f : Double

	m = NumberOfRows(&A)
	n = NumberOfColumns(&A)

	h = 0.0
	k = 0.0
	while(h < m && k < n){
		maxElement = h
		max = 0.0
		i = h
		while(i < m){
			maxCandidate = abs(Element(&A, i, k))
			if(max < maxCandidate){
				maxElement = i
				max = maxCandidate
			}
			i = i + 1.0
		}
		if(A.r[Int(maxElement)].c[Int(k)] == 0.0){
			k = k + 1.0
		}else{
			SwapRows(&A, h, maxElement)
			i = h + 1.0
			while(i < m){
				f = Element(&A, i, k)/Element(&A, h, k)
				A.r[Int(i)].c[Int(k)] = 0.0
				j = k + 1.0
				while(j < n){
					A.r[Int(i)].c[Int(j)] = Element(&A, i, j) - Element(&A, h, j)*f
					j = j + 1.0
				}
				i = i + 1.0
			}
			h = h + 1.0
			k = k + 1.0
		}
	}
}


func GaussianEliminationToNew(_ A : inout Matrix) -> MatrixReferenceClass{
	var X : Matrix

	X = CreateCopyOfMatrix(&A).ref
	GaussianElimination(&X)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func CreateCopyOfMatrix(_ A : inout Matrix) -> MatrixReferenceClass{
	var X : Matrix

	X = CreateMatrix(NumberOfRows(&A), NumberOfColumns(&A)).ref
	Assign(&X, &A)

	var returnReference = MatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func SwapRows(_ A : inout Matrix, _ to : Double, _ from : Double) -> Void{
	var to = to;
	var from = from;
	var n : Double
	var c, t : Double

	c = NumberOfRows(&A)
	n = 0.0
	while(n < c){
		t = A.r[Int(to)].c[Int(n)]
		A.r[Int(to)].c[Int(n)] = A.r[Int(from)].c[Int(n)]
		A.r[Int(from)].c[Int(n)] = t
		n = n + 1.0
	}
}


func UnnormalizeVector(_ numberArray : inout [Double]) -> Void{
	var i, m : Double
	var mSet : Bool

	mSet = false
	m = 0.0

	i = 0.0
	while(i < Double(numberArray.count)){
		if(numberArray[Int(i)] - Truncate(numberArray[Int(i)]) < 0.001){
			if(!mSet){
				m = abs(numberArray[Int(i)])
				mSet = true
			}else{
				m = min(m, abs(numberArray[Int(i)]))
			}
		}
		i = i + 1.0
	}

	if(mSet){
		i = 0.0
		while(i < Double(numberArray.count)){
			numberArray[Int(i)] = numberArray[Int(i)]/m
			i = i + 1.0
		}
	}
}


func InversePowerMethod(_ A : inout Matrix, _ eigenvalue : Double, _ maxIterations : Double, _ eigenvector : inout NumberArrayReference) -> Bool{
	var eigenvalue = eigenvalue;
	var maxIterations = maxIterations;
	var x, y, z, b, t : Matrix
	var n, i, c : Double
	var singular : Bool

	n = NumberOfRows(&A)

	x = CreateIdentityMatrix(n).ref
	ScalarMultiply(&x, eigenvalue)
	y = SubtractToNew(&A, &x).ref
	z = CreateSquareMatrix(n).ref
	singular = !Inverse(&y, &z)
	if(singular){
		/* Try again with more erroneous eigenvalue estimate.*/
		x = CreateIdentityMatrix(n).ref
		ScalarMultiply(&x, eigenvalue*1.01)
		y = SubtractToNew(&A, &x).ref
		z = CreateSquareMatrix(n).ref
		singular = !Inverse(&y, &z)
	}

	if(!singular){
		b = CreateMatrix(n, 1.0).ref

		i = 0.0
		while(i < n){
			b.r[Int(i)].c[Int(0)] = 1.0
			i = i + 1.0
		}

		i = 0.0
		while(i < maxIterations){
			t = MultiplyToNew(&z, &b).ref
			c = Norm(&t)
			ScalarDivide(&t, c)
			Assign(&b, &t)
			i = i + 1.0
		}

		eigenvector.numberArray = Array(repeating:Double(), count: Int(n))
		i = 0.0
		while(i < n){
			eigenvector.numberArray[Int(i)] = b.r[Int(i)].c[Int(0)]
			i = i + 1.0
		}
	}

	return !singular
}


func Eigenvectors(_ A : inout Matrix, _ eigenVectorsReference : inout MatrixArrayReference) -> Bool{
	var evsReference : NumberArrayReference
	var success : Bool

	evsReference = NumberArrayReference()
	success = Eigenpairs(&A, &evsReference, &eigenVectorsReference)
	if(success){
		delete(evsReference.numberArray)
		delete(evsReference)
	}

	return success
}


func Eigenpairs(_ A : inout Matrix, _ eigenValuesReference : inout NumberArrayReference, _ eigenVectorsReference : inout MatrixArrayReference) -> Bool{
	return EigenpairsUsingQRAlgorithmAndInversePowerMethod(&A, &eigenValuesReference, &eigenVectorsReference, 0.00000000001, 100.0)
}


func EigenpairsUsingQRAlgorithmAndInversePowerMethod(_ M : inout Matrix, _ eigenValuesReference : inout NumberArrayReference, _ eigenVectorsReference : inout MatrixArrayReference, _ precision : Double, _ maxIterations : Double) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var evecReference : NumberArrayReference
	var done, inverseSuccess : Bool
	var i, j, k, N, v1, v2, eigenValue, withinPrecision : Double
	var A, Q, R, eigenVector : Matrix
	var cp : [Double]

	N = NumberOfRows(&M)

	A = CreateCopyOfMatrix(&M).ref
	Q = CreateCopyOfMatrix(&M).ref
	R = CreateCopyOfMatrix(&M).ref

	done = false
	eigenVectorsReference.matrices = Array(repeating:Matrix(), count: Int(N))
	evecReference = NumberArrayReference()
	eigenValuesReference.numberArray = Array(repeating:Double(), count: Int(N))
	cp = CharacteristicPolynomial(&M)

	j = 0.0
	while(j < N){
		eigenVectorsReference.matrices[Int(j)] = CreateMatrix(N, 1.0).ref
		j = j + 1.0
	}

	i = 0.0
	while(i < maxIterations && !done){
		QRDecomposition(&A, &Q, &R)
		Multiply(&A, &R, &Q)

		/* Check*/
		withinPrecision = 0.0
		ExtractDiagonal(&R, &eigenValuesReference.numberArray)

		j = 0.0
		while(j < N){
			/* Find the correct sign of the eigenvalue.*/
			eigenValue = eigenValuesReference.numberArray[Int(j)]
			v1 = pEvaluate(&cp, eigenValue)
			v2 = pEvaluate(&cp, -eigenValue)
			if(abs(v2) < abs(v1)){
				eigenValuesReference.numberArray[Int(j)] = -eigenValue
				eigenValue = -eigenValue
			}

			/* Calculate the eigenvector corresponding to the eigenvalue.*/
			inverseSuccess = InversePowerMethod(&M, eigenValue, i + 1.0, &evecReference)
			if(inverseSuccess){
				k = 0.0
				while(k < N){
					eigenVectorsReference.matrices[Int(j)].r[Int(k)].c[Int(0)] = evecReference.numberArray[Int(k)]
					k = k + 1.0
				}

				/* Check eigenpair agains precision.*/
				eigenVector = eigenVectorsReference.matrices[Int(j)]

				if(CheckEigenpairPrecision(&M, eigenValue, &eigenVector, precision)){
					withinPrecision = withinPrecision + 1.0
				}
			}
			j = j + 1.0
		}

		if(withinPrecision == N){
			done = true
		}
		i = i + 1.0
	}

	FreeMatrix(&A)
	FreeMatrix(&Q)
	FreeMatrix(&R)
	delete(evecReference)
	delete(cp)

	return done
}


func CheckEigenpairPrecision(_ a : inout Matrix, _ lambda : Double, _ e : inout Matrix, _ precision : Double) -> Bool{
	var lambda = lambda;
	var precision = precision;
	var vec1, vec2 : Matrix
	var equal : Bool

	vec1 = MultiplyToNew(&a, &e).ref
	vec2 = ScalarMultiplyToNew(&e, lambda).ref

	equal = MatrixEqualsEpsilon(&vec1, &vec2, precision)

	return equal
}


func EigenvectorsLaguerreIterationsAndGaussianEliminations(_ A : inout Matrix, _ eigenVectorsReference : inout MatrixArrayReference) -> Bool{
	var Id, t1, B, v : Matrix
	var eigenVectorsResult : [Matrix]
	var success : Bool
	var eigenValuesReference : NumberArrayReference
	var i, lambda, j, N, x, k : Double
	var ev : [Double]

	N = NumberOfRows(&A)

	eigenValuesReference = NumberArrayReference()
	success = Eigenvalues(&A, &eigenValuesReference)

	eigenVectorsResult = Array(repeating:Matrix(), count: Int(N))

	if(success){
		ev = eigenValuesReference.numberArray

		Id = CreateIdentityMatrix(N).ref
		t1 = CreateSquareMatrix(N).ref
		B = CreateSquareMatrix(N).ref

		j = 0.0
		while(j < Double(ev.count) && success){
			lambda = ev[Int(j)]

			/* B = A - lambda * Id*/
			Assign(&t1, &Id)
			ScalarMultiply(&t1, lambda)

			Assign(&B, &A)
			Subtract(&B, &t1)

			GaussianElimination(&B)

			v = CreateMatrix(N, 1.0).ref
			v.r[Int(N - 1.0)].c[Int(0)] = 1.0
			i = N - 2.0
			while(i >= 0.0 && success){
				if(!RowIsZero(&B, i)){
					x = 0.0

					k = N - 1.0
					while(k > i){
						x = x - Element(&B, i, k)*Element(&v, k, 0.0)
						k = k - 1.0
					}

					v.r[Int(i)].c[Int(0)] = x/Element(&B, i, i)
				}else{
					success = false
				}
				i = i - 1.0
			}

			eigenVectorsResult[Int(j)] = v
			j = j + 1.0
		}

		FreeMatrix(&t1)
		FreeMatrix(&B)
		FreeMatrix(&Id)

		eigenVectorsReference.matrices = eigenVectorsResult
	}

	return success
}


func RowIsZero(_ X : inout Matrix, _ r : Double) -> Bool{
	var r = r;
	var isZero : Bool
	var columns, i : Double

	isZero = true

	columns = NumberOfColumns(&X)
	i = 0.0
	while(i < columns && isZero){
		if(Element(&X, r, i) != 0.0){
			isZero = false
		}
		i = i + 1.0
	}

	return isZero
}


func FreeMatrix(_ X : inout Matrix) -> Void{
	FreeMatrixRows(&X.r)
	delete(X)
}


func FreeMatrixRows(_ r : inout [MatrixRow]) -> Void{
	var m, rows : Double

	rows = Double(r.count)
	m = 0.0
	while(m < rows){
		delete(r[Int(m)].c)
		delete(r[Int(m)])
		m = m + 1.0
	}

	delete(r)
}


func CreateDiagonalMatrixFromArray(_ array : inout [Double]) -> MatrixReferenceClass{
	var m : Double
	var matrix : Matrix

	matrix = CreateSquareMatrix(Double(array.count)).ref
	Fill(&matrix, 0.0)

	m = 0.0
	while(m < Double(array.count)){
		matrix.r[Int(m)].c[Int(m)] = array[Int(m)]
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateMatrixFromRowCopies(_ row : inout [Double], _ times : Double) -> MatrixReferenceClass{
	var times = times;
	var m, n : Double
	var matrix : Matrix

	matrix = CreateMatrix(times, Double(row.count)).ref

	m = 0.0
	while(m < times){
		n = 0.0
		while(n < Double(row.count)){
			matrix.r[Int(m)].c[Int(n)] = row[Int(n)]
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func ExtractDiagonal(_ X : inout Matrix, _ diag : inout [Double]) -> Void{
	var n, i : Double

	n = NumberOfRows(&X)

	i = 0.0
	while(i < n){
		diag[Int(i)] = X.r[Int(i)].c[Int(i)]
		i = i + 1.0
	}
}


func ExtractDiagonalToNew(_ X : inout Matrix) -> [Double]{
	var diag : [Double]
	var n, i : Double

	n = NumberOfRows(&X)
	diag = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		diag[Int(i)] = X.r[Int(i)].c[Int(i)]
		i = i + 1.0
	}

	return diag
}


func MatrixEqualsEpsilon(_ a : inout Matrix, _ b : inout Matrix, _ epsilon : Double) -> Bool{
	var epsilon = epsilon;
	var x, y, columns, rows : Double
	var equals : Bool

	equals = true

	if(NumberOfRows(&a) == NumberOfRows(&b) && NumberOfColumns(&a) == NumberOfColumns(&b)){
		columns = NumberOfColumns(&a)
		rows = NumberOfRows(&a)

		x = 0.0
		while(x < rows){
			y = 0.0
			while(y < columns){
				equals = equals && EpsilonCompare(Element(&a, x, y), Element(&b, x, y), epsilon)
				y = y + 1.0
			}
			x = x + 1.0
		}
	}else{
		equals = false
	}

	return equals
}


func Minor(_ x : inout Matrix, _ row : Double, _ column : Double) -> MatrixReferenceClass{
	var row = row;
	var column = column;
	var theMinor : Matrix
	var cols, rows, i, j, m, n : Double

	rows = NumberOfRows(&x) - 1.0
	cols = NumberOfColumns(&x) - 1.0

	theMinor = CreateMatrix(rows, cols).ref

	i = 0.0
	while(i < rows){
		if(i < row){
			m = i
		}else{
			m = i + 1.0
		}

		j = 0.0
		while(i != row && j < cols){
			if(j != column){

				if(j < column){
					n = j
				}else{
					n = j + 1.0
				}

				theMinor.r[Int(m)].c[Int(n)] = x.r[Int(i)].c[Int(j)]
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = theMinor
	return returnReference
}


func QRDecomposition(_ m : inout Matrix, _ Q : inout Matrix, _ R : inout Matrix) -> Void{
	HouseholderMethod(&m, &Q, &R)
}


func HouseholderTriangularizationAlgorithm(_ m : inout Matrix, _ Qout : inout Matrix, _ Rout : inout Matrix) -> Void{
	var P, AA, A, PP, v, vt, t : Matrix
	var i, j, rows, cols, r, s : Double

	rows = NumberOfRows(&m)
	cols = NumberOfColumns(&m)

	P = CreateIdentityMatrix(rows).ref
	A = CreateCopyOfMatrix(&m).ref
	AA = CreateMatrix(rows, cols).ref

	t = CreateMatrix(rows, cols).ref
	PP = CreateIdentityMatrix(rows).ref
	vt = CreateMatrix(1.0, rows).ref

	j = 0.0
	while(j < cols){
		v = ExtractSubMatrix(&A, 0.0, rows - 1.0, j, j).ref
		if(j > 0.0){
			i = 0.0
			while(i < j){
				v.r[Int(i)].c[Int(0)] = 0.0
				i = i + 1.0
			}
		}

		s = Sign(v.r[Int(j)].c[Int(0)])
		if(s == 0.0){
			s = 1.0
		}
		v.r[Int(j)].c[Int(0)] = v.r[Int(j)].c[Int(0)] + Norm(&v)*s
		r = -2.0/(Norm(&v)*Norm(&v))
		Assign(&AA, &A)

		TransposeAssign(&vt, &v)
		Multiply(&t, &vt, &A)
		Assign(&A, &t)
		Multiply(&t, &v, &A)
		Assign(&A, &t)
		ScalarMultiply(&A, r)
		Assign(&t, &AA)
		Add(&A, &AA)

		Assign(&PP, &P)

		Multiply(&t, &vt, &P)
		Assign(&P, &t)
		Multiply(&t, &v, &P)
		Assign(&P, &t)
		ScalarMultiply(&P, r)
		Assign(&t, &AA)
		Add(&P, &PP)
		j = j + 1.0
	}

	Assign(&Rout, &A)
	Assign(&Qout, &P)
	Transpose(&Qout)
}


func HouseholderMethod(_ A : inout Matrix, _ q : inout Matrix, _ r : inout Matrix) -> Void{
	var QR, R, Q : Matrix
	var Rdiag : [Double]
	var m, n : Double
	var i, j, k : Double
	var s, nrm : Double
	var e : Double
	var N, ra, rq : Matrix

	/* Initialize.*/
	QR = CreateCopyOfMatrix(&A).ref
	m = NumberOfRows(&A)
	n = NumberOfColumns(&A)
	Rdiag = Array(repeating:Double(), count: Int(n))

	/* Main loop.*/
	k = 0.0
	while(k < n){
		/* Compute 2-norm of k-th column without under/overflow.*/
		nrm = 0.0
		i = k
		while(i < m){
			nrm = Hypothenuse(nrm, Element(&QR, i, k))
			i = i + 1.0
		}

		if(nrm != 0.0){
			/* Form k-th Householder vector.*/
			if(Element(&QR, k, k) < 0.0){
				nrm = -nrm
			}
			i = k
			while(i < m){
				QR.r[Int(i)].c[Int(k)] = Element(&QR, i, k)/nrm
				i = i + 1.0
			}
			QR.r[Int(k)].c[Int(k)] = Element(&QR, k, k) + 1.0

			/* Apply transformation to remaining columns.*/
			j = k + 1.0
			while(j < n){
				s = 0.0
				i = k
				while(i < m){
					s = s + Element(&QR, i, k)*Element(&QR, i, j)
					i = i + 1.0
				}
				s = -s/Element(&QR, k, k)
				i = k
				while(i < m){
					QR.r[Int(i)].c[Int(j)] = Element(&QR, i, j) + s*Element(&QR, i, k)
					i = i + 1.0
				}
				j = j + 1.0
			}
		}
		Rdiag[Int(k)] = -nrm
		k = k + 1.0
	}

	/* Compute R*/
	R = CreateSquareMatrix(n).ref
	i = 0.0
	while(i < n){
		j = 0.0
		while(j < n){
			if(i < j){
				R.r[Int(i)].c[Int(j)] = Element(&QR, i, j)
			}else if(i == j){
				R.r[Int(i)].c[Int(j)] = Rdiag[Int(i)]
			}else{
				R.r[Int(i)].c[Int(j)] = 0.0
			}
			j = j + 1.0
		}
		i = i + 1.0
	}
	Assign(&r, &R)

	/* Compute Q*/
	Q = CreateMatrix(m, n).ref
	k = n - 1.0
	while(k >= 0.0){
		i = 0.0
		while(i < m){
			Q.r[Int(i)].c[Int(k)] = 0.0
			i = i + 1.0
		}
		Q.r[Int(k)].c[Int(k)] = 1.0
		j = k
		while(j < n){
			if(Element(&QR, k, k) != 0.0){
				s = 0.0
				i = k
				while(i < m){
					s = s + Element(&QR, i, k)*Element(&Q, i, j)
					i = i + 1.0
				}
				s = -s/Element(&QR, k, k)
				i = k
				while(i < m){
					Q.r[Int(i)].c[Int(j)] = Element(&Q, i, j) + s*Element(&QR, i, k)
					i = i + 1.0
				}
			}
			j = j + 1.0
		}
		k = k - 1.0
	}
	Assign(&q, &Q)

	/* Adjust for positive R.*/
	n = NumberOfRows(&r)

	N = CreateIdentityMatrix(n).ref

	i = 0.0
	while(i < n){
		e = Element(&r, i, i)

		if(e < 0.0){
			N.r[Int(i)].c[Int(i)] = -1.0
		}
		i = i + 1.0
	}

	ra = MultiplyToNew(&N, &r).ref
	Assign(&r, &ra)
	rq = MultiplyToNew(&q, &N).ref
	Assign(&q, &rq)

	FreeMatrix(&ra)
	FreeMatrix(&rq)
	FreeMatrix(&Q)
	FreeMatrix(&R)
	FreeMatrix(&QR)
}


func Hypothenuse(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return sqrt(pow(a, 2.0) + pow(b, 2.0))
}


func Norm(_ a : inout Matrix) -> Double{
	var l, i, j, rows, cols : Double

	l = 0.0

	rows = NumberOfRows(&a)
	cols = NumberOfColumns(&a)

	i = 0.0
	while(i < rows){
		j = 0.0
		while(j < cols){
			l = l + a.r[Int(i)].c[Int(j)]*a.r[Int(i)].c[Int(j)]
			j = j + 1.0
		}
		i = i + 1.0
	}
	l = sqrt(l)

	return l
}


func ExtractSubMatrix(_ M : inout Matrix, _ r1 : Double, _ r2 : Double, _ c1 : Double, _ c2 : Double) -> MatrixReferenceClass{
	var r1 = r1;
	var r2 = r2;
	var c1 = c1;
	var c2 = c2;
	var A : Matrix
	var i, j : Double

	A = CreateMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0).ref

	i = r1
	while(i <= r2){
		j = c1
		while(j <= c2){
			A.r[Int(i - r1)].c[Int(j - c1)] = M.r[Int(i)].c[Int(j)]
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = A
	return returnReference
}


func QRAlgorithm(_ M : inout Matrix, _ R : inout Matrix, _ A : inout Matrix, _ Q : inout Matrix, _ precision : Double, _ maxIterations : Double) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var n, i, j, v : Double
	var previous : [Double]
	var withinPrecision : Double
	var done, previousSet : Bool

	Assign(&A, &M)
	n = NumberOfRows(&M)
	previous = Array(repeating:Double(), count: Int(n))
	previousSet = false

	done = false
	i = 0.0
	while(i < maxIterations && !done){
		QRDecomposition(&A, &Q, &R)
		Multiply(&A, &R, &Q)

		/* Check precision.*/
		if(previousSet){
			withinPrecision = 0.0
			j = 0.0
			while(j < n){
				v = previous[Int(j)] - Element(&A, j, j)
				if(abs(v) < precision || v == 0.0){
					withinPrecision = withinPrecision + 1.0
				}
				j = j + 1.0
			}
			if(withinPrecision == n){
				done = true
			}
		}

		j = 0.0
		while(j < n){
			previous[Int(j)] = Element(&A, j, j)
			j = j + 1.0
		}
		previousSet = true
		i = i + 1.0
	}

	return done
}


func InvertUpperTriangularMatrix(_ A : inout Matrix, _ inverse : inout Matrix) -> Bool{
	var sum, i, j, k, n : Double
	var success : Bool

	inverse.r = CreateCopyOfMatrix(&A).ref.r
	n = NumberOfRows(&inverse)
	success = true

	i = n - 1.0
	while(i >= 0.0 && success){
		if(Element(&inverse, i, i) == 0.0){
			success = false
		}else{
			inverse.r[Int(i)].c[Int(i)] = 1.0/Element(&inverse, i, i)
			j = i - 1.0
			while(j >= 0.0 && success){
				sum = 0.0
				k = i
				while(k > j){
					sum = sum - Element(&inverse, j, k)*Element(&inverse, k, i)
					k = k - 1.0
				}
				if(Element(&inverse, j, j) == 0.0){
					success = false
				}else{
					inverse.r[Int(j)].c[Int(i)] = sum/Element(&inverse, j, j)
				}
				j = j - 1.0
			}
		}
		i = i - 1.0
	}

	return success
}


func InvertLowerTriangularMatrix(_ A : inout Matrix, _ inverse : inout Matrix) -> Bool{
	var sum, i, j, k, n : Double
	var success : Bool

	inverse.r = CreateCopyOfMatrix(&A).ref.r
	n = NumberOfRows(&inverse)
	success = true

	i = 0.0
	while(i < n && success){
		if(Element(&inverse, i, i) == 0.0){
			success = false
		}else{
			inverse.r[Int(i)].c[Int(i)] = 1.0/Element(&inverse, i, i)
			j = i + 1.0
			while(j < n){
				sum = 0.0
				k = i
				while(k < j && success){
					sum = sum - Element(&inverse, j, k)*Element(&inverse, k, i)
					k = k + 1.0
				}
				if(Element(&inverse, j, j) == 0.0){
					success = false
				}else{
					inverse.r[Int(j)].c[Int(i)] = sum/Element(&inverse, j, j)
				}
				j = j + 1.0
			}
		}
		i = i + 1.0
	}

	return success
}


func ParseMatrixFromString(_ aref : inout MatrixReference, _ matrixString : inout [Character], _ errorMessage : inout StringReference) -> Bool{
	var success : Bool
	var lines : [StringReference]
	var rows, cols, i : Double
	var row : [Double]
	var replaced, trimmed : [Character]

	replaced = strReplaceString(&matrixString, &characterArray("\r").ca, &characterArray("").ca)
	trimmed = strTrim(&replaced)
	lines = strSplitByCharacter(&trimmed, "\n")

	delete(replaced)
	delete(trimmed)

	success = true

	rows = Double(lines.count)
	if(rows == 0.0){
		aref.matrix = CreateMatrix(0.0, 0.0).ref
	}else{
		row = StringToNumberArray(&lines[Int(0)].stringx)
		cols = Double(row.count)
		delete(row)

		aref.matrix = CreateMatrix(rows, cols).ref

		i = 0.0
		while(i < rows && success){
			delete(aref.matrix.r[Int(i)].c)
			aref.matrix.r[Int(i)].c = StringToNumberArray(&lines[Int(i)].stringx)

			if(Double(aref.matrix.r[Int(i)].c.count) != cols){
				success = false
				errorMessage.stringx = characterArray("All rows must have the same number of columns.").ca
			}
			i = i + 1.0
		}
	}

	FreeStringReferenceArray(&lines)

	return success
}


func MatrixToString(_ matrix : inout Matrix, _ digitsAfterPoint : Double) -> [Character]{
	var digitsAfterPoint = digitsAfterPoint;
	var s1, s2 : [Character]
	var n, m, element : Double

	s1 = Array(repeating:Character(" "), count: Int(0))

	n = 0.0
	while(n < NumberOfRows(&matrix)){
		m = 0.0
		while(m < NumberOfColumns(&matrix)){
			element = Element(&matrix, n, m)
			element = RoundToDigits(element, digitsAfterPoint)
			s2 = strAppendString(&s1, &CreateStringDecimalFromNumber(element))
			delete(s1)
			s1 = s2
			if(m + 1.0 != NumberOfColumns(&matrix)){
				s2 = strAppendString(&s1, &characterArray(", ").ca)
				delete(s1)
				s1 = s2
			}
			m = m + 1.0
		}
		s2 = strAppendString(&s1, &characterArray("\n").ca)
		delete(s1)
		s1 = s2
		n = n + 1.0
	}

	return s1
}


func MatrixArrayToString(_ matrices : inout [Matrix], _ digitsAfterPoint : Double) -> [Character]{
	var digitsAfterPoint = digitsAfterPoint;
	var s1, s2 : [Character]
	var i : Double

	s1 = Array(repeating:Character(" "), count: Int(0))

	i = 0.0
	while(i < Double(matrices.count)){
		s2 = strAppendString(&s1, &MatrixToString(&matrices[Int(i)], digitsAfterPoint))
		delete(s1)
		s1 = s2

		s2 = strAppendString(&s1, &characterArray("\n").ca)
		delete(s1)
		s1 = s2
		i = i + 1.0
	}

	return s1
}


func RoundMatrixElementsToDigits(_ a : inout Matrix, _ digits : Double) -> Void{
	var digits = digits;
	var m, n : Double

	m = 0.0
	while(m < NumberOfRows(&a)){
		n = 0.0
		while(n < NumberOfColumns(&a)){
			a.r[Int(m)].c[Int(n)] = RoundToDigits(Element(&a, m, n), digits)
			if(a.r[Int(m)].c[Int(n)] == -0.0){
				a.r[Int(m)].c[Int(n)] = 0.0
			}
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func SingularValueDecomposition(_ Ap : inout Matrix, _ URef : inout MatrixReference, _ SigmaRef : inout MatrixReference, _ VRef : inout MatrixReference) -> Bool{
	var A, U, V : Matrix
	var m, n, nu, nct, nrt, i, j, k, t, pp, iter, eps, tiny, kase, f, cs, sn, ks, size, orgm, orgn : Double
	var scale, sp, spm1, epm1, sk, ek, b, c, shift, g, p : Double
	var done : Bool
	var s, e, work : [Double]

	/* Square matrix, adjust results correspondingly.*/
	orgm = NumberOfRows(&Ap)
	orgn = NumberOfColumns(&Ap)
	size = max(orgm, orgn)
	A = CreateCopyOfMatrix(&Ap).ref
	Resize(&A, size, size)

	/* Initialize.*/
	m = size
	n = size

	/* Compute*/
	nu = min(m, n)
	s = Array(repeating:Double(), count: Int(min(m + 1.0, n)))
	U = CreateMatrix(m, nu).ref
	V = CreateSquareMatrix(n).ref
	e = Array(repeating:Double(), count: Int(n))
	work = Array(repeating:Double(), count: Int(m))

	/* Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.*/
	nct = min(m - 1.0, n)
	nrt = max(0.0, min(n - 2.0, m))
	k = 0.0
	while(k < max(nct, nrt)){
		if(k < nct){

			/* Compute the transformation for the k-th column and place the k-th diagonal in s[k].*/
			/* Compute 2-norm of k-th column without under/overflow.*/
			s[Int(k)] = 0.0
			i = k
			while(i < m){
				s[Int(k)] = Hypothenuse(s[Int(k)], Element(&A, i, k))
				i = i + 1.0
			}
			if(s[Int(k)] != 0.0){
				if(Element(&A, k, k) < 0.0){
					s[Int(k)] = -s[Int(k)]
				}
				i = k
				while(i < m){
					A.r[Int(i)].c[Int(k)] = Element(&A, i, k)/s[Int(k)]
					i = i + 1.0
				}
				A.r[Int(k)].c[Int(k)] = Element(&A, k, k) + 1.0
			}
			s[Int(k)] = -s[Int(k)]
		}
		j = k + 1.0
		while(j < n){
			if((k < nct) && (s[Int(k)] != 0.0)){

				/* Apply the transformation.*/
				t = 0.0
				i = k
				while(i < m){
					t = t + Element(&A, i, k)*Element(&A, i, j)
					i = i + 1.0
				}
				t = -t/Element(&A, k, k)
				i = k
				while(i < m){
					A.r[Int(i)].c[Int(j)] = Element(&A, i, j) + t*Element(&A, i, k)
					i = i + 1.0
				}
			}

			/* Place the k-th row of A into e for the subsequent calculation of the row transformation.*/
			e[Int(j)] = Element(&A, k, j)
			j = j + 1.0
		}
		if(k < nct){

			/* Place the transformation in U for subsequent back*/
			/* multiplication.*/
			i = k
			while(i < m){
				U.r[Int(i)].c[Int(k)] = Element(&A, i, k)
				i = i + 1.0
			}
		}
		if(k < nrt){
			/* Compute the k-th row transformation and place the k-th super-diagonal in e[k].*/
			/* Compute 2-norm without under/overflow.*/
			e[Int(k)] = 0.0
			i = k + 1.0
			while(i < n){
				e[Int(k)] = Hypothenuse(e[Int(k)], e[Int(i)])
				i = i + 1.0
			}
			if(e[Int(k)] != 0.0){
				if(e[Int(k + 1.0)] < 0.0){
					e[Int(k)] = -e[Int(k)]
				}
				i = k + 1.0
				while(i < n){
					e[Int(i)] = e[Int(i)]/e[Int(k)]
					i = i + 1.0
				}
				e[Int(k + 1.0)] = e[Int(k + 1.0)] + 1.0
			}
			e[Int(k)] = -e[Int(k)]
			if((k + 1.0 < m) && (e[Int(k)] != 0.0)){

				/* Apply the transformation.*/
				i = k + 1.0
				while(i < m){
					work[Int(i)] = 0.0
					i = i + 1.0
				}
				j = k + 1.0
				while(j < n){
					i = k + 1.0
					while(i < m){
						work[Int(i)] = work[Int(i)] + e[Int(j)]*Element(&A, i, j)
						i = i + 1.0
					}
					j = j + 1.0
				}
				j = k + 1.0
				while(j < n){
					t = -e[Int(j)]/e[Int(k + 1.0)]
					i = k + 1.0
					while(i < m){
						A.r[Int(i)].c[Int(j)] = Element(&A, i, j) + t*work[Int(i)]
						i = i + 1.0
					}
					j = j + 1.0
				}
			}

			/* Place the transformation in V for subsequent back multiplication.*/
			i = k + 1.0
			while(i < n){
				V.r[Int(i)].c[Int(k)] = e[Int(i)]
				i = i + 1.0
			}
		}
		k = k + 1.0
	}

	/* Set up the final bidiagonal matrix or order p.*/
	p = min(n, m + 1.0)
	if(nct < n){
		s[Int(nct)] = Element(&A, nct, nct)
	}
	if(m < p){
		s[Int(p - 1.0)] = 0.0
	}
	if(nrt + 1.0 < p){
		e[Int(nrt)] = Element(&A, nrt, p - 1.0)
	}
	e[Int(p - 1.0)] = 0.0

	/* Generate U.*/
	j = nct
	while(j < nu){
		i = 0.0
		while(i < m){
			U.r[Int(i)].c[Int(j)] = 0.0
			i = i + 1.0
		}
		U.r[Int(j)].c[Int(j)] = 1.0
		j = j + 1.0
	}
	k = nct - 1.0
	while(k >= 0.0){
		if(s[Int(k)] != 0.0){
			j = k + 1.0
			while(j < nu){
				t = 0.0
				i = k
				while(i < m){
					t = t + Element(&U, i, k)*Element(&U, i, j)
					i = i + 1.0
				}
				t = -t/Element(&U, k, k)
				i = k
				while(i < m){
					U.r[Int(i)].c[Int(j)] = Element(&U, i, j) + t*Element(&U, i, k)
					i = i + 1.0
				}
				j = j + 1.0
			}
			i = k
			while(i < m){
				U.r[Int(i)].c[Int(k)] = -Element(&U, i, k)
				i = i + 1.0
			}
			U.r[Int(k)].c[Int(k)] = 1.0 + Element(&U, k, k)
			i = 0.0
			while(i < k - 1.0){
				U.r[Int(i)].c[Int(k)] = 0.0
				i = i + 1.0
			}
		}else{
			i = 0.0
			while(i < m){
				U.r[Int(i)].c[Int(k)] = 0.0
				i = i + 1.0
			}
			U.r[Int(k)].c[Int(k)] = 1.0
		}
		k = k - 1.0
	}

	/* Generate V.*/
	k = n - 1.0
	while(k >= 0.0){
		if((k < nrt) && (e[Int(k)] != 0.0)){
			j = k + 1.0
			while(j < nu){
				t = 0.0
				i = k + 1.0
				while(i < n){
					t = t + Element(&V, i, k)*Element(&V, i, j)
					i = i + 1.0
				}
				t = -t/Element(&V, k + 1.0, k)
				i = k + 1.0
				while(i < n){
					V.r[Int(i)].c[Int(j)] = Element(&V, i, j) + t*Element(&V, i, k)
					i = i + 1.0
				}
				j = j + 1.0
			}
		}
		i = 0.0
		while(i < n){
			V.r[Int(i)].c[Int(k)] = 0.0
			i = i + 1.0
		}
		V.r[Int(k)].c[Int(k)] = 1.0
		k = k - 1.0
	}

	/* Main iteration loop for the singular values.*/
	pp = p - 1.0
	iter = 0.0
	eps = pow(2.0, -52.0)
	tiny = pow(2.0, -966.0)
	while(p > 0.0){
		/* Here is where a test for too many iterations would go.*/
		/* This section of the program inspects for negligible elements in the s and e arrays.*/
		/* On completion the variables kase and k are set as follows.*/
		/* kase = 1, if s(p) and e[k-1] are negligible and k<p*/
		/* kase = 2, if s(k) is negligible and k<p*/
		/* kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).*/
		/* kase = 4, if e(p-1) is negligible (convergence).*/
		done = false
		k = p - 2.0
		while(k > -1.0 && !done){
			if(abs(e[Int(k)]) <= tiny + eps*(abs(s[Int(k)]) + abs(s[Int(k + 1.0)]))){
				e[Int(k)] = 0.0
				done = true
			}else{
				k = k - 1.0
			}
		}
		if(k == p - 2.0){
			kase = 4.0
		}else{
			done = false
			ks = p - 1.0
			while(ks > k && !done){
				if(ks != p){
					t = abs(e[Int(ks)])
				}else{
					t = 0.0
				}

				if(ks != k + 1.0){
					t = t + abs(e[Int(ks - 1.0)])
				}

				if(abs(s[Int(ks)]) <= tiny + eps*t){
					s[Int(ks)] = 0.0
					done = true
				}else{
					ks = ks - 1.0
				}
			}
			if(ks == k){
				kase = 3.0
			}else if(ks == p - 1.0){
				kase = 1.0
			}else{
				kase = 2.0
				k = ks
			}
		}
		k = k + 1.0

		/* Perform the task indicated by kase.*/
		if(kase == 1.0){
			/* Deflate negligible s(p).*/
			f = e[Int(p - 2.0)]
			e[Int(p - 2.0)] = 0.0
			j = p - 2.0
			while(j >= k){
				t = Hypothenuse(s[Int(j)], f)
				cs = s[Int(j)]/t
				sn = f/t
				s[Int(j)] = t
				if(j != k){
					f = -sn*e[Int(j - 1.0)]
					e[Int(j - 1.0)] = cs*e[Int(j - 1.0)]
				}

				i = 0.0
				while(i < n){
					t = cs*Element(&V, i, j) + sn*Element(&V, i, p - 1.0)
					V.r[Int(i)].c[Int(p - 1.0)] = -sn*Element(&V, i, j) + cs*Element(&V, i, p - 1.0)
					V.r[Int(i)].c[Int(j)] = t
					i = i + 1.0
				}
				j = j - 1.0
			}
		}else if(kase == 2.0){
			/* Split at negligible s(k).*/
			f = e[Int(k - 1.0)]
			e[Int(k - 1.0)] = 0.0
			j = k
			while(j < p){
				t = Hypothenuse(s[Int(j)], f)
				cs = s[Int(j)]/t
				sn = f/t
				s[Int(j)] = t
				f = -sn*e[Int(j)]
				e[Int(j)] = cs*e[Int(j)]

				i = 0.0
				while(i < m){
					t = cs*Element(&U, i, j) + sn*Element(&U, i, k + 1.0)
					U.r[Int(i)].c[Int(k - 1.0)] = -sn*Element(&U, i, j) + cs*Element(&U, i, k + 1.0)
					U.r[Int(i)].c[Int(j)] = t
					i = i + 1.0
				}
				j = j + 1.0
			}
		}else if(kase == 3.0){
			/* Perform one qr step.*/
			/* Calculate the shift.*/
			scale = max(max(max(max(abs(s[Int(p - 1.0)]), abs(s[Int(p - 2.0)])), abs(e[Int(p - 2.0)])), abs(s[Int(k)])), abs(e[Int(k)]))
			sp = s[Int(p - 1.0)]/scale
			spm1 = s[Int(p - 2.0)]/scale
			epm1 = e[Int(p - 2.0)]/scale
			sk = s[Int(k)]/scale
			ek = e[Int(k)]/scale
			b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1)/2.0
			c = (sp*epm1)*(sp*epm1)
			shift = 0.0
			if((b != 0.0) || (c != 0.0)){
				shift = sqrt(b*b + c)
				if(b < 0.0){
					shift = -shift
				}
				shift = c/(b + shift)
			}
			f = (sk + sp)*(sk - sp) + shift
			g = sk*ek

			/* Chase zeros.*/
			j = k
			while(j < p - 1.0){
				t = Hypothenuse(f, g)
				cs = f/t
				sn = g/t
				if(j != k){
					e[Int(j - 1.0)] = t
				}
				f = cs*s[Int(j)] + sn*e[Int(j)]
				e[Int(j)] = cs*e[Int(j)] - sn*s[Int(j)]
				g = sn*s[Int(j + 1.0)]
				s[Int(j + 1.0)] = cs*s[Int(j + 1.0)]
				i = 0.0
				while(i < n){
					t = cs*Element(&V, i, j) + sn*Element(&V, i, j + 1.0)
					V.r[Int(i)].c[Int(j + 1.0)] = -sn*Element(&V, i, j) + cs*Element(&V, i, j + 1.0)
					V.r[Int(i)].c[Int(j)] = t
					i = i + 1.0
				}
				t = Hypothenuse(f, g)
				cs = f/t
				sn = g/t
				s[Int(j)] = t
				f = cs*e[Int(j)] + sn*s[Int(j + 1.0)]
				s[Int(j + 1.0)] = -sn*e[Int(j)] + cs*s[Int(j + 1.0)]
				g = sn*e[Int(j + 1.0)]
				e[Int(j + 1.0)] = cs*e[Int(j + 1.0)]
				if(j < m - 1.0){
					i = 0.0
					while(i < m){
						t = cs*Element(&U, i, j) + sn*Element(&U, i, j + 1.0)
						U.r[Int(i)].c[Int(j + 1.0)] = -sn*Element(&U, i, j) + cs*Element(&U, i, j + 1.0)
						U.r[Int(i)].c[Int(j)] = t
						i = i + 1.0
					}
				}
				j = j + 1.0
			}
			e[Int(p - 2.0)] = f
			iter = iter + 1.0
		}else if(kase == 4.0){
			/* Make the singular values positive.*/
			if(s[Int(k)] <= 0.0){
				if(s[Int(k)] < 0.0){
					s[Int(k)] = -s[Int(k)]
				}else{
					s[Int(k)] = 0.0
				}

				i = 0.0
				while(i <= pp){
					V.r[Int(i)].c[Int(k)] = -Element(&V, i, k)
					i = i + 1.0
				}
			}

			/* Order the singular values.*/
			while(k < pp && s[Int(k)] < s[Int(k + 1.0)]){
				t = s[Int(k)]
				s[Int(k)] = s[Int(k + 1.0)]
				s[Int(k + 1.0)] = t
				if(k < n - 1.0){
					i = 0.0
					while(i < n){
						t = Element(&V, i, k + 1.0)
						V.r[Int(i)].c[Int(k + 1.0)] = Element(&V, i, k)
						V.r[Int(i)].c[Int(k)] = t
						i = i + 1.0
					}
				}
				if(k < m - 1.0){
					i = 0.0
					while(i < m){
						t = Element(&U, i, k + 1.0)
						U.r[Int(i)].c[Int(k + 1.0)] = Element(&U, i, k)
						U.r[Int(i)].c[Int(k)] = t
						i = i + 1.0
					}
				}
				k = k + 1.0
			}
			iter = 0.0
			p = p - 1.0
		}
	}

	Resize(&U, orgm, orgm)
	Resize(&V, orgn, orgn)

	URef.matrix = U
	VRef.matrix = V
	SigmaRef.matrix = CreateMatrix(orgm, orgn).ref
	i = 0.0
	while(i < min(orgm, orgn)){
		SigmaRef.matrix.r[Int(i)].c[Int(i)] = s[Int(i)]
		i = i + 1.0
	}

	return true
}


func CreateComplexMatrix(_ rows : Double, _ cols : Double) -> ComplexMatrixReferenceClass{
	var rows = rows;
	var cols = cols;
	var m, n : Double
	var matrix : ComplexMatrix

	matrix = ComplexMatrix()
	matrix.r = Array(repeating:ComplexMatrixRow(), count: Int(rows))
	m = 0.0
	while(m < rows){
		matrix.r[Int(m)] = ComplexMatrixRow()
		matrix.r[Int(m)].c = Array(repeating:cComplexNumber(), count: Int(cols))
		n = 0.0
		while(n < cols){
			matrix.r[Int(m)].c[Int(n)] = cCreateComplexNumber(0.0, 0.0).ref
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateComplexMatrixFromMatrix(_ a : inout Matrix) -> ComplexMatrixReferenceClass{
	var m, n, rows, cols : Double
	var matrix : ComplexMatrix

	rows = NumberOfRows(&a)
	cols = NumberOfColumns(&a)

	matrix = ComplexMatrix()
	matrix.r = Array(repeating:ComplexMatrixRow(), count: Int(rows))
	m = 0.0
	while(m < rows){
		matrix.r[Int(m)] = ComplexMatrixRow()
		matrix.r[Int(m)].c = Array(repeating:cComplexNumber(), count: Int(cols))
		n = 0.0
		while(n < cols){
			matrix.r[Int(m)].c[Int(n)] = cCreateComplexNumber(a.r[Int(m)].c[Int(n)], 0.0).ref
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateReMatrixFromComplexMatrix(_ a : inout ComplexMatrix) -> MatrixReferenceClass{
	var m, n, rows, cols : Double
	var matrix : Matrix

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfColumnsComplex(&a)

	matrix = Matrix()
	matrix.r = Array(repeating:MatrixRow(), count: Int(rows))
	m = 0.0
	while(m < rows){
		matrix.r[Int(m)] = MatrixRow()
		matrix.r[Int(m)].c = Array(repeating:Double(), count: Int(cols))
		n = 0.0
		while(n < cols){
			matrix.r[Int(m)].c[Int(n)] = IndexComplex(&a, m, n).ref.re
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateImMatrixFromComplexMatrix(_ a : inout ComplexMatrix) -> MatrixReferenceClass{
	var m, n, rows, cols : Double
	var matrix : Matrix

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfColumnsComplex(&a)

	matrix = Matrix()
	matrix.r = Array(repeating:MatrixRow(), count: Int(rows))
	m = 0.0
	while(m < rows){
		matrix.r[Int(m)] = MatrixRow()
		matrix.r[Int(m)].c = Array(repeating:Double(), count: Int(cols))
		n = 0.0
		while(n < cols){
			matrix.r[Int(m)].c[Int(n)] = IndexComplex(&a, m, n).ref.im
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = MatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func NumberOfRowsComplex(_ A : inout ComplexMatrix) -> Double{
	return Double(A.r.count)
}


func NumberOfColumnsComplex(_ A : inout ComplexMatrix) -> Double{
	return Double(A.r[Int(0)].c.count)
}


func IndexComplex(_ a : inout ComplexMatrix, _ m : Double, _ n : Double) -> cComplexNumberReferenceClass{
	var m = m;
	var n = n;
	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = a.r[Int(m)].c[Int(n)]
	return returnReference
}


func AddComplex(_ a : inout ComplexMatrix, _ b : inout ComplexMatrix) -> Void{
	var m, n : Double
	var d : Double

	d = NumberOfRowsComplex(&a)

	m = 0.0
	while(m < d){
		n = 0.0
		while(n < d){
			cAdd(&IndexComplex(&a, m, n).ref, &IndexComplex(&b, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func SubtractComplex(_ a : inout ComplexMatrix, _ b : inout ComplexMatrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&a)
	c = NumberOfColumnsComplex(&a)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cSub(&IndexComplex(&a, m, n).ref, &IndexComplex(&b, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func SubtractComplexToNew(_ a : inout ComplexMatrix, _ b : inout ComplexMatrix) -> ComplexMatrixReferenceClass{
	var X : ComplexMatrix

	X = CreateCopyOfComplexMatrix(&a).ref
	SubtractComplex(&X, &b)

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func MultiplyComplex(_ x : inout ComplexMatrix, _ a : inout ComplexMatrix, _ b : inout ComplexMatrix) -> Void{
	var m, n : Double
	var rows, cols, d : Double
	var i : Double
	var s, t : cComplexNumber

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfColumnsComplex(&b)
	d = NumberOfColumnsComplex(&a)
	t = cCreateComplexNumber(0.0, 0.0).ref

	m = 0.0
	while(m < rows){
		n = 0.0
		while(n < cols){
			s = cCreateComplexNumber(0.0, 0.0).ref

			i = 0.0
			while(i < d){
				cAssignComplex(&t, &s)
				cAssignComplex(&s, &IndexComplex(&a, m, i).ref)
				cMul(&s, &IndexComplex(&b, i, n).ref)
				cAdd(&s, &t)
				i = i + 1.0
			}

			x.r[Int(m)].c[Int(n)] = s
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func MultiplyComplexToNew(_ a : inout ComplexMatrix, _ b : inout ComplexMatrix) -> ComplexMatrixReferenceClass{
	var rows, cols : Double
	var x : ComplexMatrix

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfColumnsComplex(&b)
	x = CreateComplexMatrix(rows, cols).ref
	MultiplyComplex(&x, &a, &b)

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = x
	return returnReference
}


func Conjugate(_ a : inout ComplexMatrix) -> Void{
	var m, n : Double
	var rows, cols : Double

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfRowsComplex(&a)

	m = 0.0
	while(m < rows){
		n = 0.0
		while(n < cols){
			cConjugate(&IndexComplex(&a, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func AssignComplexMatrix(_ A : inout ComplexMatrix, _ B : inout ComplexMatrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&A)
	c = NumberOfColumnsComplex(&A)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cAssignComplex(&IndexComplex(&A, m, n).ref, &IndexComplex(&B, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ScalarMultiplyComplex(_ A : inout ComplexMatrix, _ b : inout cComplexNumber) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&A)
	c = NumberOfColumnsComplex(&A)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cMul(&IndexComplex(&A, m, n).ref, &b)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ScalarMultiplyComplexToNew(_ A : inout ComplexMatrix, _ b : inout cComplexNumber) -> ComplexMatrixReferenceClass{
	var matrix : ComplexMatrix

	matrix = CreateCopyOfComplexMatrix(&A).ref
	ScalarMultiplyComplex(&matrix, &b)

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func ScalarDivideComplex(_ A : inout ComplexMatrix, _ b : inout cComplexNumber) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&A)
	c = NumberOfColumnsComplex(&A)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cDiv(&IndexComplex(&A, m, n).ref, &b)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func ElementWisePowerComplex(_ A : inout ComplexMatrix, _ p : Double) -> Void{
	var p = p;
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&A)
	c = NumberOfColumnsComplex(&A)

	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cPower(&IndexComplex(&A, m, n).ref, p)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func CreateComplexIdentityMatrix(_ d : Double) -> ComplexMatrixReferenceClass{
	var d = d;
	var m : Double
	var matrix : ComplexMatrix

	matrix = CreateSquareComplexMatrix(d).ref
	FillComplex(&matrix, 0.0, 0.0)

	m = 0.0
	while(m < d){
		IndexComplex(&matrix, m, m).ref.re = 1.0
		m = m + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func CreateSquareComplexMatrix(_ d : Double) -> ComplexMatrixReferenceClass{
	var d = d;
	var m, n : Double
	var matrix : ComplexMatrix

	matrix = ComplexMatrix()
	matrix.r = Array(repeating:ComplexMatrixRow(), count: Int(d))
	m = 0.0
	while(m < d){
		matrix.r[Int(m)] = ComplexMatrixRow()
		matrix.r[Int(m)].c = Array(repeating:cComplexNumber(), count: Int(d))
		n = 0.0
		while(n < d){
			matrix.r[Int(m)].c[Int(n)] = cCreateComplexNumber(0.0, 0.0).ref
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = matrix
	return returnReference
}


func ClearComplex(_ a : inout ComplexMatrix) -> Void{
	FillComplex(&a, 0.0, 0.0)
}


func FillComplex(_ a : inout ComplexMatrix, _ re : Double, _ im : Double) -> Void{
	var re = re;
	var im = im;
	var m, n : Double

	m = 0.0
	while(m < NumberOfRowsComplex(&a)){
		n = 0.0
		while(n < NumberOfColumnsComplex(&a)){
			IndexComplex(&a, m, n).ref.re = re
			IndexComplex(&a, m, n).ref.im = im
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func TraceComplex(_ a : inout ComplexMatrix) -> cComplexNumberReferenceClass{
	var m : Double
	var d : Double
	var tr : cComplexNumber

	tr = cCreateComplexNumber(0.0, 0.0).ref

	d = Double(a.r.count)
	m = 0.0
	while(m < d){
		cAdd(&tr, &IndexComplex(&a, m, m).ref)
		m = m + 1.0
	}

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = tr
	return returnReference
}


func CofactorOfComplexMatrix(_ mat : inout ComplexMatrix, _ temp : inout ComplexMatrix, _ p : Double, _ q : Double, _ n : Double) -> Void{
	var p = p;
	var q = q;
	var n = n;
	var i, j : Double
	var row, col : Double

	i = 0.0
	j = 0.0

	row = 0.0
	while(row < n){
		col = 0.0
		while(col < n){
			if(row != p && col != q){
				cAssignComplex(&IndexComplex(&temp, i, j).ref, &IndexComplex(&mat, row, col).ref)
				j = j + 1.0

				if(j == n - 1.0){
					j = 0.0
					i = i + 1.0
				}
			}
			col = col + 1.0
		}
		row = row + 1.0
	}
}


func DeterminantOfComplexSubmatrix(_ mat : inout ComplexMatrix, _ n : Double) -> cComplexNumberReferenceClass{
	var n = n;
	var f, sign : Double
	var D, t : cComplexNumber
	var temp : ComplexMatrix

	D = cCreateComplexNumber(0.0, 0.0).ref
	t = cCreateComplexNumber(0.0, 0.0).ref

	if(n == 1.0){
		D = mat.r[Int(0)].c[Int(0)]
	}else{
		temp = CreateSquareComplexMatrix(n).ref

		sign = 1.0

		f = 0.0
		while(f < n){
			CofactorOfComplexMatrix(&mat, &temp, 0.0, f, n)
			cAssignComplexByValues(&t, sign, 0.0)
			cMul(&t, &IndexComplex(&mat, 0.0, f).ref)
			cMul(&t, &DeterminantOfComplexSubmatrix(&temp, n - 1.0).ref)
			cAdd(&D, &t)
			sign = -sign
			f = f + 1.0
		}

		DeleteComplexMatrix(&temp)
	}

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = D
	return returnReference
}


func DeleteComplexMatrix(_ X : inout ComplexMatrix) -> Void{
	var m, n, rows, cols : Double

	rows = NumberOfRowsComplex(&X)
	cols = NumberOfColumnsComplex(&X)
	m = 0.0
	while(m < rows){
		n = 0.0
		while(n < cols){
			delete(X.r[Int(m)].c[Int(n)])
			n = n + 1.0
		}
		delete(X.r[Int(m)].c)
		delete(X.r[Int(m)])
		m = m + 1.0
	}

	delete(X.r)
	delete(X)
}


func DeterminantComplex(_ m : inout ComplexMatrix) -> cComplexNumberReferenceClass{
	var n : Double
	var D : cComplexNumber

	n = NumberOfRowsComplex(&m)
	D = DeterminantOfComplexSubmatrix(&m, n).ref

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = D
	return returnReference
}


func AdjointComplex(_ A : inout ComplexMatrix, _ adj : inout ComplexMatrix) -> Void{
	var n : Double
	var cofactors : ComplexMatrix
	var i, j : Double
	var t, sign : cComplexNumber

	n = Double(A.r.count)
	t = cCreateComplexNumber(0.0, 0.0).ref
	sign = cCreateComplexNumber(0.0, 0.0).ref

	if(n == 1.0){
		cAssignComplexByValues(&IndexComplex(&adj, 0.0, 0.0).ref, 1.0, 0.0)
	}else{
		cofactors = CreateSquareComplexMatrix(n).ref

		i = 0.0
		while(i < n){
			j = 0.0
			while(j < n){
				CofactorOfComplexMatrix(&A, &cofactors, i, j, n)

				if((i + j).truncatingRemainder(dividingBy:2.0) == 0.0){
					cAssignComplexByValues(&sign, 1.0, 0.0)
				}else{
					cAssignComplexByValues(&sign, -1.0, 0.0)
				}

				cAssignComplex(&t, &sign)
				cMul(&t, &DeterminantOfComplexSubmatrix(&cofactors, n - 1.0).ref)
				cAssignComplex(&IndexComplex(&adj, j, i).ref, &t)
				j = j + 1.0
			}
			i = i + 1.0
		}

		DeleteComplexMatrix(&cofactors)
	}
}


func InverseComplex(_ A : inout ComplexMatrix, _ inverseResult : inout ComplexMatrix) -> Bool{
	var success : Bool
	var adj : ComplexMatrix
	var n, i, j : Double
	var det, t : cComplexNumber

	t = cCreateComplexNumber(0.0, 0.0).ref

	if(NumberOfColumnsComplex(&A) == NumberOfRowsComplex(&A)){
		n = NumberOfColumnsComplex(&A)

		det = DeterminantComplex(&A).ref
		if(det.re != 0.0 || det.im != 0.0){
			adj = CreateSquareComplexMatrix(n).ref
			AdjointComplex(&A, &adj)

			i = 0.0
			while(i < n){
				j = 0.0
				while(j < n){
					cAssignComplex(&t, &IndexComplex(&adj, i, j).ref)
					cDiv(&t, &det)
					cAssignComplex(&IndexComplex(&inverseResult, i, j).ref, &t)
					j = j + 1.0
				}
				i = i + 1.0
			}

			success = true
			DeleteComplexMatrix(&adj)
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func ComplexMatrixEqualsEpsilon(_ b : inout ComplexMatrix, _ f : inout ComplexMatrix, _ epsilon : Double) -> Bool{
	var epsilon = epsilon;
	var x, y, columns, rows : Double
	var equals : Bool

	equals = true

	if(NumberOfRowsComplex(&b) == NumberOfRowsComplex(&f) && NumberOfColumnsComplex(&b) == NumberOfColumnsComplex(&f)){
		columns = NumberOfColumnsComplex(&b)
		rows = NumberOfRowsComplex(&b)

		x = 0.0
		while(x < rows){
			y = 0.0
			while(y < columns){
				equals = equals && cEpsilonCompareComplex(&IndexComplex(&b, x, y).ref, &IndexComplex(&f, x, y).ref, epsilon)
				y = y + 1.0
			}
			x = x + 1.0
		}
	}else{
		equals = false
	}

	return equals
}


func MinorComplex(_ x : inout ComplexMatrix, _ row : Double, _ column : Double) -> ComplexMatrixReferenceClass{
	var row = row;
	var column = column;
	var minor : ComplexMatrix
	var cols, rows, i, j, m, n : Double

	rows = NumberOfRowsComplex(&x) - 1.0
	cols = NumberOfColumnsComplex(&x) - 1.0

	minor = CreateComplexMatrix(rows, cols).ref

	i = 0.0
	while(i < rows){
		if(i < row){
			m = i
		}else{
			m = i + 1.0
		}

		j = 0.0
		while(i != row && j < cols){
			if(j != column){

				if(j < column){
					n = j
				}else{
					n = j + 1.0
				}

				cAssignComplex(&IndexComplex(&minor, m, n).ref, &IndexComplex(&x, i, j).ref)
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = minor
	return returnReference
}


func AssignComplex(_ A : inout ComplexMatrix, _ B : inout ComplexMatrix) -> Void{
	var m, n : Double
	var r, c : Double

	r = NumberOfRowsComplex(&A)
	c = NumberOfColumnsComplex(&A)
	m = 0.0
	while(m < r){
		n = 0.0
		while(n < c){
			cAssignComplex(&IndexComplex(&A, m, n).ref, &IndexComplex(&B, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func CreateCopyOfComplexMatrix(_ A : inout ComplexMatrix) -> ComplexMatrixReferenceClass{
	var X : ComplexMatrix

	X = CreateComplexMatrix(NumberOfRowsComplex(&A), NumberOfColumnsComplex(&A)).ref
	AssignComplex(&X, &A)

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = X
	return returnReference
}


func TransposeComplex(_ a : inout ComplexMatrix) -> Bool{
	var m, n : Double
	var rows : Double
	var square : Bool
	var tmp : cComplexNumber

	tmp = cCreateComplexNumber(0.0, 0.0).ref

	square = IsSquareComplexMatrix(&a)
	if(square){
		rows = NumberOfColumnsComplex(&a)

		m = 0.0
		while(m < rows){
			n = 0.0
			while(n < m){
				cAssignComplex(&tmp, &IndexComplex(&a, n, m).ref)
				cAssignComplex(&IndexComplex(&a, n, m).ref, &IndexComplex(&a, m, n).ref)
				cAssignComplex(&IndexComplex(&a, m, n).ref, &tmp)
				n = n + 1.0
			}
			m = m + 1.0
		}
	}

	return square
}


func ConjugateTransposeComplex(_ a : inout ComplexMatrix) -> Bool{
	var m, n : Double
	var rows : Double
	var square : Bool
	var tmp : cComplexNumber

	tmp = cCreateComplexNumber(0.0, 0.0).ref

	square = IsSquareComplexMatrix(&a)
	if(square){
		rows = NumberOfColumnsComplex(&a)

		m = 0.0
		while(m < rows){
			n = 0.0
			while(n < m){
				cAssignComplex(&tmp, &IndexComplex(&a, n, m).ref)
				cAssignComplex(&IndexComplex(&a, n, m).ref, &IndexComplex(&a, m, n).ref)
				cAssignComplex(&IndexComplex(&a, m, n).ref, &tmp)
				cConjugate(&IndexComplex(&a, m, n).ref)
				n = n + 1.0
			}
			m = m + 1.0
		}
	}

	return square
}


func IsSquareComplexMatrix(_ A : inout ComplexMatrix) -> Bool{
	var isx : Bool

	if(NumberOfRowsComplex(&A) == NumberOfColumnsComplex(&A)){
		isx = true
	}else{
		isx = false
	}

	return isx
}


func TransposeComplexAssign(_ t : inout ComplexMatrix, _ a : inout ComplexMatrix) -> Void{
	var m, n : Double
	var rows, cols : Double

	cols = NumberOfRowsComplex(&a)
	rows = NumberOfColumnsComplex(&a)

	m = 0.0
	while(m < cols){
		n = 0.0
		while(n < rows){
			cAssignComplex(&IndexComplex(&t, n, m).ref, &IndexComplex(&a, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}
}


func TransposeComplexToNew(_ a : inout ComplexMatrix) -> ComplexMatrixReferenceClass{
	var m, n : Double
	var rows, cols : Double
	var c : ComplexMatrix

	cols = NumberOfRowsComplex(&a)
	rows = NumberOfColumnsComplex(&a)

	c = CreateComplexMatrix(rows, cols).ref

	m = 0.0
	while(m < cols){
		n = 0.0
		while(n < rows){
			cAssignComplex(&IndexComplex(&c, n, m).ref, &IndexComplex(&a, m, n).ref)
			n = n + 1.0
		}
		m = m + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = c
	return returnReference
}


func ExtractComplexSubMatrix(_ M : inout ComplexMatrix, _ r1 : Double, _ r2 : Double, _ c1 : Double, _ c2 : Double) -> ComplexMatrixReferenceClass{
	var r1 = r1;
	var r2 = r2;
	var c1 = c1;
	var c2 = c2;
	var A : ComplexMatrix
	var i, j : Double

	A = CreateComplexMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0).ref

	i = r1
	while(i <= r2){
		j = c1
		while(j <= c2){
			cAssignComplex(&IndexComplex(&A, i - r1, j - c1).ref, &IndexComplex(&M, i, j).ref)
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = ComplexMatrixReferenceClass()
	returnReference.ref = A
	return returnReference
}


func NormComplex(_ a : inout ComplexMatrix) -> Double{
	var l, i, j, rows, cols : Double
	var cComplexNumber : cComplexNumber

	l = 0.0

	rows = NumberOfRowsComplex(&a)
	cols = NumberOfColumnsComplex(&a)

	i = 0.0
	while(i < rows){
		j = 0.0
		while(j < cols){
			cComplexNumber = IndexComplex(&a, i, j).ref
			l = l + pow(cComplexNumber.re, 2.0) + pow(cComplexNumber.im, 2.0)
			j = j + 1.0
		}
		i = i + 1.0
	}
	l = sqrt(l)

	return l
}


func ComplexCharacteristicPolynomial(_ A : inout ComplexMatrix, _ p : inout pComplexPolynomial) -> Void{
	var cp : ComplexMatrix
	var determinant : cComplexNumber

	cp = CreateSquareComplexMatrix(NumberOfRowsComplex(&A)).ref
	determinant = cComplexNumber()

	ComplexCharacteristicPolynomialWithInverse(&A, &cp, &p, &determinant)

	DeleteComplexMatrix(&cp)
}


func ComplexCharacteristicPolynomialWithInverse(_ A : inout ComplexMatrix, _ AInverse : inout ComplexMatrix, _ p : inout pComplexPolynomial, _ determinant : inout cComplexNumber) -> Void{
	FaddeevLeVerrierAlgorithmComplex(&A, &AInverse, &p, &determinant)
}


func FaddeevLeVerrierAlgorithmComplex(_ A : inout ComplexMatrix, _ AInverse : inout ComplexMatrix, _ p : inout pComplexPolynomial, _ determinant : inout cComplexNumber) -> Void{
	var Mk, Mkm1, t1, Id : ComplexMatrix
	var t, t2, n1 : cComplexNumber
	var i, n, k : Double

	n1 = cCreateComplexNumber(-1.0, 0.0).ref
	n = NumberOfRowsComplex(&A)
	p.cs = Array(repeating:cComplexNumber(), count: Int(n + 1.0))
	i = 0.0
	while(i < n + 1.0){
		p.cs[Int(i)] = cComplexNumber()
		i = i + 1.0
	}
	cAssignComplexByValues(&p.cs[Int(n)], 1.0, 0.0)
	Mkm1 = CreateSquareComplexMatrix(n).ref
	FillComplex(&Mkm1, 0.0, 0.0)
	Id = CreateComplexIdentityMatrix(n).ref
	Mk = CreateSquareComplexMatrix(n).ref
	t1 = CreateSquareComplexMatrix(n).ref

	k = 1.0
	while(k <= n){
		MultiplyComplex(&Mk, &A, &Mkm1)
		AssignComplex(&t1, &Id)
		ScalarMultiplyComplex(&t1, &p.cs[Int(n - k + 1.0)])
		AddComplex(&Mk, &t1)

		MultiplyComplex(&t1, &A, &Mk)
		t = TraceComplex(&t1).ref
		t2 = cCreateComplexNumber(-1.0/k, 0.0).ref
		cMul(&t, &t2)
		cAssignComplex(&p.cs[Int(n - k)], &t)

		/* done*/
		AssignComplex(&Mkm1, &Mk)

		if(k == n){
			AssignComplex(&AInverse, &Mk)
			cAssignComplex(&t, &p.cs[Int(0)])
			cMul(&t, &n1)
			cAssignComplex(&determinant, &t)
			if(t.re == 0.0 && t.im == 0.0){
			}else{
				ScalarDivideComplex(&AInverse, &t)
			}
		}
		k = k + 1.0
	}

	DeleteComplexMatrix(&Mkm1)
	DeleteComplexMatrix(&Id)
	DeleteComplexMatrix(&Mk)
	DeleteComplexMatrix(&t1)
}


func EigenvaluesComplex(_ A : inout ComplexMatrix, _ eigenValuesReference : inout cComplexNumberArrayReference) -> Bool{
	var eigenVectorsReference : ComplexMatrixArrayReference
	var success : Bool
	var i : Double

	eigenVectorsReference = ComplexMatrixArrayReference()
	success = EigenpairsComplex(&A, &eigenValuesReference, &eigenVectorsReference)
	if(success){
		i = 0.0
		while(i < Double(eigenVectorsReference.matrices.count)){
			DeleteComplexMatrix(&eigenVectorsReference.matrices[Int(i)])
			i = i + 1.0
		}
		delete(eigenVectorsReference.matrices)
		delete(eigenVectorsReference)
	}

	return success
}


func EigenvectorsComplex(_ A : inout ComplexMatrix, _ eigenVectorsReference : inout ComplexMatrixArrayReference) -> Bool{
	var evsReference : cComplexNumberArrayReference
	var success : Bool
	var i : Double

	evsReference = cComplexNumberArrayReference()
	success = EigenpairsComplex(&A, &evsReference, &eigenVectorsReference)
	if(success){
		i = 0.0
		while(i < Double(evsReference.complexNumbers.count)){
			delete(evsReference.complexNumbers[Int(i)])
			i = i + 1.0
		}
		delete(evsReference.complexNumbers)
		delete(evsReference)
	}

	return success
}


func InversePowerMethodComplex(_ A : inout ComplexMatrix, _ eigenvalue : inout cComplexNumber, _ maxIterations : Double, _ eigenvector : inout cComplexNumberArrayReference) -> Bool{
	var maxIterations = maxIterations;
	var t1, t2, t3, t4, b : ComplexMatrix
	var n, i, c : Double
	var isSingular : Bool
	var c101, k, cc : cComplexNumber

	n = NumberOfRowsComplex(&A)

	t2 = CreateComplexIdentityMatrix(n).ref
	ScalarMultiplyComplex(&t2, &eigenvalue)
	t3 = SubtractComplexToNew(&A, &t2).ref
	t4 = CreateSquareComplexMatrix(n).ref
	isSingular = !InverseComplex(&t3, &t4)
	cc = cCreateComplexNumber(0.0, 0.0).ref
	t1 = CreateComplexMatrix(n, 1.0).ref

	if(isSingular){
		DeleteComplexMatrix(&t2)
		DeleteComplexMatrix(&t3)
		DeleteComplexMatrix(&t4)

		c101 = cCreateComplexNumber(1.01, 0.0).ref
		/* Try again with more erroneous eigenvalue estimate.*/
		t2 = CreateComplexIdentityMatrix(n).ref
		k = cMulToNew(&eigenvalue, &c101).ref
		ScalarMultiplyComplex(&t2, &k)
		t3 = SubtractComplexToNew(&A, &t2).ref
		t4 = CreateSquareComplexMatrix(n).ref
		isSingular = !InverseComplex(&t3, &t4)
		delete(c101)
	}

	if(!isSingular){
		b = CreateComplexMatrix(n, 1.0).ref

		i = 0.0
		while(i < n){
			cAssignComplexByValues(&b.r[Int(i)].c[Int(0)], 1.0, 1.0)
			i = i + 1.0
		}

		i = 0.0
		while(i < maxIterations){
			MultiplyComplex(&t1, &t4, &b)
			c = NormComplex(&t1)
			cAssignComplexByValues(&cc, c, 0.0)
			ScalarDivideComplex(&t1, &cc)
			AssignComplex(&b, &t1)
			i = i + 1.0
		}

		eigenvector.complexNumbers = Array(repeating:cComplexNumber(), count: Int(n))
		i = 0.0
		while(i < n){
			eigenvector.complexNumbers[Int(i)] = b.r[Int(i)].c[Int(0)]
			i = i + 1.0
		}
	}

	DeleteComplexMatrix(&t1)
	DeleteComplexMatrix(&t2)
	DeleteComplexMatrix(&t3)
	DeleteComplexMatrix(&t4)
	delete(cc)

	return !isSingular
}


func EigenpairsComplex(_ M : inout ComplexMatrix, _ eigenValuesReference : inout cComplexNumberArrayReference, _ eigenVectorsReference : inout ComplexMatrixArrayReference) -> Bool{
	return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(&M, &eigenValuesReference, &eigenVectorsReference, 0.000001, 100.0)
}


func ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(_ M : inout ComplexMatrix, _ eigenValuesReference : inout cComplexNumberArrayReference, _ eigenVectorsReference : inout ComplexMatrixArrayReference, _ precision : Double, _ maxIterations : Double) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var success, inverseSuccess : Bool
	var n, i, j, k, withinPrecision : Double
	var t1, t2, t3, xn1, eigenValue : cComplexNumber
	var rs, rsPrev : [cComplexNumber]
	var p : pComplexPolynomial
	var evecReference : cComplexNumberArrayReference
	var eigenVector : ComplexMatrix

	evecReference = cComplexNumberArrayReference()

	p = pComplexPolynomial()
	ComplexCharacteristicPolynomial(&M, &p)

	n = Double(p.cs.count) - 1.0
	rs = Array(repeating:cComplexNumber(), count: Int(n))
	i = 0.0
	while(i < n){
		rs[Int(i)] = cCreateComplexNumber(0.0, 0.0).ref
		i = i + 1.0
	}
	rsPrev = Array(repeating:cComplexNumber(), count: Int(n))
	i = 0.0
	while(i < n){
		rsPrev[Int(i)] = cCreateComplexNumber(0.4, 0.9).ref
		cPower(&rsPrev[Int(i)], i)
		i = i + 1.0
	}
	t2 = cCreateComplexNumber(0.0, 0.0).ref
	t3 = cCreateComplexNumber(0.0, 0.0).ref

	success = false

	eigenVectorsReference.matrices = Array(repeating:ComplexMatrix(), count: Int(n))
	i = 0.0
	while(i < n){
		eigenVectorsReference.matrices[Int(i)] = CreateComplexMatrix(n, 1.0).ref
		i = i + 1.0
	}

	i = 0.0
	while(i < maxIterations && !success){
		j = 0.0
		while(j < n){
			xn1 = rsPrev[Int(j)]

			t1 = pEvaluateComplex(&p, &xn1).ref
			cAssignComplexByValues(&t2, 1.0, 0.0)
			k = 0.0
			while(k < n){
				if(k < j){
					cAssignComplex(&t3, &xn1)
					cSub(&t3, &rs[Int(k)])
					cMul(&t2, &t3)
				}
				if(k > j){
					cAssignComplex(&t3, &xn1)
					cSub(&t3, &rsPrev[Int(k)])
					cMul(&t2, &t3)
				}
				k = k + 1.0
			}
			cDiv(&t1, &t2)
			cAssignComplex(&rs[Int(j)], &xn1)
			cSub(&rs[Int(j)], &t1)

			delete(t1)
			j = j + 1.0
		}
		withinPrecision = 0.0
		j = 0.0
		while(j < n){
			eigenValue = rs[Int(j)]

			/* Calculate the eigenvector corresponding to the eigenvalue.*/
			inverseSuccess = InversePowerMethodComplex(&M, &eigenValue, i + 1.0, &evecReference)
			if(inverseSuccess){
				k = 0.0
				while(k < n){
					eigenVectorsReference.matrices[Int(j)].r[Int(k)].c[Int(0)] = evecReference.complexNumbers[Int(k)]
					k = k + 1.0
				}

				/* Check eigenpair agains precision.*/
				eigenVector = eigenVectorsReference.matrices[Int(j)]

				if(CheckComplexEigenpairPrecision(&M, &eigenValue, &eigenVector, precision)){
					withinPrecision = withinPrecision + 1.0
				}
				cAssignComplex(&rsPrev[Int(j)], &rs[Int(j)])
			}
			j = j + 1.0
		}
		if(withinPrecision == n){
			success = true
		}
		i = i + 1.0
	}

	eigenValuesReference.complexNumbers = rs

	return success
}


func CheckComplexEigenpairPrecision(_ a : inout ComplexMatrix, _ lambda : inout cComplexNumber, _ e : inout ComplexMatrix, _ precision : Double) -> Bool{
	var precision = precision;
	var vec1, vec2 : ComplexMatrix
	var equal : Bool

	vec1 = MultiplyComplexToNew(&a, &e).ref
	vec2 = ScalarMultiplyComplexToNew(&e, &lambda).ref

	equal = ComplexMatrixEqualsEpsilon(&vec1, &vec2, precision)

	return equal
}


func vectorCreate2DVector(_ a0 : Double, _ a1 : Double) -> [Double]{
	var a0 = a0;
	var a1 = a1;
	var vector : [Double]

	vector = Array(repeating:Double(), count: Int(2))
	vector[Int(0)] = a0
	vector[Int(1)] = a1

	return vector
}


func vectorCreate3DVector(_ a0 : Double, _ a1 : Double, _ a2 : Double) -> [Double]{
	var a0 = a0;
	var a1 = a1;
	var a2 = a2;
	var vector : [Double]

	vector = Array(repeating:Double(), count: Int(3))
	vector[Int(0)] = a0
	vector[Int(1)] = a1
	vector[Int(2)] = a2

	return vector
}


func vectorCreate4DVector(_ a0 : Double, _ a1 : Double, _ a2 : Double, _ a3 : Double) -> [Double]{
	var a0 = a0;
	var a1 = a1;
	var a2 = a2;
	var a3 = a3;
	var vector : [Double]

	vector = Array(repeating:Double(), count: Int(4))
	vector[Int(0)] = a0
	vector[Int(1)] = a1
	vector[Int(2)] = a2
	vector[Int(3)] = a3

	return vector
}


func vectorDotProductWithCheck(_ a : inout [Double], _ b : inout [Double], _ answer : inout NumberReference, _ errorMessage : inout StringReference) -> Bool{
	var sum : Double
	var success : Bool

	sum = 0.0

	if(Double(a.count) == Double(b.count)){
		sum = vectorDotProduct(&a, &b)
		success = true
	}else{
		errorMessage.stringx = characterArray("The dimensions have to be equal.").ca
		success = false
	}

	answer.numberValue = sum

	return success
}


func vectorDotProduct(_ a : inout [Double], _ b : inout [Double]) -> Double{
	var sum, i : Double

	sum = 0.0
	/* Dot product is the sum of the products of the corresponding entries of two vectors.*/
	i = 0.0
	while(i < Double(a.count)){
		sum = sum + a[Int(i)]*b[Int(i)]
		i = i + 1.0
	}

	return sum
}


func vectorMagnitude(_ a : inout [Double]) -> Double{
	var sum, i : Double

	sum = 0.0

	i = 0.0
	while(i < Double(a.count)){
		sum = sum + pow(a[Int(i)], 2.0)
		i = i + 1.0
	}
	sum = sqrt(sum)

	return sum
}


func vectorCrossProduct3dWithCheck(_ a : inout [Double], _ b : inout [Double], _ answer : inout NumberArrayReference, _ errorMessage : inout StringReference) -> Bool{
	var crossProduct : [Double]
	var success : Bool

	crossProduct = Array(repeating:Double(), count: Int(3))

	if(Double(a.count) == 3.0 && Double(b.count) == 3.0){
		crossProduct[Int(0)] = a[Int(1)]*b[Int(2)] - b[Int(1)]*a[Int(2)]
		crossProduct[Int(1)] = a[Int(2)]*b[Int(0)] - b[Int(2)]*a[Int(0)]
		crossProduct[Int(2)] = a[Int(0)]*b[Int(1)] - b[Int(0)]*a[Int(1)]

		success = true
	}else{
		errorMessage.stringx = characterArray("The dimensions must be 3.").ca
		success = false
	}

	answer.numberArray = crossProduct

	return success
}


func vectorSum(_ a : inout [Double]) -> Double{
	var s, i : Double

	s = 0.0

	i = 0.0
	while(i < Double(a.count)){
		s = s + a[Int(i)]
		i = i + 1.0
	}

	return s
}


func vectorProduct(_ a : inout [Double]) -> Double{
	var p, i : Double

	p = 1.0

	i = 0.0
	while(i < Double(a.count)){
		p = p*a[Int(i)]
		i = i + 1.0
	}

	return p
}


func vectorCumulativeSum(_ a : inout [Double]) -> Void{
	var s, i : Double

	s = 0.0

	i = 0.0
	while(i < Double(a.count)){
		s = s + a[Int(i)]
		a[Int(i)] = s
		i = i + 1.0
	}
}


func vectorCumulativeProduct(_ a : inout [Double]) -> Void{
	var p, i : Double

	p = 1.0

	i = 0.0
	while(i < Double(a.count)){
		p = p*a[Int(i)]
		a[Int(i)] = p
		i = i + 1.0
	}
}


func vectorAdd(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		a[Int(i)] = a[Int(i)] + b[Int(i)]
		i = i + 1.0
	}
}


func vectorSubtract(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		a[Int(i)] = a[Int(i)] - b[Int(i)]
		i = i + 1.0
	}
}


func vectorMultiply(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		a[Int(i)] = a[Int(i)]*b[Int(i)]
		i = i + 1.0
	}
}


func vectorDivide(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		a[Int(i)] = a[Int(i)]/b[Int(i)]
		i = i + 1.0
	}
}


func vectorAddToNew(_ a : inout [Double], _ b : inout [Double]) -> [Double]{
	var i : Double
	var c : [Double]

	c = Array(repeating:Double(), count: Int(min(Double(a.count), Double(b.count))))

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		c[Int(i)] = a[Int(i)] + b[Int(i)]
		i = i + 1.0
	}

	return c
}


func vectorSubtractToNew(_ a : inout [Double], _ b : inout [Double]) -> [Double]{
	var i : Double
	var c : [Double]

	c = Array(repeating:Double(), count: Int(min(Double(a.count), Double(b.count))))

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		c[Int(i)] = a[Int(i)] - b[Int(i)]
		i = i + 1.0
	}

	return c
}


func vectorMultiplyToNew(_ a : inout [Double], _ b : inout [Double]) -> [Double]{
	var i : Double
	var c : [Double]

	c = Array(repeating:Double(), count: Int(min(Double(a.count), Double(b.count))))

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		c[Int(i)] = a[Int(i)]*b[Int(i)]
		i = i + 1.0
	}

	return c
}


func vectorDivideToNew(_ a : inout [Double], _ b : inout [Double]) -> [Double]{
	var i : Double
	var c : [Double]

	c = Array(repeating:Double(), count: Int(min(Double(a.count), Double(b.count))))

	i = 0.0
	while(i < Double(a.count) && i < Double(b.count)){
		c[Int(i)] = a[Int(i)]/b[Int(i)]
		i = i + 1.0
	}

	return c
}


func vectorPower(_ a : inout [Double], _ p : Double) -> Void{
	var p = p;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = pow(a[Int(i)], p)
		i = i + 1.0
	}
}


func CreateLinearCongruentialGeneratorNumericalRecipes(_ seed : Double) -> LinearCongruentialGeneratorReferenceClass{
	var seed = seed;
	var returnReference = LinearCongruentialGeneratorReferenceClass()
	returnReference.ref = CreateLinearCongruentialGeneratorCustom(pow(2.0, 29.0), 1664525.0, 1013904223.0, seed).ref
	return returnReference
}


func CreateLinearCongruentialGeneratorCustom(_ modulus : Double, _ multiplier : Double, _ increment : Double, _ seed : Double) -> LinearCongruentialGeneratorReferenceClass{
	var modulus = modulus;
	var multiplier = multiplier;
	var increment = increment;
	var seed = seed;
	var lcg : LinearCongruentialGenerator

	lcg = LinearCongruentialGenerator()
	lcg.m = modulus
	lcg.a = multiplier
	lcg.c = increment
	lcg.x = seed

	var returnReference = LinearCongruentialGeneratorReferenceClass()
	returnReference.ref = lcg
	return returnReference
}


func LinearCongruentialGeneratorNextNumber(_ lcg : inout LinearCongruentialGenerator) -> Double{
	lcg.x = floor((lcg.a*lcg.x + lcg.c).truncatingRemainder(dividingBy:lcg.m))

	return lcg.x/lcg.m
}


func CreatePseudorandomNumberGenerator(_ seed : Double) -> PseudorandomGeneratorReferenceClass{
	var seed = seed;
	var prg : PseudorandomGenerator

	prg = PseudorandomGenerator()
	prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed).ref

	var returnReference = PseudorandomGeneratorReferenceClass()
	returnReference.ref = prg
	return returnReference
}


func PseudorandomNextNumber(_ prg : inout PseudorandomGenerator) -> Double{
	return LinearCongruentialGeneratorNextNumber(&prg.lcg)
}


func PseudorandomNextInteger(_ prg : inout PseudorandomGenerator, _ n : Double) -> Double{
	var n = n;
	return floor(PseudorandomNextNumber(&prg)*n)
}


func PseudorandomNextIntegerBetween(_ prg : inout PseudorandomGenerator, _ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return ceil(a) + floor(PseudorandomNextNumber(&prg)*(b - a))
}


func GaloisField2e8Add(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return Xor2Byte(a, b)
}


func GaloisField2e8Sub(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return Xor2Byte(a, b)
}


func GaloisField2e8Mul(_ a : Double, _ b : Double, _ modulusPolynomial : Double) -> Double{
	var a = a;
	var b = b;
	var modulusPolynomial = modulusPolynomial;
	var r : Double

	r = 0.0

	while(b != 0.0){
		if(And2Byte(b, 1.0) == 1.0){
			r = Xor2Byte(r, a)
		}
		b = ShiftRight2Byte(b, 1.0)
		a = ShiftLeft2Byte(a, 1.0)
		if((And2Byte(a, 256.0) == 256.0)){
			a = Xor2Byte(a, modulusPolynomial)
		}
	}

	return r
}


func GaloisField2e8Reciprocal(_ a : Double, _ modulusPolynomial : Double) -> Double{
	var a = a;
	var modulusPolynomial = modulusPolynomial;
	var ga, i, inv : Double
	var done : Bool

	ga = a
	done = false
	inv = 0.0

	i = 0.0
	while(i < ShiftLeft2Byte(1.0, 8.0) && !done){
		if(GaloisField2e8Mul(ga, i, modulusPolynomial) == 1.0){
			done = true
			inv = i
		}
		i = i + 1.0
	}

	return inv
}


func FindRoots(_ p : inout [Double], _ rootsReference : inout NumberArrayReference) -> Bool{
	return DurandKernerMethod(&p, 0.000001, 100.0, &rootsReference)
}


func LaguerresMethodWithRepeatedDivision(_ p : inout [Double], _ maxIterations : Double, _ precision : Double, _ guess : Double, _ rootsReference : inout NumberArrayReference) -> Bool{
	var maxIterations = maxIterations;
	var precision = precision;
	var guess = guess;
	var n, nr, xk : Double
	var x : [Double]
	var q, r, d : [Double]
	var success : Bool
	var xkReference : NumberReference

	n = pDegree(&p)

	x = Array(repeating:Double(), count: Int(n))

	q = pCreatePolynomial(n)
	r = pCreatePolynomial(n)
	d = pCreatePolynomial(n)

	success = true
	xkReference = CreateNumberReference(0.0).ref

	nr = 0.0
	while(nr < n && success){
		success = LaguerresMethod(&p, guess, maxIterations, precision, &xkReference)

		if(success){
			xk = xkReference.numberValue
			x[Int(nr)] = xk

			pFill(&d, 0.0)
			d[Int(0)] = -xk
			d[Int(1)] = 1.0
			pDivide(&q, &r, &p, &d)
			pAssign(&p, &q)
		}
		nr = nr + 1.0
	}

	delete(q)
	delete(r)
	delete(d)
        
	rootsReference.numberArray = x

	return success
}


func LaguerresMethod(_ p : inout [Double], _ guess : Double, _ maxIterations : Double, _ precision : Double, _ rootReference : inout NumberReference) -> Bool{
	var guess = guess;
	var maxIterations = maxIterations;
	var precision = precision;
	var k, a, G, H, xk, denom1, denom2, denom, t1, n : Double
	var success : Bool

	n = pDegree(&p)
	success = true

	xk = guess

	k = 0.0
	while((k < maxIterations) && (abs(pEvaluate(&p, xk)) >= precision) && success){
		G = pEvaluateDerivative(&p, xk, 1.0)/pEvaluate(&p, xk)
		H = pow(G, 2.0) - pEvaluateDerivative(&p, xk, 2.0)/pEvaluate(&p, xk)
		t1 = (n - 1.0)*(n*H - pow(G, 2.0))
		if(t1 >= 0.0){
			denom = sqrt(t1)
			denom1 = G + denom
			denom2 = G - denom
			if(abs(denom1) >= abs(denom2)){
				denom = denom1
			}else{
				denom = denom2
			}
			a = n/denom

			xk = xk - a
		}else{
			success = false
		}
		k = k + 1.0
	}

	if(k == maxIterations){
		success = false
	}

	if(abs(pEvaluate(&p, xk)) >= precision){
		success = false
	}

	rootReference.numberValue = xk

	return success
}


func DurandKernerMethod(_ p : inout [Double], _ precision : Double, _ maxIterations : Double, _ rootsReference : inout NumberArrayReference) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var success : Bool
	var n, i, j, k, t1, t2, xn1, withinPrecision : Double
	var rs, rsPrev : [Double]

	n = Double(p.count) - 1.0
	rs = Array(repeating:Double(), count: Int(n))
	rsPrev = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		rsPrev[Int(i)] = i
		i = i + 1.0
	}

	success = false

	i = 0.0
	while(i < maxIterations && !success){
		j = 0.0
		while(j < n){
			xn1 = rsPrev[Int(j)]

			t1 = pEvaluate(&p, xn1)
			t2 = 1.0
			k = 0.0
			while(k < n){
				if(k < j){
					t2 = t2*(xn1 - rs[Int(k)])
				}
				if(k > j){
					t2 = t2*(xn1 - rsPrev[Int(k)])
				}
				k = k + 1.0
			}
			t1 = t1/t2
			rs[Int(j)] = xn1 - t1
			j = j + 1.0
		}
		withinPrecision = 0.0
		j = 0.0
		while(j < n){
			if(EpsilonCompare(rsPrev[Int(j)], rs[Int(j)], precision)){
				withinPrecision = withinPrecision + 1.0
			}
			rsPrev[Int(j)] = rs[Int(j)]
			j = j + 1.0
		}
		if(withinPrecision == n){
			success = true
		}
		i = i + 1.0
	}

	rootsReference.numberArray = rs

	return success
}


func FindRootsComplex(_ p : inout pComplexPolynomial, _ rootsReference : inout cComplexNumberArrayReference) -> Bool{
	return DurandKernerMethodComplex(&p, 0.000001, 100.0, &rootsReference)
}


func DurandKernerMethodComplex(_ p : inout pComplexPolynomial, _ precision : Double, _ maxIterations : Double, _ rootsReference : inout cComplexNumberArrayReference) -> Bool{
	var precision = precision;
	var maxIterations = maxIterations;
	var success : Bool
	var n, i, j, k, withinPrecision : Double
	var t1, t2, t3, xn1 : cComplexNumber
	var rs, rsPrev : [cComplexNumber]

	n = Double(p.cs.count) - 1.0
	rs = Array(repeating:cComplexNumber(), count: Int(n))
	i = 0.0
	while(i < n){
		rs[Int(i)] = cCreateComplexNumber(0.0, 0.0).ref
		i = i + 1.0
	}
	rsPrev = Array(repeating:cComplexNumber(), count: Int(n))
	i = 0.0
	while(i < n){
		rsPrev[Int(i)] = cCreateComplexNumber(0.4, 0.9).ref
		cPower(&rsPrev[Int(i)], i)
		i = i + 1.0
	}
	t2 = cCreateComplexNumber(0.0, 0.0).ref
	t3 = cCreateComplexNumber(0.0, 0.0).ref

	success = false

	i = 0.0
	while(i < maxIterations && !success){
		j = 0.0
		while(j < n){
			xn1 = rsPrev[Int(j)]

			t1 = pEvaluateComplex(&p, &xn1).ref
			cAssignComplexByValues(&t2, 1.0, 0.0)
			k = 0.0
			while(k < n){
				if(k < j){
					cAssignComplex(&t3, &xn1)
					cSub(&t3, &rs[Int(k)])
					cMul(&t2, &t3)
				}
				if(k > j){
					cAssignComplex(&t3, &xn1)
					cSub(&t3, &rsPrev[Int(k)])
					cMul(&t2, &t3)
				}
				k = k + 1.0
			}
			cDiv(&t1, &t2)
			cAssignComplex(&rs[Int(j)], &xn1)
			cSub(&rs[Int(j)], &t1)
			j = j + 1.0
		}
		withinPrecision = 0.0
		j = 0.0
		while(j < n){
			if(cEpsilonCompareComplex(&rsPrev[Int(j)], &rs[Int(j)], precision)){
				withinPrecision = withinPrecision + 1.0
			}
			cAssignComplex(&rsPrev[Int(j)], &rs[Int(j)])
			j = j + 1.0
		}
		if(withinPrecision == n){
			success = true
		}
		i = i + 1.0
	}

	rootsReference.complexNumbers = rs

	return success
}


func cCreateComplexNumber(_ re : Double, _ im : Double) -> cComplexNumberReferenceClass{
	var re = re;
	var im = im;
	var z : cComplexNumber

	z = cComplexNumber()
	z.re = re
	z.im = im

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = z
	return returnReference
}


func cCreatePolarComplexNumber(_ r : Double, _ phi : Double) -> cPolarComplexNumberReferenceClass{
	var r = r;
	var phi = phi;
	var p : cPolarComplexNumber

	p = cPolarComplexNumber()
	p.r = r
	p.phi = phi

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = p
	return returnReference
}


func cAdd(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> Void{
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a + c
	z1.im = b + d
}


func cAddToNew(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var x : cComplexNumber
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = cComplexNumber()

	x.re = a + c
	x.im = b + d

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cSub(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> Void{
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a - c
	z1.im = b - d
}


func cSubToNew(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var x : cComplexNumber
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = cComplexNumber()

	x.re = a - c
	x.im = b - d

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cMul(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> Void{
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a*c - b*d
	z1.im = b*c + a*d
}


func cMulToNew(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var x : cComplexNumber
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = cComplexNumber()

	x.re = a*c - b*d
	x.im = b*c + a*d

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cDiv(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> Void{
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = (a*c + b*d)/(pow(c, 2.0) + pow(d, 2.0))
	z1.im = (b*c - a*d)/(pow(c, 2.0) + pow(d, 2.0))
}


func cDivToNew(_ z1 : inout cComplexNumber, _ z2 : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var x : cComplexNumber
	var a, b, c, d : Double

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = cComplexNumber()

	x.re = (a*c + b*d)/(pow(c, 2.0) + pow(d, 2.0))
	x.im = (b*c - a*d)/(pow(c, 2.0) + pow(d, 2.0))

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cConjugate(_ z : inout cComplexNumber) -> Void{
	z.im = -z.im
}


func cConjugateToNew(_ z : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var x : cComplexNumber

	x = cComplexNumber()

	x.re = z.re
	x.im = -z.im

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cAbs(_ z : inout cComplexNumber) -> Double{
	var x : Double

	x = sqrt(pow(z.re, 2.0) + pow(z.im, 2.0))

	return x
}


func cArg(_ z : inout cComplexNumber) -> Double{
	var x : Double

	x = Atan2(z.im, z.re)

	return x
}


func cCreatePolarFromComplexNumber(_ z : inout cComplexNumber) -> cPolarComplexNumberReferenceClass{
	var x : cPolarComplexNumber

	x = cPolarComplexNumber()

	x.r = cAbs(&z)
	x.phi = cArg(&z)

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cCreateComplexFromPolar(_ p : inout cPolarComplexNumber) -> cComplexNumberReferenceClass{
	var z : cComplexNumber

	z = cComplexNumber()

	z.re = p.r*cos(p.phi)
	z.im = p.r*sin(p.phi)

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = z
	return returnReference
}


func cRe(_ z : inout cComplexNumber) -> Double{
	return z.re
}


func cIm(_ z : inout cComplexNumber) -> Double{
	return z.im
}


func cAddPolar(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> Void{
	var x : cPolarComplexNumber
	var z1, z2 : cComplexNumber

	z1 = cCreateComplexFromPolar(&p1).ref
	z2 = cCreateComplexFromPolar(&p2).ref

	cAdd(&z1, &z2)

	x = cCreatePolarFromComplexNumber(&z1).ref

	p1.r = x.r
	p1.phi = x.phi

	delete(z1)
	delete(z2)
	delete(x)
}


func cAddPolarToNew(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> cPolarComplexNumberReferenceClass{
	var x : cPolarComplexNumber
	var z1, z2 : cComplexNumber

	z1 = cCreateComplexFromPolar(&p1).ref
	z2 = cCreateComplexFromPolar(&p2).ref

	cAdd(&z1, &z2)

	x = cCreatePolarFromComplexNumber(&z1).ref

	delete(z1)
	delete(z2)

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cSubPolar(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> Void{
	var x : cPolarComplexNumber
	var z1, z2 : cComplexNumber

	z1 = cCreateComplexFromPolar(&p1).ref
	z2 = cCreateComplexFromPolar(&p2).ref

	cSub(&z1, &z2)

	x = cCreatePolarFromComplexNumber(&z1).ref

	p1.r = x.r
	p1.phi = x.phi

	delete(z1)
	delete(z2)
	delete(x)
}


func cSubPolarToNew(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> cPolarComplexNumberReferenceClass{
	var x : cPolarComplexNumber
	var z1, z2 : cComplexNumber

	z1 = cCreateComplexFromPolar(&p1).ref
	z2 = cCreateComplexFromPolar(&p2).ref

	cSub(&z1, &z2)

	x = cCreatePolarFromComplexNumber(&z1).ref

	delete(z1)
	delete(z2)

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cMulPolar(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> Void{
	var r1, r2, phi1, phi2 : Double

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	p1.r = r1*r2
	p1.phi = phi1 + phi2
}


func cMulPolarToNew(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> cPolarComplexNumberReferenceClass{
	var x : cPolarComplexNumber
	var r1, r2, phi1, phi2 : Double

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	x = cPolarComplexNumber()

	x.r = r1*r2
	x.phi = phi1 + phi2

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cDivPolar(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> Void{
	var r1, r2, phi1, phi2 : Double

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	p1.r = r1/r2
	p1.phi = phi1 - phi2
}


func cDivPolarToNew(_ p1 : inout cPolarComplexNumber, _ p2 : inout cPolarComplexNumber) -> cPolarComplexNumberReferenceClass{
	var x : cPolarComplexNumber
	var r1, r2, phi1, phi2 : Double

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	x = cPolarComplexNumber()

	x.r = r1/r2
	x.phi = phi1 - phi2

	var returnReference = cPolarComplexNumberReferenceClass()
	returnReference.ref = x
	return returnReference
}


func cSquareRoot(_ z : inout cComplexNumber) -> Void{
	var a, b, m : Double

	a = z.re
	b = z.im

	m = sqrt(pow(a, 2.0) + pow(b, 2.0))

	z.re = sqrt((m + a)/2.0)
	z.im = Sign(b)*sqrt((m - a)/2.0)
}


func cPowerPolar(_ p : inout cPolarComplexNumber, _ n : Double) -> Void{
	var n = n;
	p.r = pow(p.r, n)
	p.phi = p.phi*n
}


func cPowerToNew(_ z : inout cComplexNumber, _ n : Double) -> cComplexNumberReferenceClass{
	var n = n;
	var p : cPolarComplexNumber
	var zp : cComplexNumber

	p = cCreatePolarFromComplexNumber(&z).ref
	cPowerPolar(&p, n)
	zp = cCreateComplexFromPolar(&p).ref

	delete(p)

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = zp
	return returnReference
}


func cPower(_ z : inout cComplexNumber, _ n : Double) -> Void{
	var n = n;
	var zp : cComplexNumber

	zp = cPowerToNew(&z, n).ref
	z.re = zp.re
	z.im = zp.im

	delete(zp)
}


func cNegate(_ z : inout cComplexNumber) -> Void{
	z.re = Negate(z.re)
	z.im = Negate(z.im)
}


func cAssignComplexByValues(_ s : inout cComplexNumber, _ re : Double, _ im : Double) -> Void{
	var re = re;
	var im = im;
	s.re = re
	s.im = im
}


func cAssignComplex(_ a : inout cComplexNumber, _ b : inout cComplexNumber) -> Void{
	a.re = b.re
	a.im = b.im
}


func cEpsilonCompareComplex(_ a : inout cComplexNumber, _ b : inout cComplexNumber, _ epsilon : Double) -> Bool{
	var epsilon = epsilon;
	return EpsilonCompare(a.re, b.re, epsilon) && EpsilonCompare(a.im, b.im, epsilon)
}


func cExpComplex(_ x : inout cComplexNumber) -> Void{
	var re, im : Double

	re = exp(x.re)*cos(x.im)
	im = exp(x.re)*sin(x.im)
	x.re = re
	x.im = im
}


func cSineComplex(_ x : inout cComplexNumber) -> Void{
	var re, im : Double

	re = sin(x.re)*Cosh(x.im)
	im = cos(x.re)*Sinh(x.im)
	x.re = re
	x.im = im
}


func cCosineComplex(_ x : inout cComplexNumber) -> Void{
	var re, im : Double

	re = cos(x.re)*Cosh(x.im)
	im = sin(x.re)*Sinh(x.im)
	x.re = re
	x.im = im
}


func cComplexToString(_ a : inout cComplexNumber) -> [Character]{
	var str, number : [Character]
	var ll : LinkedListCharacters
	var i : Double

	ll = CreateLinkedListCharacter().ref

	number = CreateStringDecimalFromNumber(a.re)

	i = 0.0
	while(i < Double(number.count)){
		LinkedListAddCharacter(&ll, number[Int(i)])
		i = i + 1.0
	}

	delete(number)

	if(a.im < 0.0){
		LinkedListAddCharacter(&ll, "-")
		number = CreateStringDecimalFromNumber(-a.im)
	}else{
		LinkedListAddCharacter(&ll, "+")
		number = CreateStringDecimalFromNumber(a.im)
	}

	i = 0.0
	while(i < Double(number.count)){
		LinkedListAddCharacter(&ll, number[Int(i)])
		i = i + 1.0
	}

	delete(number)

	LinkedListAddCharacter(&ll, "i")

	str = LinkedListCharactersToArray(&ll)
	FreeLinkedListCharacter(&ll)

	return str
}


func pPolynomialToTextDirect(_ p : inout [Double], _ x : inout [Character]) -> [Character]{
	var ll : LinkedListCharacters
	var str : [Character]
	var i, c, j : Double
	var buffer : StringReference

	buffer = StringReference()

	ll = CreateLinkedListCharacter().ref

	if(Double(p.count) == 0.0){
		LinkedListAddCharacter(&ll, "0")
	}else{
		i = 0.0
		while(i < Double(p.count)){
			c = p[Int(i)]
			if(c < 0.0){
				LinkedListAddCharacter(&ll, "-")
			}else{
				LinkedListAddCharacter(&ll, "+")
			}

			CreateStringFromNumberWithCheck(abs(c), 10.0, &buffer)
			LinkedListCharactersAddString(&ll, &buffer.stringx)
			delete(buffer.stringx)

			LinkedListCharactersAddString(&ll, &x)
			LinkedListAddCharacter(&ll, "^")

			CreateStringFromNumberWithCheck(i, 10.0, &buffer)
			LinkedListCharactersAddString(&ll, &buffer.stringx)
			delete(buffer.stringx)
			i = i + 1.0
		}
	}

	str = LinkedListCharactersToArray(&ll)
	FreeLinkedListCharacter(&ll)

	return str
}


func pGenerateCommonRenderSpecification(_ p : inout [Double], _ showCoefficient : inout BooleanArrayReference, _ sign : inout StringReference, _ coefficient : inout NumberArrayReference, _ showPower : inout BooleanArrayReference, _ showX : inout BooleanArrayReference) -> Void{
	var i, zeros, c : Double
	var setZero : Bool

	setZero = false

	if(Double(p.count) == 0.0){
		setZero = true
	}else{
		zeros = 0.0
		i = 0.0
		while(i < Double(p.count)){
			if(p[Int(i)] == 0.0){
				zeros = zeros + 1.0
			}
			i = i + 1.0
		}

		if(zeros == Double(p.count)){
			setZero = true
		}else{
			showCoefficient.booleanArray = Array(repeating:Bool(), count: Int(Double(p.count)))
			sign.stringx = Array(repeating:Character(" "), count: Int(Double(p.count)))
			coefficient.numberArray = Array(repeating:Double(), count: Int(Double(p.count)))
			showPower.booleanArray = Array(repeating:Bool(), count: Int(Double(p.count)))
			showX.booleanArray = Array(repeating:Bool(), count: Int(Double(p.count)))

			i = 0.0
			while(i < Double(p.count)){
				c = p[Int(i)]

				if(c < 0.0){
					sign.stringx[Int(i)] = "-"
				}else{
					sign.stringx[Int(i)] = "+"
				}
				coefficient.numberArray[Int(i)] = abs(p[Int(i)])
				if(c == 0.0){
					showCoefficient.booleanArray[Int(i)] = false
				}else{
if(abs(c) == 1.0 && i > 0.0){
						showCoefficient.booleanArray[Int(i)] = false
					}else{
						showCoefficient.booleanArray[Int(i)] = true
					}

					if(i == 0.0){
						showX.booleanArray[Int(i)] = false
						showPower.booleanArray[Int(i)] = false
					}else{
						showX.booleanArray[Int(i)] = true
						if(i == 1.0){
							showPower.booleanArray[Int(i)] = false
						}else{
							showPower.booleanArray[Int(i)] = true
						}
					}
				}
				i = i + 1.0
			}
		}
	}

	if(setZero){
		showCoefficient.booleanArray = Array(repeating:Bool(), count: Int(1))
		sign.stringx = Array(repeating:Character(" "), count: Int(1))
		coefficient.numberArray = Array(repeating:Double(), count: Int(1))
		showPower.booleanArray = Array(repeating:Bool(), count: Int(1))
		showX.booleanArray = Array(repeating:Bool(), count: Int(1))

		showCoefficient.booleanArray[Int(0)] = true
		sign.stringx[Int(0)] = "+"
		coefficient.numberArray[Int(0)] = 0.0
		showPower.booleanArray[Int(0)] = true
		showX.booleanArray[Int(0)] = false
	}
}


func pPolynomialToText(_ p : inout [Double], _ x : inout [Character]) -> [Character]{
	var ll : LinkedListCharacters
	var str : [Character]
	var i, c : Double
	var buffer : StringReference
	var showCoefficient, showPower, showX : BooleanArrayReference
	var sign : StringReference
	var coefficient : NumberArrayReference
	var hasPrinted : Bool

	showCoefficient = CreateBooleanArrayReferenceLengthValue(0.0, false).ref
	showPower = CreateBooleanArrayReferenceLengthValue(0.0, false).ref
	showX = CreateBooleanArrayReferenceLengthValue(0.0, false).ref
	sign = CreateStringReferenceLengthValue(0.0, " ").ref
	coefficient = CreateNumberArrayReferenceLengthValue(0.0, 0.0).ref

	pGenerateCommonRenderSpecification(&p, &showCoefficient, &sign, &coefficient, &showPower, &showX)

	buffer = CreateStringReferenceLengthValue(0.0, " ").ref

	ll = CreateLinkedListCharacter().ref

	hasPrinted = false
	i = 0.0
	while(i < Double(showCoefficient.booleanArray.count)){
		c = p[Int(i)]

		if(showCoefficient.booleanArray[Int(i)] || showX.booleanArray[Int(i)]){
			if(!hasPrinted && c >= 0.0){
			}else{
				LinkedListAddCharacter(&ll, sign.stringx[Int(i)])
			}

			if(showCoefficient.booleanArray[Int(i)]){
				CreateStringFromNumberWithCheck(coefficient.numberArray[Int(i)], 10.0, &buffer)
				LinkedListCharactersAddString(&ll, &buffer.stringx)
				delete(buffer.stringx)
				hasPrinted = true
			}

			if(showX.booleanArray[Int(i)]){
				LinkedListCharactersAddString(&ll, &x)
				hasPrinted = true
				if(showPower.booleanArray[Int(i)]){
					LinkedListAddCharacter(&ll, "^")
					CreateStringFromNumberWithCheck(i, 10.0, &buffer)
					LinkedListCharactersAddString(&ll, &buffer.stringx)
					delete(buffer.stringx)
				}
			}
		}
		i = i + 1.0
	}

	str = LinkedListCharactersToArray(&ll)
	FreeLinkedListCharacter(&ll)

	return str
}


func pComplexPolynomialToTextDirect(_ p : inout pComplexPolynomial, _ x : inout [Character]) -> [Character]{
	var ll : LinkedListCharacters
	var str, number : [Character]
	var i : Double
	var c : cComplexNumber
	var buffer : StringReference

	buffer = StringReference()

	ll = CreateLinkedListCharacter().ref

	if(Double(p.cs.count) == 0.0){
		LinkedListAddCharacter(&ll, "0")
	}else{
		i = 0.0
		while(i < Double(p.cs.count)){
			c = p.cs[Int(i)]
			if(i > 0.0){
				LinkedListAddCharacter(&ll, "+")
			}

			number = cComplexToString(&c)
			LinkedListAddCharacter(&ll, "(")
			LinkedListCharactersAddString(&ll, &number)
			LinkedListAddCharacter(&ll, ")")
			delete(number)

			LinkedListCharactersAddString(&ll, &x)
			LinkedListAddCharacter(&ll, "^")

			CreateStringFromNumberWithCheck(i, 10.0, &buffer)
			LinkedListCharactersAddString(&ll, &buffer.stringx)
			delete(buffer.stringx)
			i = i + 1.0
		}
	}

	str = LinkedListCharactersToArray(&ll)
	FreeLinkedListCharacter(&ll)

	return str
}


func pAdd(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i, nr : Double

	nr = Double(b.count)

	i = 0.0
	while(i < nr){
		a[Int(i)] = a[Int(i)] + b[Int(i)]
		i = i + 1.0
	}
}


func pSubtract(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i, nr : Double

	nr = Double(b.count)

	i = 0.0
	while(i < nr){
		a[Int(i)] = a[Int(i)] - b[Int(i)]
		i = i + 1.0
	}
}


func pMultiply(_ c : inout [Double], _ a : inout [Double], _ b : inout [Double]) -> Void{
	var k, n, m, i : Double
	var av, bv : Double

	n = pDegree(&a)
	m = pDegree(&b)

	pFill(&c, 0.0)

	i = 0.0
	while(i <= n + m){
		c[Int(i)] = 0.0
		k = 0.0
		while(k <= i && k < Double(a.count) && i - k < Double(b.count)){
			av = a[Int(k)]
			bv = b[Int(i - k)]
			c[Int(i)] = c[Int(i)] + av*bv
			k = k + 1.0
		}
		i = i + 1.0
	}
}


func pDivide(_ q : inout [Double], _ r : inout [Double], _ n : inout [Double], _ d : inout [Double]) -> Void{
	var t, t1 : [Double]
	var tcoff, tdegree, i : Double
	var deg : Double
	var rd, dd : Double

	pFill(&q, 0.0)
	pAssign(&r, &n)
	deg = pDegree(&n)
	t = pCreatePolynomial(deg)
	t1 = pCreatePolynomial(deg)

	rd = pDegree(&r)
	dd = pDegree(&d)
	i = 0.0
	while(i < deg + 1.0 && !pIsZero(&r) && rd - i >= dd){
		pFill(&t, 0.0)
		tdegree = rd - i - dd
		tcoff = r[Int(rd - i)]/d[Int(dd)]
		t[Int(tdegree)] = tcoff
		pAdd(&q, &t)
		pFill(&t1, 0.0)
		pMultiply(&t1, &t, &d)
		pSubtract(&r, &t1)
		i = i + 1.0
	}

	delete(t)
	delete(t1)
}


func pIsZero(_ a : inout [Double]) -> Bool{
	var i : Double
	var itIsZero : Bool

	itIsZero = true

	i = 0.0
	while(i < Double(a.count)){
		if(a[Int(i)] != 0.0){
			itIsZero = false
		}
		i = i + 1.0
	}

	return itIsZero
}


func pAssign(_ a : inout [Double], _ b : inout [Double]) -> Void{
	var i, nr : Double

	nr = Double(b.count)

	i = 0.0
	while(i < nr){
		a[Int(i)] = b[Int(i)]
		i = i + 1.0
	}
}


func pCreatePolynomial(_ deg : Double) -> [Double]{
	var deg = deg;
	var p : [Double]

	p = Array(repeating:Double(), count: Int(deg + 1.0))

	pFill(&p, 0.0)

	return p
}


func pFill(_ p : inout [Double], _ value : Double) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(p.count)){
		p[Int(i)] = value
		i = i + 1.0
	}
}


func pDegree(_ A : inout [Double]) -> Double{
	var i : Double
	var deg : Double
	var done : Bool

	done = false
	deg = 0.0
	i = Double(A.count) - 1.0
	while(i >= 0.0 && !done){
		if(A[Int(i)] != 0.0){
			deg = i
			done = true
		}
		i = i - 1.0
	}

	return deg
}


func pLead(_ A : inout [Double]) -> Double{
	var deg : Double

	deg = pDegree(&A)

	return A[Int(deg)]
}


func pEvaluate(_ A : inout [Double], _ x : Double) -> Double{
	var x = x;
	return pEvaluateWithHornersMethod(&A, x)
}


func pEvaluateWithHornersMethod(_ A : inout [Double], _ x : Double) -> Double{
	var x = x;
	var r, i : Double

	r = 0.0

	i = Double(A.count) - 1.0
	while(i >= 0.0){
		r = r*x
		r = A[Int(i)] + r
		i = i - 1.0
	}

	return r
}


func pEvaluateWithPowers(_ A : inout [Double], _ x : Double) -> Double{
	var x = x;
	var r, i : Double

	r = 0.0

	i = 0.0
	while(i < Double(A.count)){
		r = r + A[Int(i)]*pow(x, i)
		i = i + 1.0
	}

	return r
}


func pEvaluateDerivative(_ A : inout [Double], _ x : Double, _ n : Double) -> Double{
	var x = x;
	var n = n;
	var r, i, v : Double

	r = 0.0

	i = 0.0
	while(i < Double(A.count)){
		if(i - n >= 0.0){
			v = A[Int(i)]*Permutations(i, n)*pow(x, i - n)
			r = r + v
		}
		i = i + 1.0
	}

	return r
}


func pDerivative(_ A : inout [Double]) -> Void{
	var i, degree : Double

	degree = 0.0
	i = 1.0
	while(i < Double(A.count)){
		degree = degree + 1.0
		A[Int(i - 1.0)] = degree*A[Int(i)]
		i = i + 1.0
	}

	A[Int(Double(A.count) - 1.0)] = 0.0
}


func pAddComplex(_ a : inout pComplexPolynomial, _ b : inout pComplexPolynomial) -> Void{
	var i, nr : Double

	nr = Double(a.cs.count)

	i = 0.0
	while(i < nr){
		cAdd(&a.cs[Int(i)], &b.cs[Int(i)])
		i = i + 1.0
	}
}


func pSubtractComplex(_ a : inout pComplexPolynomial, _ b : inout pComplexPolynomial) -> Void{
	var i, nr : Double

	nr = Double(a.cs.count)

	i = 0.0
	while(i < nr){
		cSub(&a.cs[Int(i)], &b.cs[Int(i)])
		i = i + 1.0
	}
}


func pIsZeroComplex(_ a : inout pComplexPolynomial) -> Bool{
	var i : Double
	var itIsZero : Bool

	itIsZero = true

	i = 0.0
	while(i < Double(a.cs.count)){
		if(a.cs[Int(i)].re != 0.0 && a.cs[Int(i)].im != 0.0){
			itIsZero = false
		}
		i = i + 1.0
	}

	return itIsZero
}


func pAssignComplex(_ a : inout pComplexPolynomial, _ b : inout pComplexPolynomial) -> Void{
	var i, nr : Double

	nr = Double(b.cs.count)

	i = 0.0
	while(i < nr){
		cAssignComplex(&a.cs[Int(i)], &b.cs[Int(i)])
		i = i + 1.0
	}
}


func pCreateComplexPolynomial(_ deg : Double) -> pComplexPolynomialReferenceClass{
	var deg = deg;
	var p : pComplexPolynomial
	var i : Double

	p = pComplexPolynomial()
	p.cs = Array(repeating:cComplexNumber(), count: Int(deg + 1.0))

	i = 0.0
	while(i < deg + 1.0){
		p.cs[Int(i)] = cComplexNumber()
		i = i + 1.0
	}

	pFillComplex(&p, 0.0, 0.0)

	var returnReference = pComplexPolynomialReferenceClass()
	returnReference.ref = p
	return returnReference
}


func pFillComplex(_ p : inout pComplexPolynomial, _ re : Double, _ im : Double) -> Void{
	var re = re;
	var im = im;
	var i : Double
	var c : cComplexNumber

	c = cCreateComplexNumber(re, im).ref

	i = 0.0
	while(i < Double(p.cs.count)){
		cAssignComplex(&p.cs[Int(i)], &c)
		i = i + 1.0
	}

	delete(c)
}


func pDegreeComplex(_ A : inout pComplexPolynomial) -> Double{
	var i : Double
	var deg : Double
	var done : Bool

	done = false
	deg = 0.0
	i = Double(A.cs.count) - 1.0
	while(i >= 0.0 && !done){
		if(A.cs[Int(i)].re != 0.0 && A.cs[Int(i)].im != 0.0){
			deg = i
			done = true
		}
		i = i - 1.0
	}

	return deg
}


func pLeadComplex(_ A : inout pComplexPolynomial) -> cComplexNumberReferenceClass{
	var deg : Double

	deg = pDegreeComplex(&A)

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = A.cs[Int(deg)]
	return returnReference
}


func pEvaluateComplex(_ A : inout pComplexPolynomial, _ x : inout cComplexNumber) -> cComplexNumberReferenceClass{
	var i : Double
	var r, t : cComplexNumber

	r = cCreateComplexNumber(0.0, 0.0).ref
	t = cCreateComplexNumber(0.0, 0.0).ref

	i = 0.0
	while(i < Double(A.cs.count)){
		cAssignComplex(&t, &x)
		cPower(&t, i)
		cMul(&t, &A.cs[Int(i)])
		cAdd(&r, &t)
		i = i + 1.0
	}

	var returnReference = cComplexNumberReferenceClass()
	returnReference.ref = r
	return returnReference
}


func pTotalNumberOfRoots(_ p : inout [Double]) -> Double{
	return pDegree(&p)
}


func delete(_ x : Any){
	// Swift has reference counting.
}

