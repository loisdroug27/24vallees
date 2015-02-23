vec4 CompositeBottomAndTop(vec4 bottom, float bottomAlpha, vec4 top, float topAlpha)
{
	
	vec4		darkenedBottom = vec4(bottomAlpha) * bottom;
	vec4		darkenedTop = vec4(topAlpha) * top;
	float		fgLuminosity = 0.3 * darkenedTop.r + 0.59*darkenedTop.g + 0.11 * darkenedTop.b;
	float		bgLuminosity = 0.3 * darkenedBottom.r + 0.59*darkenedBottom.g + 0.11 * darkenedBottom.b;
	vec4		returnMe;
	returnMe.r = (fgLuminosity > bgLuminosity)
		? top.r
		: darkenedBottom.r;
	returnMe.g = (fgLuminosity > bgLuminosity)
		? top.g
		: darkenedBottom.g;
	returnMe.b = (fgLuminosity > bgLuminosity)
		? top.b
		: darkenedBottom.b;
	
	//returnMe.a = (fgLuminosity > bgLuminosity)
	//	? top.a
	//	: darkenedBottom.a;
	returnMe.a = top.a;
	returnMe = mix(darkenedBottom, returnMe, topAlpha*top.a);
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
