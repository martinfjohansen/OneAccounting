package com.martinfjohansen.oneaccounting.Plots.Plots;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;

public class ScatterPlotSettings{
	public ScatterPlotSeries [] scatterPlotSeries;
	public boolean autoBoundaries;
	public double xMax;
	public double xMin;
	public double yMax;
	public double yMin;
	public boolean autoPadding;
	public double xPadding;
	public double yPadding;
	public char [] xLabel;
	public char [] yLabel;
	public char [] title;
	public boolean showGrid;
	public RGBA gridColor;
	public boolean xAxisAuto;
	public boolean xAxisTop;
	public boolean xAxisBottom;
	public boolean yAxisAuto;
	public boolean yAxisLeft;
	public boolean yAxisRight;
	public double width;
	public double height;
}
