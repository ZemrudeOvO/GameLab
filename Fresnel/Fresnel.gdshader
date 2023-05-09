shader_type spatial;

varying float fresnel;

void fragment() {
	fresnel = sqrt(1.0-dot(NORMAL,VIEW));
	ROUGHNESS = 0.01 * (1.0 - fresnel);
	ALBEDO = vec3(0,0,0)+fresnel;
}
