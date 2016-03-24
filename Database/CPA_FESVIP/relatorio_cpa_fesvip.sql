



SELECT 
	tform.nome 	 	TIPO_AVALIACAO,
	form.nome  	 	FORMULARIO,
	tquestao.descricao   	CRITERIO,
	questao.enredo	  	QUESTAO,
	case when tquestao.nota_max = 2 then
			case when av.nota = 1 then 'SIM' else 'NAO' end 
		
		when av.nota = 1 then 'RUIM'
		when av.nota = 2 then 'REGULAR'
		when av.nota = 3 then 'BOM'
		when av.nota = 4 then 'OTIMO'
		end		NOTA

FROM
	acad_cpa_formulario form,
	acad_cpa_tipo_formulario tform,
	acad_cpa_questao questao,
	acad_cpa_categoria_questao tquestao,
	acad_cpa_avaliacao av
WHERE
	form."TIPO_FORMULARIO" = tform.codigo and
	questao."CATEGORIA_QUESTAO" = tquestao.codigo and
	av."QUESTAO" = questao.codigo and
	av."FORMULARIO" = form.codigo and
	form."CPA" = 1
