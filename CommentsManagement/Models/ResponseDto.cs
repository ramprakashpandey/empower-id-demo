﻿#pragma warning disable

namespace CommentsManagement.Models
{
    /// <summary>
    /// DTO: ResponseDto
    /// </summary>
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
