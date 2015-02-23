vec4 CompositeBottomAndTop(vec4 bottom, float bottomAlpha, vec4 top, float topAlpha)
{
	vec4		darkenedBottom = vec4(bottomAlpha) * bottom;
	vec4		returnMe = abs((vec4(topAlpha)*top)-darkenedBottom);
	returnMe.a = top.a;
	returnMe = mix(darkenedBottom, returnMe, topAlpha*top.a);
	return returnMe;
	
	/*
	vec4		newBottom = vec4(bottomAlpha) * bottom;
	vec4		newTop;
	
	newTop.r = (top.r>newBottom.r) ? (top.r-newBottom.r) : (newBottom.r-top.r);
	newTop.g = (top.g>newBottom.g) ? (top.g-newBottom.g) : (newBottom.g-top.g);
	newTop.b = (top.b>newBottom.b) ? (top.b-newBottom.b) : (newBottom.b-top.b);
	newTop.a = 1.0;
	
	return mix(newBottom,newTop,topAlpha);
	*/
	
	
	/*
	vec4		newBottom = vec4(bottomAlpha) * bottom;
	vec4		newTop;
	
	newTop.r = (top.r>newBottom.r) ? (top.r-newBottom.r) : (newBottom.r-top.r);
	newTop.g = (top.g>newBottom.g) ? (top.g-newBottom.g) : (newBottom.g-top.g);
	newTop.b = (top.b>newBottom.b) ? (top.b-newBottom.b) : (newBottom.b-top.b);
	//newTop.a = (top.a>newBottom.a) ? (top.a-newBottom.a) : (newBottom.a-top.a);
	newTop.a = 1.0;
	
	return mix(newBottom,newTop,topAlpha);
	*/
}


vec4 CompositeBottom(vec4 bottom, float bottomAlpha)	{
	vec4		returnMe = vec4(bottomAlpha)*bottom;
	returnMe.a = 1.0;
	return returnMe;
}
vec4 CompositeTop(vec4 top, float topAlpha)	{
	vec4		returnMe = vec4(topAlpha)*top;
	returnMe.a = 1.0;
	return returnMe;
}
