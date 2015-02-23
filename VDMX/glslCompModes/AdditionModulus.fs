vec4 CompositeBottomAndTop(vec4 bottom, float bottomAlpha, vec4 top, float topAlpha)
{
	
	vec4		returnMe = (vec4(bottomAlpha)*bottom) + (vec4(topAlpha)*top);
	returnMe.r = (returnMe.r > 1.0) ? (returnMe.r - 1.0) : returnMe.r;
	returnMe.g = (returnMe.g > 1.0) ? (returnMe.g - 1.0) : returnMe.g;
	returnMe.b = (returnMe.b > 1.0) ? (returnMe.b - 1.0) : returnMe.b;
	//returnMe.a = (returnMe.a > 1.0) ? (returnMe.a - 1.0) : returnMe.a;
	returnMe.a = 1.0;
	return returnMe;
	
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
