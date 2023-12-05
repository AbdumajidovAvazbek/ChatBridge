﻿using ChatBridge.Domain.Enums;

namespace ChatBridge.Service.Dtos.Messages;

public class MessageForUpdateDto
{
    public MessageType Type { get; set; }
    public FormatType FormatType { get; set; }

    public long? ParentId { get; set; }

    public long ToId { get; set; }
}
