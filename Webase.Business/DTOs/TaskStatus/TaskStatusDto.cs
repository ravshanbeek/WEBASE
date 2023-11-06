namespace Webase.Business.DTOs;

public record TaskStatusDto(
    int id,
    int statusId,
    int statusName);