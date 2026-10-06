package com.martinfjohansen.oneaccounting.Plots.BarPlot;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

public class BarPlotSettings{
	public double width;
	public double height;
	public boolean autoBoundaries;
	public double yMax;
	public double yMin;
	public boolean autoPadding;
	public double xPadding;
	public double yPadding;
	public char [] title;
	public boolean showGrid;
	public RGBA gridColor;
	public BarPlotSeries [] barPlotSeries;
	public char [] yLabel;
	public boolean autoColor;
	public boolean grayscaleAutoColor;
	public boolean autoSpacing;
	public double groupSeparation;
	public double barSeparation;
	public boolean autoLabels;
	public StringReference[] xLabels;
	public boolean barBorder;
}
